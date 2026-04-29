// Console-based Employee Payroll System
using System;
using System.Collections.Generic;
class Employee
{
    public string Name { get; private set; }
    public decimal Salary { get; private set; }

    public Employee(string name, decimal salary)
    {
        Name = name;
        Salary = salary;
    }

    public void DisplayEmployeeInfo()
    {
        Console.WriteLine($"Employee Name: {Name}");
        Console.WriteLine($"Salary: {Salary:C}");
    }
}
class Program
{
    static void Main()
    {
        List<Employee> employees = new List<Employee>();
        employees.Add(new Employee("Alice Smith", 50000m));
        employees.Add(new Employee("Bob Johnson", 60000m));

        while (true)
        {
            Console.WriteLine("\nWelcome to the Console-based Employee Payroll System");
            Console.WriteLine("1. View Employee Information");
            Console.WriteLine("2. Exit");
            Console.Write("Please select an option: ");
            string option = Console.ReadLine();

            switch (option)
            {
                case "1":
                    foreach (var employee in employees)
                    {
                        employee.DisplayEmployeeInfo();
                        Console.WriteLine();
                    }
                    break;
                case "2":
                    return;
                default:    
                    Console.WriteLine("Invalid option.");
            }
        }
    }
}
