// Program to search an element in array 
using System;
class Program
{
    static void Main()
    {
        int[] arr = new int[5];
        Console.WriteLine("Enter 5 integers:");
        for (int i = 0; i < arr.Length; i++)
        {
            arr[i] = Convert.ToInt32(Console.ReadLine());
        }

        Console.Write("Enter the element to search: ");
        int searchElement = Convert.ToInt32(Console.ReadLine());

        bool isFound = false;
        for (int i = 0; i < arr.Length; i++)
        {
            if (arr[i] == searchElement)
            {
                isFound = true;
                Console.WriteLine("Element found at index {0}", i);
                break;
            }
        }

        if (!isFound)
        {
            Console.WriteLine("Element not found in the array.");
        }
    }
}   