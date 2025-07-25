/***************************************************************
* Name       : ReadWriteFile
* Author      : Chris Bodirsky
* Created    : 06/28/2025
* Course     : CIS 169 - C#  [30375]
* Version     : 17.8.6
* OS            : Windows 10
* IDE           : Visual Studio 2022
* Copyright   : This is my own original work based on
*               specifications issued by our instructor
* Description : This program [overall description here]
*               Input:  cities.txt file
*               Output: citynames.txt file with formatted text and additional city
* Academic Honesty: I attest that this is my original work.
* I have not used unauthorized source code, either modified or
* unmodified. I have not given other fellow student(s) access
* to my program.        
***************************************************************/

using System.Runtime.InteropServices;
/*Note after the fact: Yeah, I don't know what's up with this. I did not add InteropServices.
I don't know what it does and don't want to look it up. I think this came up because I started
this in a browser IDE or another IDE or something, but I distinctly remember copying this code 
over from somewhere near the end of it and this apparently got dropped in somehow.
It works, doesn't even use InteropServices (at least it runs fine without it). But I'm just
going to leave this here because that's what I submitted and got docked for it!
*/

namespace ReadWriteFile
{
    internal class Program
    {

        static string FormatName(string city)
        {
            string str = city;
            if (str.Contains(" "))
            {
                string[] words = str.Split(' ');
                for (int i = 0; i < words.Length; i++)
                {
                    if (words[i].Length > 0)
                    {
                        words[i] = char.ToUpper(words[i][0]) + words[i].Substring(1).ToLower();
                    }
                }
                return string.Join(" ", words);
            }
            else
            {
                return char.ToUpper(str[0]) + str.Substring(1).ToLower();
            }
        }
        static void Main(string[] args)
        {
            {
                try
                {
                    //Enable the line below to clear the file before adding the city list!
                    //The appending repeated names can be a pain after all.
                    //File.WriteAllText("citynames.txt", string.Empty);

                    using (StreamReader sr = new StreamReader("cities.txt"))
                    {
                        while (sr.Peek() >= 0)
                        {
                            String line = sr.ReadLine();
                            
                            Console.WriteLine(FormatName(line));
                            File.AppendAllText(Path.Combine("citynames.txt"), FormatName(line) + Environment.NewLine);
                        }
                    }
                }
                catch (IOException e)
                {
                    Console.WriteLine("The file could not be read: ");
                    Console.WriteLine(e.Message);
                }
                File.AppendAllText(Path.Combine("citynames.txt"), "Bakersfield" + Environment.NewLine);

            }


        }

    }
}
