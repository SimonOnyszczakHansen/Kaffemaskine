using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kaffemaskine
{
    internal class FilterHolder
    {
        // Public field representing the filter in the filter holder.
        public Filter Filter = null;

        // Method to insert a filter into the filter holder.
        public string InsertFilter(Filter filter)
        {
            // Check if there is already a filter in the holder.
            if (Filter != null)
            {
                return "There is already a filter in the holder.";
            }
            else
            {
                // Set the filter in the holder to the specified filter.
                Filter = filter;
                return "The filter has been placed in the holder.";
            }
        }

        // Method to remove the filter from the filter holder.
        public string RemoveFilter()
        {
            // Set the filter in the holder to null.
            Filter = null;
            return "The filter was removed.";
        }

        // Method to check if there is a clean filter with ingredient in the filter holder.
        public bool HasCleanFilterWithIngredient()
        {
            // Check if there is a filter in the holder, it is not soaked, and it has a positive ingredient amount.
            return (Filter != null) && (!Filter.isSoaked) && (Filter.ingredientAmount > 0);
        }

        // Override the ToString method to provide a string representation of the filter holder object.
        public override string ToString()
        {
            if (Filter == null)
            {
                return "No filter in the holder.";
            }
            return "Filter in the holder.";
        }
    }
}
