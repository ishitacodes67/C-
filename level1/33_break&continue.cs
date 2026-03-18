/* PROGRAM TO DEMONSTRATE BREAK AND CONTINUE STATEMENTS */
using System;
class Program
{
    static void Main()
    {
        Console.WriteLine("Enter the number of iterations:");
        int iterations = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("Using break statement:");
        for (int i = 1; i <= iterations; i++)
        {
            if (i == 5)
            {
                Console.WriteLine("Breaking the loop at iteration: " + i);
                break; // Exit the loop when i is 5
            }
            Console.WriteLine("Iteration: " + i);
        }

        Console.WriteLine("\nUsing continue statement:");
        for (int i = 1; i <= iterations; i++)
        {
            if (i == 5)
            {
                Console.WriteLine("Skipping iteration: " + i);
                continue; // Skip the rest of the loop body when i is 5
            }
            Console.WriteLine("Iteration: " + i);
        }
    }
}