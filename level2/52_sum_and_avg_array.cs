// Program to find sum and average of array 
using System;
class Program
{
    static void Main()
    {
        int[] arr = new int[5];
        Console.WriteLine("Enter 5 integers:");
        for (int i = 0; i < arr.Length; i++)
        {
            arr[i] = Convert.ToInt32(Console.ReadLine());
        }

        int sum = 0;
        for (int i = 0; i < arr.Length; i++)
        {
            sum += arr[i];
        }

        double average = (double)sum / arr.Length;

        Console.WriteLine("Sum: " + sum);
        Console.WriteLine("Average: " + average);
    }
}
