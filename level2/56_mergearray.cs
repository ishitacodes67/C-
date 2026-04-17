// Program to merge two arrays 
using System;
class Program
{
    static void Main()
    {
        int[] arr1 = new int[5];
        int[] arr2 = new int[5];
        Console.WriteLine("Enter 5 integers for the first array:");
        for (int i = 0; i < arr1.Length; i++)
        {
            arr1[i] = Convert.ToInt32(Console.ReadLine());
        }

        Console.WriteLine("Enter 5 integers for the second array:");
        for (int i = 0; i < arr2.Length; i++)
        {
            arr2[i] = Convert.ToInt32(Console.ReadLine());
        }

        int[] mergedArray = new int[arr1.Length + arr2.Length];
        for (int i = 0; i < arr1.Length; i++)
        {
            mergedArray[i] = arr1[i];
        }
        for (int i = 0; i < arr2.Length; i++)
        {
            mergedArray[arr1.Length + i] = arr2[i];
        }

        Console.WriteLine("Merged array elements:");
        for (int i = 0; i < mergedArray.Length; i++)
        {
            Console.Write(mergedArray[i] + " ");
        }
    }
}