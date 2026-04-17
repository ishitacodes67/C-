// Program to find missing number in array 
using System;
class Program
{
    static void Main()
    {
        int[] array = { 1, 2, 4, 5, 6 };
        int n = array.Length + 1; // Total numbers should be n

        int sumOfArray = 0;
        for (int i = 0; i < array.Length; i++)
        {
            sumOfArray += array[i];
        }

        int expectedSum = n * (n + 1) / 2; // Sum of first n natural numbers
        int missingNumber = expectedSum - sumOfArray;

        Console.WriteLine("The missing number is: " + missingNumber);
    }
}