using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Methods2022
{
    public static class Helpers
    {
        public static decimal CalculateTax(decimal price,  decimal taxRate) 
        {
            decimal tax;
            tax = price * taxRate;
            return tax;
        }
        public static void DisplayCurrency(decimal value)
        {
            Console.Write("{0:C}", value);
        }

    }
}
