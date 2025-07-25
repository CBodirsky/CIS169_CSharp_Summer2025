/***************************************************************
* Name       : Student Structure
* Author      : Chris Bodirsky
* Created    : 06/29/2025
* Course     : CIS 169 - C#  [30375]
* Version     : 17.8.6
* OS            : Windows 10
* IDE           : Visual Studio 2022
* Copyright   : This is my own original work based on
*               specifications issued by our instructor
* Description : This program receives student information and displays
*               that information in a very professional format.
*               Input:  Student information (name, ID, etc)
*               Output: Display student information from structure
* Academic Honesty: I attest that this is my original work.
* I have not used unauthorized source code, either modified or
* unmodified. I have not given other fellow student(s) access
* to my program.        
***************************************************************/

namespace StudentStructure
{
    internal class Program
    {
        public struct Student
        {
            public string FirstName;
            public string LastName;
            public int StudentId;
            public string Major;
            public int YearSchool;
        }
        public static string DisplayStudent(Student student)
        {
            return $@"
+------------------------------------------+
|           Student Information            |
|      Totally Real Elementary School      |
|------------------------------------------+
| Name   : {student.FirstName,-15}{student.LastName,-16} |
| ID     : {student.StudentId,-32}|
| Major  : {student.Major,-32}|
| Year   : {student.YearSchool,-32}|
+------------------------------------------+
| Notes: Plays well with others.           |
| Handles structures well.                 |
| ASCII art could use some work.           |
+------------------------------------------+
";
        }

        public static string StringValidation(string prompt)
        {
            while (true)
            {
                Console.Write(prompt);
                string input = Console.ReadLine();

                if (!string.IsNullOrWhiteSpace(input))
                    return input.Trim();

                Console.WriteLine("Input cannot be blank. Please try again.");
            }
        }

        public static int IntValidation(string prompt, int min = int.MinValue, int max = int.MaxValue)
        {
            while (true)
            {
                Console.Write(prompt);
                string input = Console.ReadLine();
                if (int.TryParse(input, out int value) && value >= min && value <= max)
                    return value;

                Console.WriteLine($"Please enter a valid number between {min} and {max}.");
            }
        }
        public static Student CreateStudent(string firstName, string lastName, int studentId, string major, int year)
        {
            Student student;
            student.FirstName = firstName;
            student.LastName = lastName;
            student.StudentId = studentId;
            student.Major = major;
            student.YearSchool = year;
            return student;
        }
        static void Main(string[] args)
        {
            try
            {
                string firstName = StringValidation("Enter first name: ");
                string lastName = StringValidation("Enter last name: ");
                int studentId = IntValidation("Enter student ID: ", 1, 999999);
                string major = StringValidation("Enter student major: ");
                int yearSchool = IntValidation("Enter year in school (1-6): ", 1, 6);
                Student student = CreateStudent(firstName, lastName, studentId, major, yearSchool);

                Console.WriteLine(DisplayStudent(student));
            }

            catch (Exception ex)
            {
                Console.WriteLine($"Unexpected error: {ex.Message}");
            }

            

            
        }
    }
}
