using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kaffemaskine
{
    internal class Can
    {
        // Default constructor for the Can class.
        public Can()
        {
            // Initialize the can as empty.
            Empty();
        }

        // Constructor for the Can class that takes a brewage as an argument.
        public Can(Brewage brewage)
        {
            // Set the brewage of the can.
            Brewage = brewage;
        }

        // Property to get the brewage contained in the can.
        public Brewage Brewage { get; private set; }

        // Method to fill the can with a brewage.
        public void FillWithBrewage(Brewage brewage)
        {
            // Set the brewage of the can.
            Brewage = brewage;
        }

        // Method to empty the can.
        public string Empty()
        {
            // Set the brewage of the can to an empty brewage.
            Brewage = Brewage.ThinAir;
            // Return a string indicating that the can has been emptied.
            return "Can was emptied out";
        }
    }
}
