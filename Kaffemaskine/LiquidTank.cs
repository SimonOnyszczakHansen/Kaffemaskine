using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kaffemaskine
{
    internal class LiquidTank
    {
        string liquid;
        int amount;
        private bool isFull;

        public LiquidTank(string liquid, int amount)
        {
            isFull = false;
            this.liquid = liquid;
            this.amount = amount;
        }
        public virtual string AddLiquidToTank()
        {
            return $"{amount}ml {liquid} has been added to the tank";
        }
        public virtual string CheckIfFull()
        {
            if (amount > 500)
            {
                isFull=true;
                return "Der kan max være 500ml i tanken";
            }
            else
            {
                return $"Der er plads til mere {liquid} i beholderen";
            }
        }
    }
}
