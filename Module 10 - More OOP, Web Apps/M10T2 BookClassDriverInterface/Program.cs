/***************************************************************
* Name       : Book Class Driver Interface
* Author      : Chris Bodirsky
* Created    : 07/19/2025
* Course     : CIS 169 - C#  [30375]
* Version     : 17.8.6
* OS            : Windows 10
* IDE           : Visual Studio 2022
* Copyright   : This is my own original work based on
*               specifications issued by our instructor
* Description : This program lists information about books from a class
*               and constructor setup. A line updates author data. Demonstrating
*               using ICloneable.
*               Input:  None
*               Output: Information about two books, from two different
*               constructor setups. And a third, cloned.
* Academic Honesty: I attest that this is my original work.
* I have not used unauthorized source code, either modified or
* unmodified. I have not given other fellow student(s) access
* to my program.        
***************************************************************/

using System;
using BookClassDriverInterface;

class Program
{
    static void Main()
    {
        //author, title, keywords, publication date, ISBN
        
        List<string> murachsKeywords = new List<string> { "C#", "ASP.NET", "MVC" };
        Book murachsAsp = new Book("Mary Delamater and Joel Murac", "Murach's ASP.NET Core MVC", murachsKeywords, "January 2020", "978-1-943872-49-7");

        murachsAsp.Author = "Mary Delamater and Joel Murach";

        Book inDepth = new Book();

        inDepth.Author = "Jon Skeet";
        inDepth.Title = "C# in Depth";
        inDepth.Keywords = new List<string> { "C#", "Programming" };
        inDepth.PublicationDate = "Mar 23, 2019";
        inDepth.Isbn = "9781617294532";

        
        Console.WriteLine(murachsAsp.ToString());
        Console.WriteLine(inDepth.ToString());

        Book clonedBook = (Book)murachsAsp.Clone();
        Console.WriteLine("Cloned Book:");
        Console.WriteLine(clonedBook.ToString());
    }
}