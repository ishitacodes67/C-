// Program to find second largest element in array 
using System;
class Program
{
    static void Main()
    {
        int[] numbers = { 1, 2, 3, 4, 5 };
        int secondLargest = FindSecondLargest(numbers);
        Console.WriteLine("The second largest element is: {0}", secondLargest);
    }

    static int FindSecondLargest(int[] arr)
    {
        int largest = int.MinValue;
        int secondLargest = int.MinValue;

        foreach (int num in arr)
        {
            if (num > largest)
            {
                secondLargest = largest;
                largest = num;
            }
            else if (num > secondLargest && num != largest)
            {
                secondLargest = num;
            }
        }

        return secondLargest;
    }
}
