using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kaffemaskine
{
    public abstract class Machine
    {
        protected bool isTurnedOn;

        public Machine()
        {
            isTurnedOn = false;
        }
        public virtual string TurnOn()
        {
            if (isTurnedOn)
            {
                return "Kaffemaskinen er allerede tændt";
            }
            isTurnedOn = true;
            return "Kaffemaskinen er tændt";
        }

        public virtual string TurnOff()
        {
            if (!isTurnedOn)
            {
                return "Kaffemaskinen er allerede slukket";
            }
            isTurnedOn = false;
            return "Kaffemaskinen er slukket";
        }        
    }
}
