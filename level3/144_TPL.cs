// Program to demonstrate Task Parallel Library (TPL)
using System;
using System.Threading.Tasks;
class Program
{
    static void Main()
    {
        // Create and start a task that performs a simple operation
        Task<int> task = Task.Run(() =>
        {
            int sum = 0;
            for (int i = 1; i <= 10; i++)
            {
                sum += i;
            }
            return sum;
        });

        // Wait for the task to complete and get the result
        int result = task.Result;
        Console.WriteLine($"The sum of numbers from 1 to 10 is: {result}");
    }
}
