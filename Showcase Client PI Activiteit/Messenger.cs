using Showcase_Client_PI_Activiteit.WindowsForms;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Showcase_Client_PI_Activiteit
{
    class Messenger
    {
        public static void SendChatMessage(string message, NetworkStream stream)
        {
            message = "102:" + message;
            FormsCommands.ShowMessageInChatbox(message);

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
