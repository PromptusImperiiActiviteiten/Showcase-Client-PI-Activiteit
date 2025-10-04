using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Showcase_Client_PI_Activiteit.WindowsForms
{
    public class FormsCommands
    {
        public static void GoToChatroom()
        {
            Program.loginScreen.Invoke(new Action(() => { Program.chatroom.Show(); }));
            Program.loginScreen.Invoke(new Action(() => { Program.loginScreen.Hide(); }));
        }

        public static void ShowMessageInChatbox(string newChatboxMessage)
        {
            Program.chatroom.Invoke((MethodInvoker)(() => Program.chatroom.chatroomTextbox.AppendText($"" + newChatboxMessage + Environment.NewLine)));
        }
    }
}
