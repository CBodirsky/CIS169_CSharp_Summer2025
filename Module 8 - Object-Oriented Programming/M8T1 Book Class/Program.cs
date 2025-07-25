/***************************************************************
* Name       : Book Class
* Author      : Chris Bodirsky
* Created    : 07/02/2025
* Course     : CIS 169 - C#  [30375]
* Version     : 17.8.6
* OS            : Windows 10
* IDE           : Visual Studio 2022
* Copyright   : This is my own original work based on
*               specifications issued by our instructor
* Description : This program lists information about books from a class
*               and constructor setup.
*               Input:  None
*               Output: Information about two books, from two different
*               constructor setups.
* Academic Honesty: I attest that this is my original work.
* I have not used unauthorized source code, either modified or
* unmodified. I have not given other fellow student(s) access
* to my program.        
***************************************************************/

using System;
using BookLookup;

class Program
{
    static void Main()
    {
        //author, title, keywords, publication date, ISBN
        List<string> duneKeywords = new List<string> { "science fiction", "fantasy", "philosophical" };
        Book dune = new Book("Frank Herbert", "Dune", duneKeywords, "1965", "9780801950773");
        Book childrenOfDune = new Book();

        childrenOfDune.Author = "Frank Herbert";
        childrenOfDune.Title = "Children Of Dune";
        childrenOfDune.Keywords = new List<string> { "science fiction", "fantasy" };
        childrenOfDune.PublicationDate = "1977";
        childrenOfDune.Isbn = "9780425033104";

        Console.WriteLine(dune.ToString());
        Console.WriteLine(childrenOfDune.ToString());
    }
}