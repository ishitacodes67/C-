// Program to demonstrate performance optimization basics 
using System;
using System.Diagnostics;
class Performance
{
    static void Main(string[] args)
    {
        // Measure the time taken to execute a simple loop
        Stopwatch stopwatch = new Stopwatch();
        stopwatch.Start();

        long sum = 0;
        for (int i = 0; i < 100000000; i++)
        {
            sum += i;
        }

        stopwatch.Stop();
        Console.WriteLine("Sum: " + sum);
        Console.WriteLine("Time taken: " + stopwatch.ElapsedMilliseconds + " ms");
    }
}

