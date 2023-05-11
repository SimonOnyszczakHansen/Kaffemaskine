using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kaffemaskine
{
    internal class Filter
    {
        private string ingredient;

        public Filter(string ingredient)
        {
            this.ingredient = ingredient;
        }
        
        public virtual string AddIngredient()
        {
            return $"Du har tilføjet {ingredient} til filteret";
        }
    }
}
