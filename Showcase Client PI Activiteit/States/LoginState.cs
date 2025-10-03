using Showcase_Client_PI_Activiteit.WindowsForms;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Showcase_Client_PI_Activiteit.States
{
    class LoginState(Client client) : AbstractState(client)
    {
        public override void HandleMessage(string message)
        {
            if (message.StartsWith("212:")) {
                FormsCommands.GoToChatroom();
                client.ChangeState(new ChattingState(client));
            }
        }
    }
}
