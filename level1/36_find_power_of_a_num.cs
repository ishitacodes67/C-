/* PROGRAM TO FIND THE POWER OF A NUMBER */
using System;
class Program
{
    static void Main()
    {
        Console.WriteLine("Enter the base number:");
        int baseNumber = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("Enter the exponent:");
        int exponent = Convert.ToInt32(Console.ReadLine());

        long result = 1;
        for (int i = 0; i < exponent; i++)
        {
            result *= baseNumber;
        }

        Console.WriteLine("Result: " + result);
    }
}
