// Console-based Inventory Management System 
using System;   
using System.Collections.Generic;   
class Product
{
    public string Name { get; private set; }
    public int Quantity { get; private set; }

    public Product(string name, int quantity)
    {
        Name = name;
        Quantity = quantity;
    }

    public void DisplayProductInfo()
    {
        Console.WriteLine($"Product Name: {Name}");
        Console.WriteLine($"Quantity: {Quantity}");
    }
}
class Program
{
    static void Main()
    {
        List<Product> products = new List<Product>();
        products.Add(new Product("Laptop", 10));
        products.Add(new Product("Smartphone", 20));

        while (true)
        {
            Console.WriteLine("\nWelcome to the Console-based Inventory Management System");
            Console.WriteLine("1. View Product Information");
            Console.WriteLine("2. Exit");
            Console.Write("Please select an option: ");
            string option = Console.ReadLine();

            switch (option)
            {
                case "1":
                    foreach (var product in products)
                    {
                        product.DisplayProductInfo();
                        Console.WriteLine();
                    }
                    break;
                case "2":
                    return;
                default:    
                    Console.WriteLine("Invalid option.");
                    break;
            }
        }
    }
}
