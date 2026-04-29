// Console-based Banking System
using System;
using System.Collections.Generic;
class BankAccount
{
    public string AccountNumber { get; private set; }
    public string AccountHolder { get; private set; }
    public decimal Balance { get; private set; }

    public BankAccount(string accountNumber, string accountHolder, decimal initialBalance)
    {
        AccountNumber = accountNumber;
        AccountHolder = accountHolder;
        Balance = initialBalance;
    }

    public void Deposit(decimal amount)
    {
        if (amount > 0)
        {
            Balance += amount;
            Console.WriteLine($"Deposited {amount:C} to account {AccountNumber}. New balance: {Balance:C}");
        }
        else
        {
            Console.WriteLine("Deposit amount must be positive.");
        }
    }

    public void Withdraw(decimal amount)
    {
        if (amount > 0 && amount <= Balance)
        {
            Balance -= amount;
            Console.WriteLine($"Withdrew {amount:C} from account {AccountNumber}. New balance: {Balance:C}");
        }
        else
        {
            Console.WriteLine("Invalid withdrawal amount.");
        }
    }

    public void DisplayAccountInfo()
    {
        Console.WriteLine($"Account Number: {AccountNumber}");
        Console.WriteLine($"Account Holder: {AccountHolder}");
        Console.WriteLine($"Balance: {Balance:C}");
    }
}
class Program
{
    static void Main()
    {
        List<BankAccount> accounts = new List<BankAccount>();
        accounts.Add(new BankAccount("123456", "Alice Smith", 1000m));
        accounts.Add(new BankAccount("654321", "Bob Johnson", 500m));       
        while (true)
        {
            Console.WriteLine("\nWelcome to the Console-based Banking System");
            Console.WriteLine("1. View Account Information");
            Console.WriteLine("2. Deposit");
            Console.WriteLine("3. Withdraw");
            Console.WriteLine("4. Exit");
            Console.Write("Please select an option: ");
            string choice = Console.ReadLine();

            if (choice == "4")
                break;

            Console.Write("Enter account number: ");
            string accountNumber = Console.ReadLine();
            BankAccount account = accounts.Find(a => a.AccountNumber == accountNumber);

            if (account == null)
            {
                Console.WriteLine("Account not found.");
                continue;
            }

            switch (choice)
            {
                case "1":
                    account.DisplayAccountInfo();
                    break;
                case "2":
                    Console.Write("Enter deposit amount: ");
                    if (decimal.TryParse(Console.ReadLine(), out decimal depositAmount))
                    {
                        account.Deposit(depositAmount);
                    }
                    else
                    {
                        Console.WriteLine("Invalid amount.");
                    }
                    break;
                case "3":
                    Console.Write("Enter withdrawal amount: ");
                    if (decimal.TryParse(Console.ReadLine(), out decimal withdrawalAmount))
                    {
                        account.Withdraw(withdrawalAmount);
                    }
                    else
                    {
                        Console.WriteLine("Invalid amount.");
                    }
                    break;
                default:
                    Console.WriteLine("Invalid option.");
                    break;
            }
        }
        Console.WriteLine("Thank you for using the Console-based Banking System. Goodbye!");
    }
}

