// Program to demonstrate readonly vs const
using System;
class Program
{
    // Readonly field
    public readonly int ReadOnlyValue;

    // Const field
    public const int ConstValue = 10;

    public Program(int value)
    {
        ReadOnlyValue = value; // Can be assigned in constructor
    }

    static void Main()
    {
        Program program = new Program(5);
        Console.WriteLine($"Readonly Value: {program.ReadOnlyValue}");
        Console.WriteLine($"Const Value: {ConstValue}");

        // Uncommenting the following lines will cause compilation errors
        // program.ReadOnlyValue = 20; // Error: Cannot assign to 'ReadOnlyValue' because it is read-only
        // ConstValue = 20; // Error: The left-hand side of an assignment must be a variable, property or indexer
    }
}