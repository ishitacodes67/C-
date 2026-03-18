/* PROGRAM TO DEMONSTRATE FOR LOOP */
using System;
class Program
{
    static void Main()
    {
        Console.WriteLine("Enter the number of iterations:");
        int iterations = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("For loop output:");
        for (int i = 1; i <= iterations; i++)
        {
            Console.WriteLine("Iteration: " + i);
        }
    }
}