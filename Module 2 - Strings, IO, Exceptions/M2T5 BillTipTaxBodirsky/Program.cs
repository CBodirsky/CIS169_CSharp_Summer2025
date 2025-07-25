/***************************************************************
* Name       : BillTipTaxBodirsky
* Author      : Chris Bodirsky
* Created    : 
* Course     : CIS 169 - C#  [30375]
* Version     : 17.8.6
* OS            : Windows 10
* IDE           : Visual Studio 2022
* Copyright   : This is my own original work based on
*               specifications issued by our instructor
* Description : This program totals the bill for a meal and calculates splitting the bill between the customers.
*               Input:  None (inputs hardcoded)
*               Output: Itemized list of the total
* Academic Honesty: I attest that this is my original work.
* I have not used unauthorized source code, either modified or
* unmodified. I have not given other fellow student(s) access
* to my program.        
***************************************************************/

const decimal TAXRATE = 0.07M;
const decimal TIPRATE = 0.2M;

decimal meal1 = 0;
decimal meal2 = 0;
decimal dessert1 = 0;
decimal dessert2 = 0;
int numPersons = 2;

decimal subtotal;
decimal totalTax;
decimal totalTip;
decimal netTotal;
decimal totalPerPerson;

Console.WriteLine("Please enter the cost of Meal 1: ");
try
{
    meal1 = Convert.ToDecimal(Console.ReadLine());
}
catch (FormatException e1)
{
    Console.WriteLine("Error in meal one price");
    Console.WriteLine("Input string was not in a correct format.");
}
Console.WriteLine("Please enter the cost of Meal 2: ");
try
{
    meal2 = Convert.ToDecimal(Console.ReadLine());
}
catch (FormatException e2)
{
    Console.WriteLine("Error in meal two price");
    Console.WriteLine("Input string was not in a correct format.");
}
Console.Write("Please enter the cost of Dessert 1: ");
try
{
    dessert1 = Convert.ToDecimal(Console.ReadLine());
}
catch (FormatException e3)
{
    Console.WriteLine("Error in dessert one price");
    Console.WriteLine("Input string was not in a correct format.");
}
Console.Write("Please enter the cost of Dessert 2: ");
try
{
    dessert2 = Convert.ToDecimal(Console.ReadLine());
}
catch (FormatException e4)
{
    Console.WriteLine("Error in dessert two price");
    Console.WriteLine("Input string was not in a correct format.");
}


subtotal = meal1 + meal2 + dessert1 + dessert2;
totalTax = subtotal * TAXRATE;
totalTip = subtotal * TIPRATE;
netTotal = subtotal + totalTax + totalTip;
totalPerPerson = netTotal / numPersons;
Console.WriteLine($"Subtotal: {subtotal:C}");
Console.WriteLine($"Tax: {totalTax:C}");
Console.WriteLine($"Tip: {totalTip:C}");
Console.WriteLine($"Total: {netTotal:C}");
Console.WriteLine($"Per person: {totalPerPerson:C} \n");