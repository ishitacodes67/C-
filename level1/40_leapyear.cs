// Program to check leap year
using System;

class Program
{
    static void Main()
    {
        Console.Write("Enter a year: ");
        int year = int.Parse(Console.ReadLine());

        if (year % 4 == 0)
        {
            if (year % 100 == 0)
            {
                if (year % 400 == 0)
                {
                    Console.WriteLine("{0} is a leap year.", year);
                }
                else
                {
                    Console.WriteLine("{0} is not a leap year.", year);
                }
            }
            else
            {
                Console.WriteLine("{0} is a leap year.", year);
            }
        }
        else
        {
            Console.WriteLine("{0} is not a leap year.", year);
        }
    }
}