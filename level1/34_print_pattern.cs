/* PROGRAM TO PRINT PATTERN(* ) */ 
using System;
class Program
{
    static void Main()
    {
        Console.WriteLine("Enter the number of rows:");
        int rows = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("Pattern output:");
        for (int i = 1; i <= rows; i++)
        {
            for (int j = 1; j <= i; j++)
            {
                Console.Write("* ");
            }
            Console.WriteLine();
        }
    }
}

