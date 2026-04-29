// Console-based Mini ERP System
using System;
using System.Collections.Generic;
class Program
{
    static void Main(string[] args)
    {
        MiniERPSystem erpSystem = new MiniERPSystem();
        erpSystem.Run();
    }
}
public class MiniERPSystem
{
    private List<string> products = new List<string>();
    private List<string> customers = new List<string>();

    public void Run()
    {
        while (true)
        {
            Console.WriteLine("Mini ERP System");
            Console.WriteLine("1. Add Product");
            Console.WriteLine("2. Add Customer");
            Console.WriteLine("3. View Products");
            Console.WriteLine("4. View Customers");
            Console.WriteLine("5. Exit");
            Console.Write("Select an option: ");
            string option = Console.ReadLine();

            switch (option)
            {
                case "1":
                    AddProduct();
                    break;
                case "2":
                    AddCustomer();
                    break;
                case "3":
                    ViewProducts();
                    break;
                case "4":
                    ViewCustomers();
                    break;
                case "5":
                    return;
                default:
                    Console.WriteLine("Invalid option. Please try again.");
                    break;
            }
        }
    }

    private void AddProduct()
    {
        Console.Write("Enter product name: ");
        string productName = Console.ReadLine();
        products.Add(productName);
        Console.WriteLine("Product added successfully.");
    }

    private void AddCustomer()
    {
        Console.Write("Enter customer name: ");
        string customerName = Console.ReadLine();
        customers.Add(customerName);
        Console.WriteLine("Customer added successfully.");
    }

    private void ViewProducts()
    {
        Console.WriteLine("Products:");
        foreach (var product in products)
        {
            Console.WriteLine("- " + product);
        }
    }

    private void ViewCustomers()
    {
        Console.WriteLine("Customers:");
        foreach (var customer in customers)
        {
            Console.WriteLine("- " + customer);
        }
    }
}
