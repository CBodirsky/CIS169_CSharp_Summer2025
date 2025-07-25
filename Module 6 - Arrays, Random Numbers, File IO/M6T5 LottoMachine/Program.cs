/***************************************************************
* Name       : LottoMachine
* Author      : Chris Bodirsky
* Created    : 06/28/2025
* Course     : CIS 169 - C#  [30375]
* Version     : 17.8.6
* OS            : Windows 10
* IDE           : Visual Studio 2022
* Copyright   : This is my own original work based on
*               specifications issued by our instructor
* Description : This program [overall description here]
*               Input:  None
*               Output: A powerball number independent of 5 other lottery numbers with duplicate check
* Academic Honesty: I attest that this is my original work.
* I have not used unauthorized source code, either modified or
* unmodified. I have not given other fellow student(s) access
* to my program.        
***************************************************************/

namespace LottoMachine
{
    internal class Program
    {
        static int[] PowerBall()
        {
            HashSet<int> usedNum = new HashSet<int>();

            int[] lotNums = new int[6];
            Random rand = new Random();
            //Unique Powerball
            lotNums[0] = rand.Next(5, 65);

            for (int i = 1; i < 6; i++)
            {
                //This process checks for duplicates, using HashSet
                int checkNum;
                do
                {
                    checkNum = rand.Next(1, 65);
                }
                while (usedNum.Contains(checkNum));
                //No duplicate? Drop that number in the array!
                lotNums[i] = checkNum;
                usedNum.Add(checkNum);
            }
            return lotNums;
        }
        static void Main(string[] args)
        {
            int[] returnedNums = PowerBall();
            Console.Write("Your Lottery numbers are: ");
                for (int i = 1; i < returnedNums.Length; i++)
            {
                Console.Write(returnedNums[i] + " ");
            }
            Console.WriteLine();
            Console.WriteLine("PowerBall Number: " + returnedNums[0]);
        }
    }
}
