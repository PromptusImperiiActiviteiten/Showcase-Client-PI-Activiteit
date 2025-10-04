using Showcase_Client_PI_Activiteit.States;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Showcase_Client_PI_Activiteit
{
    public class ConnectionService
    {
        public TcpClient client { get; private set; }
        public NetworkStream stream { get; private set; }
        public AbstractState currentActiveState { get; private set; }

        public ConnectionService()
        {
            currentActiveState = new LoginState(this);
        }

        public void ConnectToServer(string ipAddress, int port)
        {
            client = new TcpClient(ipAddress, port);
            stream = client.GetStream();
            Console.WriteLine("Connected to the server.");

            if (stream !=null && stream.CanRead)
            {
                Thread thread1 = new Thread(() => Program.client.ReadMessages());
                thread1.IsBackground = true;
                thread1.Start();
            }
        }

        public void ReadMessages()
        {
            byte[] buffer = new byte[1024];
            int bytesRead;

            while ((bytesRead = stream.Read(buffer, 0, buffer.Length)) > 0)
            {
                string incommingServerMessage = Encoding.UTF8.GetString(buffer, 0, bytesRead);
                currentActiveState.HandleMessage(incommingServerMessage);
            }
        }

        public void ChangeState(AbstractState newState) {
            currentActiveState = newState;
        }
    }
}
