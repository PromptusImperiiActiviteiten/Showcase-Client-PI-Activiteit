using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;

namespace Showcase_Client_PI_Activiteit
{
    public class SimpleClient
    {
        private TcpClient client;
        private NetworkStream stream;

        public void ConnectToServer(string ipAddress, int port)
        {
            client = new TcpClient(ipAddress, port);
            stream = client.GetStream();
            Console.WriteLine("Connected to the server.");
                       
        }

        public void ReadMessages(Form1 form)
        {
            byte[] buffer = new byte[1024];
            int bytesRead;
            while ((bytesRead = stream.Read(buffer, 0, buffer.Length)) > 0)
            {
                string message = Encoding.UTF8.GetString(buffer, 0, bytesRead);
                form.Invoke((MethodInvoker)(() => form.textBox2.AppendText($"" + message + Environment.NewLine)));


            }
        }


        public void SendMessage(string message)
        {
            if (stream != null && stream.CanWrite)
            {
                byte[] data = Encoding.UTF8.GetBytes(message);
                stream.Write(data, 0, data.Length);
                Console.WriteLine("Message sent: " + message);
            }
        }
        public void SendInitializingMessage(string name)
        {
            if (stream != null && stream.CanWrite)
            {
                byte[] data = Encoding.UTF8.GetBytes("$Init$:Client Name:$[" + name + "]$");
                stream.Write(data, 0, data.Length);
            }
        }
    }
}
