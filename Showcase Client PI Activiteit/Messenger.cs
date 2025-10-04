using Showcase_Client_PI_Activiteit.WindowsForms;
using System.Net.Sockets;
using System.Text;


namespace Showcase_Client_PI_Activiteit
{
    class Messenger
    {
        public static void SendChatMessage(string outgoingChatMessage, NetworkStream clientNetworkStream)
        {

            FormsCommands.ShowMessageInChatbox("You:" + outgoingChatMessage);
            if (outgoingChatMessage.StartsWith("/whisper:"))
            {
                outgoingChatMessage = "103:" + outgoingChatMessage.Substring(9);
            }
            else {
                outgoingChatMessage = "102:" + outgoingChatMessage;

            }
            
            

            if (clientNetworkStream != null && clientNetworkStream.CanWrite)
            {
                byte[] data = Encoding.UTF8.GetBytes(outgoingChatMessage);
                clientNetworkStream.Write(data, 0, data.Length);
            }
        }

        public static void SendInitializingMessage(string newClientName, NetworkStream clientNetworkStream)
        {
            if (clientNetworkStream != null && clientNetworkStream.CanWrite)
            {
                byte[] data = Encoding.UTF8.GetBytes("101:" + newClientName);
                clientNetworkStream.Write(data, 0, data.Length);
            }
        }

    }
}
