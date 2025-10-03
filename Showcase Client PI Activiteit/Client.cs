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
    public class Client
    {
        private TcpClient client;
        private NetworkStream stream;
        private Regex incomingMessageRegex = new Regex(@"^2\d{2}:");

        public void ConnectToServer(string ipAddress, int port)
        { 
            client = new TcpClient(ipAddress, port);
            stream = client.GetStream();
            Console.WriteLine("Connected to the server.");
                       
        }

        public void ReadMessages(ChatroomForm form)
        {
            byte[] buffer = new byte[1024];
            int bytesRead;
            
            while ((bytesRead = stream.Read(buffer, 0, buffer.Length)) > 0)
            {
                string message = Encoding.UTF8.GetString(buffer, 0, bytesRead);
                if (incomingMessageRegex.IsMatch(message))
                {
                    form.Invoke((MethodInvoker)(() => form.chatroomTextbox.AppendText($"" + message + Environment.NewLine)));
                }
            }
        }


        public void SendMessage(string message, ChatroomForm form)
        {
            if (stream != null && stream.CanWrite)
            {
                message = "102:" + message;
                byte[] data = Encoding.UTF8.GetBytes(message);
                stream.Write(data, 0, data.Length);

                form.Invoke((MethodInvoker)(() => form.chatroomTextbox.AppendText($"" + message + Environment.NewLine)));
            }
        }
        public void SendInitializingMessage(string name)
        {
            if (stream != null && stream.CanWrite)
            {
                byte[] data = Encoding.UTF8.GetBytes("101:" + name);
                stream.Write(data, 0, data.Length);
            }
        }
    }
}
