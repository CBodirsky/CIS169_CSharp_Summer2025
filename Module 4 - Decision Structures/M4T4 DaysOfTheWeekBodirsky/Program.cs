/***************************************************************
* Name       : DaysOfTheWeek
* Author      : Chris Bodirsky
* Created    : 06/11/2025
* Course     : CIS 169 - C#  [30375]
* Version     : 17.8.6
* OS            : Windows 10
* IDE           : Visual Studio 2022
* Copyright   : This is my own original work based on
*               specifications issued by our instructor
* Description : This program [overall description here]
*               Input:  A value of 1 through 7. Handles other values.
*               Output: Day of the week relating to the number input. Handles invalid inputs.
* Academic Honesty: I attest that this is my original work.
* I have not used unauthorized source code, either modified or
* unmodified. I have not given other fellow student(s) access
* to my program.        
***************************************************************/

namespace DaysOfTheWeekBodirsky
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string dayNumber;
            int numberOfDay;
            string dayOfWeek = "";
            Console.WriteLine("Enter the number of a day of the week (1-7):");
            dayNumber = Console.ReadLine();

            if (int.TryParse(dayNumber, out numberOfDay))
            {
                if (numberOfDay >= 1 && numberOfDay <= 100)
                {



                    switch (dayNumber)
                    {
                        case "1":
                            dayOfWeek = "Monday";
                            break;
                        case "2":
                            dayOfWeek = "Tuesday";
                            break;
                        case "3":
                            dayOfWeek = "Wednesday";
                            break;
                        case "4":
                            dayOfWeek = "Thursday";
                            break;
                        case "5":
                            dayOfWeek = "Friday";
                            break;
                        case "6":
                            dayOfWeek = "Saturday";
                            break;
                        case "7":
                            dayOfWeek = "Sunday";
                            break;
                        default:
                            Console.WriteLine("I can't count that high!");
                            break;
                    }
                    Console.WriteLine(dayOfWeek);
                }

            }
            else
            {
                Console.WriteLine("Please enter a valid number (1-7).");
            }
        }
    }
}
