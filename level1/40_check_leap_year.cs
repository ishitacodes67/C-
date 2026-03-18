/* PROGRAM TO CHECK IF A YEAR IS A LEAP YEAR */
using System;
class Program
{
    static void Main()
    {
        Console.WriteLine("Enter a year:");
        int year = Convert.ToInt32(Console.ReadLine());

        bool isLeapYear = (year % 4 == 0 && year % 100 != 0) || (year % 400 == 0);

        if (isLeapYear)
        {
            Console.WriteLine(year + " is a leap year.");
        }
        else
        {
            Console.WriteLine(year + " is not a leap year.");
        }
    }
}