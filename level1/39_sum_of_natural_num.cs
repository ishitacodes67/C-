/* PROGRAM TO FIND SUM OF NATURAL NUMBERS */
using System;
class Program
{
    static void Main()
    {
        Console.WriteLine("Enter a positive integer:");
        int n = Convert.ToInt32(Console.ReadLine());

        int sum = 0;
        for (int i = 1; i <= n; i++)
        {
            sum += i;
        }

        Console.WriteLine("Sum of the first " + n + " natural numbers is: " + sum);
    }
}