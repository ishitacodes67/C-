// Program to find common elements in two arrays
using System;
class Program
{
    static void Main()
    {
        int[] array1 = { 1, 2, 3, 4, 5 };
        int[] array2 = { 4, 5, 6, 7, 8 };

        Console.WriteLine("Common elements in the two arrays:");
        foreach (int element in array1)
        {
            if (Array.Exists(array2, e => e == element))
            {
                Console.Write(element + " ");
            }
        }
    }
}   