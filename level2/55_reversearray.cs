// Program to reverse an array 
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

        // Reversing the array
        for (int i = 0; i < arr.Length / 2; i++)
        {
            int temp = arr[i];
            arr[i] = arr[arr.Length - 1 - i];
            arr[arr.Length - 1 - i] = temp;
        }

        Console.WriteLine("Reversed array elements:");
        for (int i = 0; i < arr.Length; i++)
        {
            Console.Write(arr[i] + " ");
        }
    }
}