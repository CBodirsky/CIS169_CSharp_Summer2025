/***************************************************************
* Name       : Jagged Arrays
* Author      : Chris Bodirsky
* Created    : 06/29/2025
* Course     : CIS 169 - C#  [30375]
* Version     : 17.8.6
* OS            : Windows 10
* IDE           : Visual Studio 2022
* Copyright   : This is my own original work based on
*               specifications issued by our instructor
* Description : This program [overall description here]
*               Input:  None
*               Output: Distances table between cities, the closest and
*               furthest cities with city names (extra credit).
* Academic Honesty: I attest that this is my original work.
* I have not used unauthorized source code, either modified or
* unmodified. I have not given other fellow student(s) access
* to my program.        
***************************************************************/

namespace JaggedArrays
{
    internal class Program
    {
        static int Min(int[] distancesArray)
        {
            int minimum = distancesArray[0];
            for (int i = 1; i < distancesArray.Length; i++)
            {
                if (distancesArray[i] < minimum)
                    minimum = distancesArray[i];
            }
            return minimum;
        }

        static int Max(int[] distancesArray)
        {
            int maximum = distancesArray[0];
            for (int i = 1; i < distancesArray.Length; ++i)
            {
                if (distancesArray[i] > maximum)
                {
                    maximum = distancesArray[i];
                }
            }
            return maximum;
        }
        static void Main(string[] args)
        {
            string[] cityList = { "Edinburgh", "Birmingham", "Cardiff",
            "Dover", "Leeds", "Liverpool", "London", "Manchester",
            "NewCastle", "York" };

            int[][] milesTable = new int[10][];
            milesTable[0] = new int[] { 0 };
            milesTable[1] = new int[] { 290, 0 };
            milesTable[2] = new int[] { 373, 102, 0 };
            milesTable[3] = new int[] { 496, 185, 228, 0 };
            milesTable[4] = new int[] { 193, 110, 208, 257, 0 };
            milesTable[5] = new int[] { 214, 90, 165, 270, 73, 0 };
            milesTable[6] = new int[] { 412, 118, 150, 81, 191, 198, 0 };
            milesTable[7] = new int[] { 222, 86, 173, 285, 41, 34, 201, 0 };
            milesTable[8] = new int[] { 112, 207, 301, 360, 94, 155, 288, 141, 0 };
            milesTable[9] = new int[] { 186, 129, 231, 264, 25, 97, 194, 66, 82, 0 };

            Console.WriteLine("\nMileage Table:\n");
            for (int i = 0; i < milesTable.Length; i++)
            {
                //Print the Edinburgh zero, but not the rest
                if (i == 0)
                {
                    Console.WriteLine(milesTable[0][0]);
                    continue;
                }

                for (int j = 0; j < milesTable[i].Length - 1; j++)
                {
                    Console.Write(milesTable[i][j] + "\t");
                }
                Console.WriteLine();
            }

            int[] manchesterDistance = new int[7];
            //Closest to Manchester is Manchester at 0 miles! Easy!
            Array.Copy(milesTable[7], manchesterDistance, 7);
            int closest = Min(manchesterDistance);
            int farthest = Max(manchesterDistance);
            int minIndex = -1;
            int maxIndex = -1;

            //City names before Manchester in rows
            for (int i = 0; i < 7; i++)
            {
                if (manchesterDistance[i] == closest) minIndex = i;
                if (manchesterDistance[i] == farthest) maxIndex = i;
            }

            //City names after Manchester in columns
            for (int i = 8; i < milesTable.Length; i++)
            {
                if (milesTable[i][7] == closest) minIndex = i;
                if (milesTable[i][7] == farthest) maxIndex = i;
            }

            Console.WriteLine($"\nThe closest is {closest} miles to {cityList[minIndex]}");
            Console.WriteLine($"The farthest is {farthest} miles to {cityList[maxIndex]}");
        }


    }
}
