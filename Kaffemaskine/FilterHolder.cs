using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kaffemaskine
{
    internal class FilterHolder
    {
        public Filter Filter { get; set; } = null;

        public string InsertFilter(Filter filter)
        {
            if(Filter != null)
            {
                return "Der er allerede et filter i holderen";
            }
            else
            {
                Filter = filter;
                return "Filteret er blevet placeret i holderen";
            }
        }
    }
}
