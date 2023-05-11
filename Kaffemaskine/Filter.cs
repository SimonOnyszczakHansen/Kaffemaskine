using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kaffemaskine
{
    internal class Filter
    {
        // Public fields representing the ingredient name, ingredient amount, and soaked status of the filter.
        public string ingredient;
        public int ingredientAmount;
        public bool isSoaked = false;

        // Constructor for the Filter class.
        public Filter(string ingredient, int ingredientAmount)
        {
            // Set the ingredient name.
            this.ingredient = ingredient;
            // Set the ingredient amount (not used in the current implementation).
            this.ingredientAmount = ingredientAmount;
        }

        // Method to pour water through the filter and create a brewage.
        public Brewage PourWater(int mlAmount)
        {
            // Mark the filter as soaked.
            isSoaked = true;
            // Create and return a new brewage with the specified ml amount, ingredient amount, and ingredient name.
            return new Brewage(mlAmount, ingredientAmount, ingredient);
        }

        // Override the ToString method to provide a string representation of the filter object.
        public override string ToString()
        {
            // Return a string indicating that the specified ingredient has been added to the filter.
            return $"You have added {ingredient} to the filter.";
        }
    }
}
