using Showcase_Client_PI_Activiteit.WindowsForms;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Showcase_Client_PI_Activiteit.States
{
    class ChattingState(Client client) : AbstractState(client)
    {

        public override void HandleMessage(string message)
        {
            FormsCommands.ShowMessageInChatbox(message);
        }
    }
}
