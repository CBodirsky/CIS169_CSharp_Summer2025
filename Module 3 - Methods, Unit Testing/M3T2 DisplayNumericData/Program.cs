/***************************************************************
* Name       : DisplayNumericData
* Author      : Chris Bodirsky
* Created    : 6/6/2025
* Course     : CIS 169 - C#  [30375]
* Version     : 17.8.6
* OS            : Windows 10
* IDE           : Visual Studio 2022
* Copyright   : This is my own original work based on
*               specifications issued by our instructor
* Description : This program [overall description here]
*               Input:  None. Hardcoded variables of full price and discount percent.
*               Output: The calculated discount price in readable formatting.
* Academic Honesty: I attest that this is my original work.
* I have not used unauthorized source code, either modified or
* unmodified. I have not given other fellow student(s) access
* to my program.        
***************************************************************/

namespace DisplayNumericData
{
    internal class Program
    {
        private static decimal NewPrice(decimal price, decimal percentDiscount) 
        {
            //Using decimal because percent, and likely price, will use non-integers and related to currency, which is counted, not measured.
            decimal discountPrice;
            discountPrice = price * percentDiscount;
            return discountPrice;
        }

        private static void DisplayNumericData(decimal discountPrice)
        {
            Console.WriteLine("{0:C}", discountPrice);
        }

        static void Main()
        {
            Console.WriteLine("Hello, World!");
            
            decimal fullPrice = 278.34m;
            decimal discountAmount = .1m;

            DisplayNumericData(NewPrice(fullPrice, discountAmount));

        }
    }
}
