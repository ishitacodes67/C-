// Program to convert days into years, months, days 
using System;
class Program
{
    static void Main()
    {
        Console.WriteLine("Enter the number of days:");
        int totalDays = int.Parse(Console.ReadLine());

        int years = totalDays / 365;
        int remainingDaysAfterYears = totalDays % 365;

        int months = remainingDaysAfterYears / 30;
        int remainingDaysAfterMonths = remainingDaysAfterYears % 30;

        Console.WriteLine($"{totalDays} days is approximately {years} years, {months} months, and {remainingDaysAfterMonths} days.");
    }
}
