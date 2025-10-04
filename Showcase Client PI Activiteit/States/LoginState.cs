using Showcase_Client_PI_Activiteit.WindowsForms;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Showcase_Client_PI_Activiteit.States
{
    class LoginState(ConnectionService client) : AbstractState(client)
    {
        public override void HandleMessage(string incommingServerMessage)
        {
            if (incommingServerMessage.StartsWith("211:"))
            {
                FormsCommands.GoToChatroom();
                FormsCommands.ShowMessageInChatbox(incommingServerMessage);
                client.ChangeState(new ChattingState(client));
            }
        }
    }
}
