using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kaffemaskine
{
    public abstract class Machine
    {
        // Protected field representing the on/off status of the machine.
        protected bool isTurnedOn;

        // Constructor for the Machine class.
        public Machine()
        {
            // Initialize the machine as turned off.
            isTurnedOn = false;
        }

        // Virtual method to turn on the machine.
        public virtual string TurnOn()
        {
            // Check if the machine is already turned on.
            if (isTurnedOn)
            {
                return "The coffee machine is already turned on.";
            }

            // Set the machine as turned on.
            isTurnedOn = true;
            return "The coffee machine is turned on.";
        }

        // Virtual method to turn off the machine.
        public virtual string TurnOff()
        {
            // Check if the machine is already turned off.
            if (!isTurnedOn)
            {
                return "The coffee machine is already turned off.";
            }

            // Set the machine as turned off.
            isTurnedOn = false;
            return "The coffee machine is turned off.";
        }
    }
}
