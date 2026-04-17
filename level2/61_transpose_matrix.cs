// Program to find transpose of matrix 
using System;
class Program
{
    static void Main()
    {
        int[,] matrix = new int[2, 2];
        int[,] transposeMatrix = new int[2, 2];

        Console.WriteLine("Enter elements of Matrix (2x2):");
        for (int i = 0; i < 2; i++)
        {
            for (int j = 0; j < 2; j++)
            {
                matrix[i, j] = Convert.ToInt32(Console.ReadLine());
            }
        }

        // Finding transpose of the matrix
        for (int i = 0; i < 2; i++)
        {
            for (int j = 0; j < 2; j++)
            {
                transposeMatrix[j, i] = matrix[i, j];
            }
        }

        Console.WriteLine("Transpose of the Matrix:");
        for (int i = 0; i < 2; i++)
        {
            for (int j = 0; j < 2; j++)
            {
                Console.Write(transposeMatrix[i, j] + " ");
            }
            Console.WriteLine();
        }
    }
}


