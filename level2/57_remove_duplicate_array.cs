// Program to remove duplicate elements from array 
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

        int[] temp = new int[arr.Length];
        int j = 0;

        for (int i = 0; i < arr.Length; i++)
        {
            bool isDuplicate = false;
            for (int k = 0; k < j; k++)
            {
                if (arr[i] == temp[k])
                {
                    isDuplicate = true;
                    break;
                }
            }
            if (!isDuplicate)
            {
                temp[j++] = arr[i];
            }
        }

        Console.WriteLine("Array elements after removing duplicates:");
        for (int i = 0; i < j; i++)
        {
            Console.Write(temp[i] + " ");
        }
    }
}