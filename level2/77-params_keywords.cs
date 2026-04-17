// Program to demonstrate params keyword 
using System;
class Program
{
    static void Main()
    {
        Console.WriteLine("Enter numbers to calculate their sum (separated by space):");
        string input = Console.ReadLine();
        string[] numbers = input.Split(' ');
        int[] intNumbers = Array.ConvertAll(numbers, int.Parse);
        int sum = CalculateSum(intNumbers);
        Console.WriteLine("The sum of the entered numbers is: {0}", sum);
    }

    static int CalculateSum(params int[] numbers)
    {
        int sum = 0;
        foreach (int number in numbers)
        {
            sum += number;
        }
        return sum;
    }
}