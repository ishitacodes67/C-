/* LARGEST IN ARRAY */ 
using System;
class Program
{
    static void Main()
    {
        int[] numbers = { 5, 3, 8, 1, 4 };
        int largest = numbers[0];

        for (int i = 1; i < numbers.Length; i++)
        {
            if (numbers[i] > largest)
            {
                largest = numbers[i];
            }
        }

        Console.WriteLine("The largest number in the array is: " + largest);
    }
}