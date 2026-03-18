/* CALCULATE SALARY WITH ALLOWANCE
 * 
 * Write a program that calculates the salary of an employee based on their basic salary and allowance. The program should take the basic salary and allowance as input from the user and then calculate and display the total salary.
 * 
 * Sample Input:
 * Basic Salary: 5000
 * Allowance: 1000
 * 
 * Sample Output:
 * Total Salary: 6000
 */
using System;
class Program
{
    static void Main()
    {
        Console.WriteLine("Enter the basic salary:");
        double basicSalary = Convert.ToDouble(Console.ReadLine());

        Console.WriteLine("Enter the allowance:");
        double allowance = Convert.ToDouble(Console.ReadLine());

        double totalSalary = basicSalary + allowance;

        Console.WriteLine("Total Salary: " + totalSalary);
    }
}