 // Program to find sum and average of array
using System;
class Program
{
    static void Main()
    {
        int[] numbers = { 10, 20, 30, 40, 50 };
        int sum = 0;
        double average;

        // Calculate the sum of the array
        foreach (int number in numbers)
        {
            sum += number;
        }

        // Calculate the average
        average = (double)sum / numbers.Length;

        // Output the results
        Console.WriteLine("Sum: " + sum);
        Console.WriteLine("Average: " + average);
    }
}
