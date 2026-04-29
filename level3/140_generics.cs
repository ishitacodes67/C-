// Program to demonstrate generics 
using System;
// Define a generic class that can hold any type of data
class GenericContainer<T>
{
    private T data;

    public void SetData(T value)
    {
        data = value;
    }

    public T GetData()
    {
        return data;
    }
}
class Program
{
    static void Main()
    {
        // Create a generic container for integers
        GenericContainer<int> intContainer = new GenericContainer<int>();
        intContainer.SetData(42);
        Console.WriteLine($"Integer value: {intContainer.GetData()}");

        // Create a generic container for strings
        GenericContainer<string> stringContainer = new GenericContainer<string>();
        stringContainer.SetData("Hello, Generics!");
        Console.WriteLine($"String value: {stringContainer.GetData()}");
    }
}

