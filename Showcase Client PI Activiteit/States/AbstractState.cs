using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Showcase_Client_PI_Activiteit.States
{
    public abstract class AbstractState
    {
        protected Client client;

        protected AbstractState(Client client)
        {
            this.client = client;
        }

        public abstract void HandleMessage(string message);
    }
}
