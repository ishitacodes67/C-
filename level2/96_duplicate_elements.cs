// Program to find duplicate elements in array
using System;
class Program
{
    static void Main()
    {
        int[] array = { 1, 2, 3, 4, 2, 5, 1 };
        Console.WriteLine("Duplicate elements in the array:");
        for (int i = 0; i < array.Length; i++)
        {
            for (int j = i + 1; j < array.Length; j++)
            {
                if (array[i] == array[j])
                {
                    Console.Write(array[i] + " ");
                    break; // To avoid printing the same duplicate multiple times
                }
            }
        }
    }
}