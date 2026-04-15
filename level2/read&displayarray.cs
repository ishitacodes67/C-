// Program to read and display array elements
using System;
class AndUpAndU
{
    static void Main()
    {
        int[] arr = new int[5];
        Console.WriteLine("Enter 5 integers:");
        for (int i = 0; i < arr.Length; i++)
        {
            arr[i] = int.Parse(Console.ReadLine());
        }

        Console.WriteLine("You entered:");
        for (int i = 0; i < arr.Length; i++)
        {
            Console.Write(arr[i] + " ");
        }
    }
}
