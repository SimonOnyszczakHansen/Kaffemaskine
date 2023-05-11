using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kaffemaskine
{
    internal class CoffeeMachine : Machine
    {
        // Public property representing the filter holder in the coffee machine.
        public FilterHolder FilterHolder { get; private set; } = new FilterHolder();

        // Public property representing the amount of water in milliliters (ml) in the coffee machine.
        public int WaterMlAmount { get; private set; } = 0;

        // Method to insert a filter into the filter holder of the coffee machine.
        public string InsertFilter(Filter filter) => FilterHolder.InsertFilter(filter);

        // Method to remove the filter from the filter holder of the coffee machine.
        public string RemoveFilter() => FilterHolder.RemoveFilter();

        // Method to fill the coffee machine with a specified amount of water.
        public string FillWithWater(int mlAmount)
        {
            // Increase the amount of water in the coffee machine.
            WaterMlAmount += mlAmount;
            // Return a string indicating the amount of water added to the machine.
            return $"{mlAmount}ml of water was added to the machine";
        }

        // Method to brew coffee into a can.
        public string Brew(ref Can can)
        {
            // Check if there is a clean filter with ingredient in the filter holder and if there is enough water.
            if ((!FilterHolder.HasCleanFilterWithIngredient()) || (WaterMlAmount <= 0))
            {
                // Unable to brew if the conditions are not met.
                return "Couldn't brew!";
            }
            else
            {
                // Pour water through the filter and obtain the resulting brewage.
                Brewage brewage = FilterHolder.Filter.PourWater(WaterMlAmount);
                // Fill the can with the brewed brewage.
                can.FillWithBrewage(brewage);

                // Reset the water amount in the coffee machine.
                WaterMlAmount = 0;

                // Return a string indicating the successful brewing of the ingredient into the can.
                return $"{FilterHolder.Filter.ingredient} was brewed into the can.";
            }
        }
    }
}
