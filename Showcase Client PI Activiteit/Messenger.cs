using Showcase_Client_PI_Activiteit.WindowsForms;
using System.Diagnostics.CodeAnalysis;
using System.Net.Sockets;
using System.Text;
using System.Text.RegularExpressions;
using System.Web;


namespace Showcase_Client_PI_Activiteit
{
    class Messenger
    {
        public static void SendChatMessage(string rawOutgoingChatMessage, NetworkStream clientNetworkStream)
        {
            string outgoingChatMessage;
            string commandRecognissionRegexString = @"^\/.*[\s|:]";
            Regex commandRecognissionRegex = new Regex(commandRecognissionRegexString);

            FormsCommands.ShowMessageInChatbox("You:" + rawOutgoingChatMessage);

            if (commandRecognissionRegex.IsMatch(rawOutgoingChatMessage))
            {
                outgoingChatMessage = FindServerCommand(rawOutgoingChatMessage);
            }
            else {
                outgoingChatMessage = "101:" + rawOutgoingChatMessage;
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
                byte[] data = Encoding.UTF8.GetBytes("111:" + newClientName);
                clientNetworkStream.Write(data, 0, data.Length);
            }
        }

        private static string FindServerCommand(string potentialCommand) {
            string outgoingMessage;

            switch (potentialCommand) {
                case { } when potentialCommand.StartsWith("/whisper:"):
                    string messageWithoutCommand = potentialCommand.Substring(potentialCommand.IndexOf(":")+1);
                    outgoingMessage = "102:" + messageWithoutCommand;
                    return outgoingMessage;
                default:
                    outgoingMessage = "121:" + potentialCommand;
                    return outgoingMessage;    
            }
        }
    }
}
