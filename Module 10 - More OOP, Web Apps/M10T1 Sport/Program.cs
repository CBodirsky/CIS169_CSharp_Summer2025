/***************************************************************
* Name       : Sports
* Author      : Chris Bodirsky
* Created    : 07/20/2025
* Course     : CIS 169 - C#  [30375]
* Version     : 17.8.6
* OS            : Windows 10
* IDE           : Visual Studio 2022
* Copyright   : This is my own original work based on
*               specifications issued by our instructor
* Description : This program uses an abstract class
*               and calls upon separate classes.
*               Input:  None
*               Output: Information from two different classes.
* Academic Honesty: I attest that this is my original work.
* I have not used unauthorized source code, either modified or
* unmodified. I have not given other fellow student(s) access
* to my program.        
* Extra Credit: Yes, Sport can be the data type for Rugby. 
*               Rugby inherits from Sport, so using Sport as the reference
*               works for Rugby.
***************************************************************/

namespace Sports
{
    class Program
    {
        public static void Main(string[] args)
        {
            Rugby rugby = new Rugby("Falcons", "Field, Goals, and Rugby Ball", 12);
            Sport shotput = new ShotPut("Eagles", "Track Field and Shotput", 3);

            Console.WriteLine(rugby.ToString());
            Console.WriteLine(shotput.ToString());

            Console.WriteLine(rugby.Play());
            Console.WriteLine($"Team Size: {rugby.FormTeam()}");

            Console.WriteLine(shotput.Play());
        }
    }
}
