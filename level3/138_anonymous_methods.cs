// Program to demonstrate anonymous methods 
using System;
class Program
{
    static void Main()
    {
        // Anonymous method example: A function that takes an integer and returns its square
        Func<int, int> square = delegate (int x)
        {
            return x * x;
        };

        int result = square(5);
        Console.WriteLine($"Anonymous Method Result (Square): {result}");
    }
}

