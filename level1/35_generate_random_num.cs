/* PROGRAM TO GENERATE RANDOM NUMBERS */
using System;
class Program
{
    static void Main()
    {
        Random random = new Random();
        Console.WriteLine("Enter the number of random numbers to generate:");
        int count = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("Generated random numbers:");
        for (int i = 0; i < count; i++)
        {
            int randomNumber = random.Next(1, 101); // Generates a random number between 1 and 100
            Console.WriteLine(randomNumber);
        }
    }
}