// Program to demonstrate passing array to method 
using System;
class Program
{
    static void Main()
    {
        int[] numbers = { 1, 2, 3, 4, 5 };
        int sum = CalculateSum(numbers);
        Console.WriteLine("The sum of the array elements is: {0}", sum);
    }

    static int CalculateSum(int[] arr)
    {
        int sum = 0;
        foreach (int num in arr)
        {
            sum += num;
        }
        return sum;
    }
}
