/***************************************************************
* Name       : DoWhileBodirsky
* Author      : Chris Bodirsky
* Created    : 06/17/2025
* Course     : CIS 169 - C#  [30375]
* Version     : 17.8.6
* OS            : Windows 10
* IDE           : Visual Studio 2022
* Copyright   : This is my own original work based on
*               specifications issued by our instructor
* Description : This program [overall description here]
*               Input:  Receive numbers. End when receiving a non-number input
*               Output: Sum of the numbers submitted.
* Academic Honesty: I attest that this is my original work.
* I have not used unauthorized source code, either modified or
* unmodified. I have not given other fellow student(s) access
* to my program.        
***************************************************************/

namespace DoWhileBodirsky
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int enteredNumber = 0;
            int newNumber;
            string valueEntered;
            do
            {
                Console.WriteLine("Please provide a whole number to add: ");
                valueEntered = Console.ReadLine();
                if (int.TryParse(valueEntered, out newNumber))
                {
                    enteredNumber = enteredNumber + newNumber;
                }
                else
                {
                    Console.WriteLine("That input is not valid.");
                }
                
            }
            while (enteredNumber == 0);
            Console.WriteLine("{0} is a valid number!", newNumber);
        }
        
    }
}
