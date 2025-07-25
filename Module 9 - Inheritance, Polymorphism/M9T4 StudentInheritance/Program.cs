/***************************************************************
* Name       : StudentWorker
* Author      : Chris Bodirsky
* Created    : 07/22/2025
* Course     : CIS 169 - C#  [30375]
* Version     : 17.8.6
* OS            : Windows 10
* IDE           : Visual Studio 2022
* Copyright   : This is my own original work based on
*               specifications issued by our instructor
* Description : This program demonstrates inheritance and 
*               polymorphism.
*               Input:  Information about student workers
*               Output: General entered info with validation check
* Academic Honesty: I attest that this is my original work.
* I have not used unauthorized source code, either modified or
* unmodified. I have not given other fellow student(s) access
* to my program.        
***************************************************************/

using System;

namespace StudentEntry
{
    public class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Enter first name: ");
            string firstName = Console.ReadLine();

            Console.WriteLine("Enter last name: ");
            string lastName = Console.ReadLine();

            DateTime dob;
            Console.WriteLine("Enter date of birth (yyyy-mm--dd: ");
            while (!DateTime.TryParse(Console.ReadLine(), out dob))
            {
                Console.WriteLine("Invalid date. Please try again (yyyy-mm-dd: ");
            }

            int id;
            Console.Write("Enter student ID: ");
            while (!int.TryParse(Console.ReadLine(), out id))
            {
                Console.WriteLine("ID must be a number. Please try again: ");
            }

            decimal hourlyRate;
            Console.WriteLine("Enter hourly rate: ");
            while (!decimal.TryParse(Console.ReadLine(), out hourlyRate))
            {
                Console.WriteLine("Must be a numberic value. Please try again: ");
            }

            double hoursWorked;
            Console.Write("Enter hours worked: ");
            while (!double.TryParse(Console.ReadLine(), out hoursWorked))
            {
                Console.WriteLine("Must be a numeric value. Please try again: ");
            }

            StudentWorker worker = new StudentWorker(hourlyRate, hoursWorked, firstName, lastName, dob, id);

            Console.WriteLine("\n Payroll Summary: ");
            Console.WriteLine(worker.ToString());

            if (worker.CalculatePay() == 0)
            {
                Console.WriteLine("\nAdmin: Entry flagged. Please confirm pay rate and hours.");
            }
        }
    }
}