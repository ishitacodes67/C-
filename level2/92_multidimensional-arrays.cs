// Program to demonstrate multidimensional arrays
using System;
class Program
{
    static void Main()
    {
        // Declare a 3x3 multidimensional array
        int[,] multiArray = new int[3, 3];

        // Initialize the array
        for (int i = 0; i < 3; i++)
        {
            for (int j = 0; j < 3; j++)
            {
                multiArray[i, j] = i * 3 + j + 1;
            }
        }

        // Display the elements of the multidimensional array
        for (int i = 0; i < 3; i++)
        {
            for (int j = 0; j < 3; j++)
            {
                Console.Write(multiArray[i, j] + " ");
            }
            Console.WriteLine();
        }
    }
}
