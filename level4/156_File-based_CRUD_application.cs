// File-based CRUD application
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
class Program
{
    static string filePath = "data.txt";

    static void Main(string[] args)
    {
        while (true)
        {
            Console.WriteLine("1. Create");
            Console.WriteLine("2. Read");
            Console.WriteLine("3. Update");
            Console.WriteLine("4. Delete");
            Console.WriteLine("5. Exit");
            Console.Write("Choose an option: ");
            string choice = Console.ReadLine();

            switch (choice)
            {
                case "1":
                    Create();
                    break;
                case "2":
                    Read();
                    break;
                case "3":
                    Update();
                    break;
                case "4":
                    Delete();
                    break;
                case "5":
                    return;
                default:
                    Console.WriteLine("Invalid option. Try again.");
                    break;
            }
        }
    }

    static void Create()
    {
        Console.Write("Enter data to create: ");
        string data = Console.ReadLine();
        File.AppendAllText(filePath, data + Environment.NewLine);
        Console.WriteLine("Data created successfully.");
    }

    static void Read()
    {
        if (File.Exists(filePath))
        {
            string[] lines = File.ReadAllLines(filePath);
            Console.WriteLine("Data:");
            foreach (string line in lines)
            {
                Console.WriteLine(line);
            }
        }
        else
        {
            Console.WriteLine("No data found.");
        }
    }

    static void Update()
    {
        if (File.Exists(filePath))
        {
            string[] lines = File.ReadAllLines(filePath);
            Console.WriteLine("Current Data:");
            for (int i = 0; i < lines.Length; i++)
            {
                Console.WriteLine($"{i + 1}. {lines[i]}");
            }

            Console.Write("Enter the number of the data to update: ");
            int index = int.Parse(Console.ReadLine()) - 1;

            if (index >= 0 && index < lines.Length)
            {
                Console.Write("Enter new data: ");
                string newData = Console.ReadLine();
                lines[index] = newData;
                File.WriteAllLines(filePath, lines);
                Console.WriteLine("Data updated successfully.");
            }
            else
            {
                Console.WriteLine("Invalid index.");
            }
        }
        else
        {
            Console.WriteLine("No data found.");
        }
    }

    static void Delete()
    {
        if (File.Exists(filePath))
        {
            string[] lines = File.ReadAllLines(filePath);
            Console.WriteLine("Current Data:");
            for (int i = 0; i < lines.Length; i++)
            {
                Console.WriteLine($"{i + 1}. {lines[i]}");
            }

            Console.Write("Enter the number of the data to delete: ");
            int index = int.Parse(Console.ReadLine()) - 1;

            if (index >= 0 && index < lines.Length)
            {
                List<string> updatedLines = lines.ToList();
                updatedLines.RemoveAt(index);
                File.WriteAllLines(filePath, updatedLines);
                Console.WriteLine("Data deleted successfully.");
            }
            else
            {
                Console.WriteLine("Invalid index.");
            }
        }
        else
        {
            Console.WriteLine("No data found.");
        }
    }
}
