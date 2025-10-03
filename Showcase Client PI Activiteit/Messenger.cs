using Showcase_Client_PI_Activiteit.WindowsForms;
using System.Net.Sockets;
using System.Text;


namespace Showcase_Client_PI_Activiteit
{
    class Messenger
    {
        public static void SendChatMessage(string message, NetworkStream stream)
        {

            FormsCommands.ShowMessageInChatbox("You:" + message);
            if (message.StartsWith("/whisper:"))
            {
                message = "103:" + message.Substring(9);
            }
            else {
                message = "102:" + message;

            }
            
            

            if (stream != null && stream.CanWrite)
            {
                byte[] data = Encoding.UTF8.GetBytes(message);
                stream.Write(data, 0, data.Length);
            }
        }

        public static void SendInitializingMessage(string name, NetworkStream stream)
        {
            if (stream != null && stream.CanWrite)
            {
                byte[] data = Encoding.UTF8.GetBytes("101:" + name);
                stream.Write(data, 0, data.Length);
            }
        }

    }
}
