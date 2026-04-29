// Program to demonstrate multithreading 
using System;
using System.Threading;
class Program
{
    static void Main()
    {
        // Create a new thread that runs the PrintNumbers method
        Thread thread = new Thread(PrintNumbers);
        thread.Start();

        // Main thread continues to run concurrently
        for (int i = 0; i < 5; i++)
        {
            Console.WriteLine($"Main Thread: {i}");
            Thread.Sleep(500); // Sleep for 500 milliseconds
        }

        // Wait for the other thread to finish
        thread.Join();
        Console.WriteLine("Main Thread Completed.");
    }

    static void PrintNumbers()
    {
        for (int i = 0; i < 5; i++)
        {
            Console.WriteLine($"Worker Thread: {i}");
            Thread.Sleep(700); // Sleep for 700 milliseconds
        }
        Console.WriteLine("Worker Thread Completed.");
    }
}

