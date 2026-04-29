// Program to demonstrate locking and synchronization 
using System;
class Program
{
    private static readonly object lockObject = new object();
    private static int counter = 0;

    static void Main()
    {
        // Create multiple threads to increment the counter
        for (int i = 0; i < 5; i++)
        {
            new System.Threading.Thread(IncrementCounter).Start();
        }
    }

    static void IncrementCounter()
    {
        for (int i = 0; i < 1000; i++)
        {
            // Lock the critical section to ensure thread safety
            lock (lockObject)
            {
                counter++;
            }
        }
        Console.WriteLine($"Counter: {counter}");
    }
}

