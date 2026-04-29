// Program to demonstrate multicast delegates 
using System;
// Define a delegate that takes a string and returns void
delegate void MessageHandler(string message);
class Program
{
    static void Main()
    {
        // Create a multicast delegate
        MessageHandler handler = Message1;
        handler += Message2;

        // Invoke the multicast delegate
        handler("Hello, World!");
    }

    static void Message1(string message)
    {
        Console.WriteLine($"Message 1: {message}");
    }

    static void Message2(string message)
    {
        Console.WriteLine($"Message 2: {message}");
    }
}
