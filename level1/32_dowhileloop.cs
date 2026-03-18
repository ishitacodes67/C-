/* DEMONSTRATE DO-WHILE LOOP */ 
using System;
class Program
{
    static void Main()
    {
        Console.WriteLine("Enter the number of iterations:");
        int iterations = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("Do-While loop output:");
        int i = 1;
        do
        {
            Console.WriteLine("Iteration: " + i);
            i++;
        } while (i <= iterations);
    }
}