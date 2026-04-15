// Program to demonstrate enum
using System;
namespace EnumExample
{
    // Define an enum for days of the week
    enum DaysOfWeek
    {
        Sunday,
        Monday,
        Tuesday,
        Wednesday,
        Thursday,
        Friday,
        Saturday
    }

    class Program
    {
        static void Main(string[] args)
        {
            // Create a variable of type DaysOfWeek and assign a value
            DaysOfWeek today = DaysOfWeek.Wednesday;

            // Display the value of the enum variable
            Console.WriteLine("Today is: " + today);

            // Convert the enum to its underlying integer value
            int dayValue = (int)today;
            Console.WriteLine("The integer value of " + today + " is: " + dayValue);

            // Convert an integer back to an enum value
            DaysOfWeek dayFromValue = (DaysOfWeek)3;
            Console.WriteLine("The day corresponding to integer 3 is: " + dayFromValue);
        }
    }
}