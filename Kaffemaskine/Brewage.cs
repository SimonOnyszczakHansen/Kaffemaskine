using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kaffemaskine
{
    internal class Brewage
    {
        // A static property representing an empty brewage.
        // It can be accessed through Brewage.ThinAir.
        public static Brewage ThinAir { get { return new Brewage(0, 0, "thin air"); } }

        // Constructor for a brewage object.
        public Brewage(int mlAmount, int ingredientAmount, string name)
        {
            // Set the ml amount of the brewage.
            MlAmount = mlAmount;
            // Calculate the concentration of the brewage based on the ml amount and the ingredient amount.
            Concentration = (mlAmount / 100.0) * ingredientAmount;
            // Set the name of the brewage.
            Name = name;
        }

        // Property to get the ml amount of the brewage.
        public int MlAmount { get; private set; }
        // Property to get the concentration of the brewage.
        public double Concentration { get; private set; }
        // Property to get the name of the brewage.
        public string Name { get; private set; }

        // Method to check if the brewage is an empty brewage.
        public bool CheckIsThinAir()
        {
            // If the name of the brewage is "thin air", it is an empty brewage.
            if (Name == "thin air")
            {
                return true;
            }
            // Otherwise, it is not an empty brewage.
            return false;
        }

        // Override the ToString method to provide a string representation of the brewage object.
        public override string ToString()
        {
            // Return a string with the ml amount, name, and concentration of the brewage.
            return $"Brewage consits of {MlAmount}ml {Name} with a concentration of {Concentration}%";
        }
    }
}
