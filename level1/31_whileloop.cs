/* PROGRAM TO DEMONSTRATE WHILE LOOP */ 
using System;
class Program
{
    static void Main()
    {
        Console.WriteLine("Enter the number of iterations:");
        int iterations = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("While loop output:");
        int i = 1;
        while (i <= iterations)
        {
            Console.WriteLine("Iteration: " + i);
            i++;
        }
    }
}