using System;
using System.Net.Http.Headers;

public class Program
{
    public static void AccountDetails(Account account)
    {
        Console.WriteLine($"Account Number: {account.AccountNumber}");
        Console.WriteLine($"Balance: {account.Balance}\n");
        
        
          
    }

    public static void Main()
    {
        Account acc1 = new Account(123456);
        SavingsAccount acc2 = new SavingsAccount(909090, 0.8);
        CheckingAccount acc3 = new CheckingAccount(696969, 100);

        // Deposit some money into each account
        acc1.Deposit(1000);
        acc2.Deposit(1500);
        acc3.Deposit(500);

        // Display initial account details
        Console.WriteLine("Initial Account Details:");
        AccountDetails(acc1);
        AccountDetails(acc2);
        AccountDetails(acc3);

        // Withd from CheckingAccount exceeding overdraft limit
        Console.WriteLine("Trying Deposit from Account :");
        acc1.Deposit(1000); // This should exceed the overdraft limit
        AccountDetails(acc1);

        // Withdraw from Account beyond Withdraw Limit
        Console.WriteLine("Trying to Withdraw from Account beyond Withdraw Limit:");
        acc1.Withdraw(2001); // This should exceed the overdraft limit
        AccountDetails(acc1);

        // Calculate interest for the SavingsAccount
        Console.WriteLine("Calculating Interest for SavingsAccount:");
        double interest = acc2.CalculateInterest();
        Console.WriteLine($"Interest Earned: {interest}");
        AccountDetails(acc2);

        // Withdraw from CheckingAccount within overdraft limit
        Console.WriteLine("Withdrawing from CheckingAccount within Overdraft Limit:");
        // This should work within the overdraft limit
        acc3.Withdraw(550);
        Console.WriteLine($"Withdraw amount ");
        AccountDetails(acc3);
    }
}
