/***************************************************************
* Name       : Birthday Party
* Author     : Chris Bodirsky
* Created    : 6/1/2025
* Course     : CIS 169 - C#  [30375]
* Version    : 17.8.6
* OS         : Windows 10
* IDE        : Visual Studio 2022
* Copyright  : This is my own original work based on
*               specifications issued by our instructor
* Description: This program Calculates the number of cupcakes for each person at a party.
*               Input:  Number of cupcakes and people.
*               Output: Cupcakes for each person and exception handling.
* Academic Honesty: I attest that this is my original work.
* I have not used unauthorized source code, either modified or
* unmodified. I have not given other fellow student(s) access
* to my program.        
***************************************************************/

//variables
int numPeople = 0;
int numCupcakes = 0;
int cupcakesPerPerson = 0;
int cupcakesForMe = 0;

//input prompts
Console.WriteLine("How many people will be at the party: ");
    try
{
    numPeople = Convert.ToInt32(Console.ReadLine());
}
catch (FormatException peopleFormat)
{
    Console.WriteLine("Error reading number of people.");
    Console.WriteLine(peopleFormat.Message);
}
if (numPeople == 0)
{
    Console.WriteLine("No one is coming? :(");
}
Console.WriteLine("How many cupcakes will be at the party: ");
try
{
    numCupcakes = Convert.ToInt32(Console.ReadLine());
}
catch (FormatException cupcakeFormat)
{
    Console.WriteLine("Error reading number of cupcakes.");
    Console.WriteLine(cupcakeFormat.Message);
}
if (numCupcakes == 0)
{
    Console.WriteLine("There aren't any cupcakes? :(");
}

//Calculations
if (numCupcakes > 0 & numPeople > 0)
{
    cupcakesPerPerson = numCupcakes / numPeople;
    cupcakesForMe = numCupcakes % numPeople;

    //Outputs
    Console.WriteLine("Happy (UN)Birthday to me!");
    Console.WriteLine("You may have up to {0} cupcakes:)", cupcakesPerPerson);
    if (cupcakesForMe > 0)
    {
        Console.WriteLine("There will be {0} extra for me!", cupcakesForMe);
    }
    else
    {
        Console.WriteLine("No extras for me...");
    }
}
else
{
    Console.WriteLine("There's no party without people and cupcakes!");
}