// Program to demonstrate out and ref keywords 
using System;
class Program
{
    static void Main()
    {
        int a = 5;
        int b = 10;
        int sum;
        int product;

        // Using ref keyword
        AddNumbers(ref a, ref b, out sum);
        Console.WriteLine("Sum: {0}", sum);

        // Using out keyword
        MultiplyNumbers(5, 10, out product);
        Console.WriteLine("Product: {0}", product);
    }

    static void AddNumbers(ref int x, ref int y, out int z)
    {
        z = x + y;
    }

    static void MultiplyNumbers(int x, int y, out int z)
    {
        z = x * y;
    }
}
