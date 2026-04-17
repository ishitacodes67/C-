// Program to validate password strength
using System;
using System.Text.RegularExpressions;
class Program
{
    static void Main()
    {
        Console.WriteLine("Enter a password:");
        string password = Console.ReadLine();

        if (IsStrongPassword(password))
        {
            Console.WriteLine("The password is strong.");
        }
        else
        {
            Console.WriteLine("The password is weak. It must be at least 8 characters long and include uppercase letters, lowercase letters, digits, and special characters.");
        }
    }

    static bool IsStrongPassword(string password)
    {
        // Regular expression pattern for validating password strength
        string pattern = @"^(?=.*[a-z])(?=.*[A-Z])(?=.*\d)(?=.*[@$!%*?&])[A-Za-z\d@$!%*?&]{8,}$";
        return Regex.IsMatch(password, pattern);
    }
}