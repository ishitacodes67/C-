// Program to find largest and smallest element in array
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

        int largest = arr[0];
        int smallest = arr[0];

        for (int i = 1; i < arr.Length; i++)
        {
            if (arr[i] > largest)
            {
                largest = arr[i];
            }
            if (arr[i] < smallest)
            {
                smallest = arr[i];
            }
        }

        Console.WriteLine("Largest element: " + largest);
        Console.WriteLine("Smallest element: " + smallest);
    }
}