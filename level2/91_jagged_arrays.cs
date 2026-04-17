// Program to demonstrate jagged arrays 
using System;
class Program
{
    static void Main()
    {
        // Declare a jagged array with 3 rows
        int[][] jaggedArray = new int[3][];

        // Initialize each row with different lengths
        jaggedArray[0] = new int[] { 1, 2, 3 };
        jaggedArray[1] = new int[] { 4, 5 };
        jaggedArray[2] = new int[] { 6, 7, 8, 9 };

        // Display the elements of the jagged array
        for (int i = 0; i < jaggedArray.Length; i++)
        {
            Console.WriteLine($"Row {i}:");
            for (int j = 0; j < jaggedArray[i].Length; j++)
            {
                Console.Write(jaggedArray[i][j] + " ");
            }
            Console.WriteLine();
        }
    }
}
