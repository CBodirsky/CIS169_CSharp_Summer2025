/***************************************************************
* Name       : Module 4
* Author      : Chris Bodirsky
* Created    : 06/12/2025
* Course     : CIS 169 - C#  [30375]
* Version     : 17.8.6
* OS            : Windows 10
* IDE           : Visual Studio 2022
* Copyright   : This is my own original work based on
*               specifications issued by our instructor
* Description : This program decides what meal to have on a given day and for lunch or dinner.
*               Input:  What day it is and whether it's for lunch or dinner.
*               Output: What meal is selected. Handles exceptions.
* Academic Honesty: I attest that this is my original work.
* I have not used unauthorized source code, either modified or
* unmodified. I have not given other fellow student(s) access
* to my program.        
***************************************************************/

//Extra credit attempted

namespace Module4
{
    public class Program
    {
        public static string DecideMeal(string dayList, string timeList)
        {
            string mealString;
            //Lunches for all days
            if (timeList == "lunch")
            {
                if (dayList == "Monday")
                {
                    mealString = "VeggieBurger and Fries";
                }
                else if (dayList == "Tuesday")
                {
                    mealString = "Chili and cornbread";
                }
                else if (dayList == "Wednesday")
                {
                    mealString = "Pad Thai";
                }
                else if (dayList == "Thursday")
                {
                    mealString = "Baked Potato";
                }
                else if (dayList == "Friday")
                {
                    mealString = "Hotdog";
                }
                else if (dayList == "Saturday")
                {
                    mealString = "Hamburger";
                }
                else if (dayList == "Sunday")
                {
                    mealString = "Chicken Wings";
                }
                else
                {
                    mealString = "Ice Cream!";
                }

            }
            //Dinners for all days
            else if (timeList == "dinner")
            {
                if (dayList == "Monday")
                {
                    mealString = "Lasagna";
                }
                else if (dayList == "Tuesday")
                {
                    mealString = "Pizza";
                }
                else if (dayList == "Wednesday")
                {
                    mealString = "Soup and Salad";
                }
                else if (dayList == "Thursday")
                {
                    mealString = "Spaghetti";
                }
                else if (dayList == "Friday")
                {
                    mealString = "Steak";
                }
                else if (dayList == "Saturday")
                {
                    mealString = "Burrito";
                }
                else if (dayList == "Sunday")
                {
                    mealString = "Sushi";
                }
                else
                {
                    mealString = "Ice Cream!";
                }

            }
            else
            {
                mealString = "Ice Cream!";
            }
            return mealString;
        }

        static void Main(string[] args)
        {

            Console.WriteLine("What day is it?");
            string? weekDay = Console.ReadLine();
            if (weekDay == null)
            {
                weekDay = "";
            }
            Console.WriteLine("What time meal is it? (lunch/dinner)");
            string? mealTime = Console.ReadLine();
            if (mealTime == null)
            {
                mealTime = "";
            }
            //Format text. Matches expected output as well as variation in DecideMeal function input (Lunch vs lunch).
            weekDay = char.ToUpper(weekDay[0]) + (weekDay.Substring(1).ToLower());
            mealTime = mealTime.ToLower();

            string mealText = DecideMeal(weekDay, mealTime);
            if (mealText == "Ice Cream!")
            {
                Console.WriteLine("You get " + mealText);
            }
            else
            {
                Console.WriteLine(weekDay + " is " + mealText + " for " + mealTime + ".");
            }
        }
    }
}
