// Program to demonstrate Func, Action, Predicate 
using System;
class Program
{
    static void Main()
    {
        // Func example: A function that takes two integers and returns their sum
        Func<int, int, int> add = (a, b) => a + b;
        int result = add(5, 3);
        Console.WriteLine($"Func Result (Sum): {result}");

        // Action example: A function that takes a string and prints it
        Action<string> printMessage = message => Console.WriteLine($"Action Message: {message}");
        printMessage("Hello, World!");

        // Predicate example: A function that checks if a number is even
        Predicate<int> isEven = number => number % 2 == 0;
        int numberToCheck = 4;
        bool isNumberEven = isEven(numberToCheck);
        Console.WriteLine($"Predicate Result (Is {numberToCheck} even?): {isNumberEven}");
    }
}
