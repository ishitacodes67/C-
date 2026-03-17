/* EVEN OR ODD */
using System;
class Program
{
    static void Main()
    {
        Console.WriteLine("Enter a number:");
        int num = Convert.ToInt32(Console.ReadLine());

        if (num % 2 == 0)
        {
            Console.WriteLine(num + " is an even number.");
        }
        else
        {
            Console.WriteLine(num + " is an odd number.");
        }
    }
}