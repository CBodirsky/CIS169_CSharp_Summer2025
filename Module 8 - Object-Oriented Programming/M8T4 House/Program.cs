/***************************************************************
* Name       : House
* Author      : Chris Bodirsky
* Created    : 07/05/2025
* Course     : CIS 169 - C#  [30375]
* Version     : 17.8.6
* OS            : Windows 10
* IDE           : Visual Studio 2022
* Copyright   : This is my own original work based on
*               specifications issued by our instructor
* Description : This program creates and prints out a 
*               list of houses.
*               Input:  None.
*               Output: List of houses and their bed/bath count.
* Academic Honesty: I attest that this is my original work.
* I have not used unauthorized source code, either modified or
* unmodified. I have not given other fellow student(s) access
* to my program.        
***************************************************************/

using HouseClass;

//Array for the houses
House[] houseList =
{
    new House("456 Oak", 1,2),
    new House("25 Maple", 1, 3),
    new House("1414 14th", 3, 5),
    new House("823 Dog", 1, 1),
    new House("120 Easy", 2, 3)
};
//House.cs handles processing these values


//loop for printing the houses
foreach (House house in houseList)
{
    Console.WriteLine(house.ToString());
}