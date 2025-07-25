/***************************************************************
* Name       : NumberAverages
* Author      : Chris Bodirsky
* Created    : 6/8/2025
* Course     : CIS 169 - C#  [30375]
* Version     : 17.8.6
* OS            : Windows 10
* IDE           : Visual Studio 2022
* Copyright   : This is my own original work based on
*               specifications issued by our instructor
* Description : This program [overall description here]
*               Input:  None. Values hardcoded.
*               Output: Average of different values for different datat types.
* Academic Honesty: I attest that this is my original work.
* I have not used unauthorized source code, either modified or
* unmodified. I have not given other fellow student(s) access
* to my program.        
***************************************************************/


namespace NumberAverages
{
    internal class Program
    {
        public static float Average(float fNum1, float fNum2, float fNum3)
        {
            float average = (fNum1 + fNum2 + fNum3) / 3;
            return average;
            //float for float values
        }
        public static decimal Average(decimal decNum1, decimal decNum2, decimal decNum3)
        {
            decimal average = (decNum1 + decNum2 + decNum3) / 3;
            return average;
            //decimal for decimal values
        }
        public static int Average(int iNum1, int iNum2, int iNum3)
        {
            int average = (iNum1 + iNum2 + iNum3) / 3;
            return average;
            //integer for integer values
        }
        public static double Average(double douNum1, double douNum2, double douNum3)
        {
            double average = (douNum1 + douNum2 + douNum3) / 3;
            return average;
            //double for double values
        }


        static void Main(string[] args)
        {
            float floatNum1 = 2.2f;
            float floatNum2 = 3.2f;
            float floatNum3 = 15.75f;
            decimal decimalNum1 = 1.25m;
            decimal decimalNum2 = 8.42m;
            decimal decimalNum3 = 2.00m;
            int intNum1 = 7;
            int intNum2 = 3;
            int intNum3 = 11;
            double doubleNum1 = 47.25;
            double doubleNum2 = 3.2;
            double doubleNum3 = 14.44;
            float firstAverage;
            decimal secondAverage;
            int thirdAverage;
            double fourthAverage;

            firstAverage = Average(floatNum1, floatNum2, floatNum3);
            secondAverage = Average(decimalNum1, decimalNum2, decimalNum3);
            thirdAverage = Average(intNum1, intNum2, intNum3);
            fourthAverage = Average(doubleNum1, doubleNum2, doubleNum3);

            Console.WriteLine("Float average of {0}, {1}, and {2} equals {3}.", floatNum1, floatNum2, floatNum3, firstAverage);
            Console.WriteLine("Decimal average of {0}, {1}, and {2} equals {3}.", decimalNum1, decimalNum2, decimalNum3, secondAverage);
            Console.WriteLine("Int average of {0}, {1}, and {2} equals {3}.", intNum1, intNum2, intNum3, thirdAverage);
            Console.WriteLine("Double average of {0}, {1}, and {2} equals {3}.", doubleNum1, doubleNum2, doubleNum3, fourthAverage);
        }
    }
}
