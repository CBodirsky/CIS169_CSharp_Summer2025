/***************************************************************
* Name       : MethodsBodirsky
* Author      : Chris Bodirsky
* Created    : 06/19/2025
* Course     : CIS 169 - C#  [30375]
* Version     : 17.8.6
* OS            : Windows 10
* IDE           : Visual Studio 2022
* Copyright   : This is my own original work based on
*               specifications issued by our instructor
* Description : This program [overall description here]
*               Input:  Integers for score tracking.
*               Output: The running total score.
* Academic Honesty: I attest that this is my original work.
* I have not used unauthorized source code, either modified or
* unmodified. I have not given other fellow student(s) access
* to my program.        
***************************************************************/

namespace Methods
{
    public class Program
    {
        static string GetUserInput()
        {
            Console.WriteLine("What is your score?");
            return Console.ReadLine();
        }

        public static int ConvertToInt(string testString)
        {

            if (Int32.TryParse(testString, out int userNumber))
            {
                if (userNumber >= 0)
                {
                    return userNumber;
                }
                else
                {
                    return -1;
                }
            }
            else
            {
                return -1;
            }
        }

        public static bool ValidateInput(int userNum)
        {
            if (userNum >= 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public static void Main(string[] args)
        {
            int numSum = 0;
            int numCount = 0;
            int numAve;
            do
            {
                //int numSum = 0;
                string userEntry = GetUserInput();
                int userNum = ConvertToInt(userEntry);
                if (ValidateInput(userNum))
                {
                    numSum = numSum + userNum;
                    numCount++;
                    Console.WriteLine("Current total is {0} from {1} entries.", numSum, numCount);
                }
                else
                    break;


            } while (true);
            if (numCount > 0)
            {
                numAve = numSum / numCount;
                Console.WriteLine("Your average score is {0} which is a total of {1} from {2} entries", numAve, numSum, numCount);
            }
            else
            {
                Console.WriteLine("You don't have any score entered.");
            }

        }
    }
}
