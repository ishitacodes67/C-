// Program to demonstrate Stack and Queue 
using System;
using System.Collections.Generic; // Importing the Collections.Generic namespace for Stack and Queue
class Program   
{
    static void Main()
    {
        // Demonstrating Stack
        Stack<string> myStack = new Stack<string>();
        myStack.Push("First");
        myStack.Push("Second");
        myStack.Push("Third");
        
        Console.WriteLine("Contents of the Stack:");
        foreach (var item in myStack)
        {
            Console.WriteLine(item);
        }
        
        Console.WriteLine($"\nPopped from Stack: {myStack.Pop()}");
        
        // Demonstrating Queue
        Queue<string> myQueue = new Queue<string>();
        myQueue.Enqueue("First");
        myQueue.Enqueue("Second");
        myQueue.Enqueue("Third");
        
        Console.WriteLine("\nContents of the Queue:");
        foreach (var item in myQueue)
        {
            Console.WriteLine(item);
        }
        
        Console.WriteLine($"\nDequeued from Queue: {myQueue.Dequeue()}");
    }
}

