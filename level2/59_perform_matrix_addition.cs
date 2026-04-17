// Program to perform matrix addition 
using System;
class Program
{
    static void Main()
    {
        int[,] matrixA = new int[2, 2];
        int[,] matrixB = new int[2, 2];
        int[,] resultMatrix = new int[2, 2];

        Console.WriteLine("Enter elements of Matrix A (2x2):");
        for (int i = 0; i < 2; i++)
        {
            for (int j = 0; j < 2; j++)
            {
                matrixA[i, j] = Convert.ToInt32(Console.ReadLine());
            }
        }

        Console.WriteLine("Enter elements of Matrix B (2x2):");
        for (int i = 0; i < 2; i++)
        {
            for (int j = 0; j < 2; j++)
            {
                matrixB[i, j] = Convert.ToInt32(Console.ReadLine());
            }
        }

        // Performing matrix addition
        for (int i = 0; i < 2; i++)
        {
            for (int j = 0; j < 2; j++)
            {
                resultMatrix[i, j] = matrixA[i, j] + matrixB[i, j];
            }
        }

        Console.WriteLine("Result of Matrix A + Matrix B:");
        for (int i = 0; i < 2; i++)
        {
            for (int j = 0; j < 2; j++)
            {
                Console.Write(resultMatrix[i, j] + " ");
            }
            Console.WriteLine();
        }
    }
}