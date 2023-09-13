


public class Account
{
    public Account(int accountNumber)
    {
        AccountNumber = accountNumber;

    }

    public int AccountNumber { get; set; }
    public double Balance { get; set; }

    public double Deposit(double amount)
    {
        Balance += amount;
        return Balance;
    }
    public virtual double Withdraw(double amount)
    {
        
        if (Balance >= amount)
        {
            Balance -= amount;
            
        }
        else
        {
            Console.WriteLine("Insufficient Balance.");
            
        }
        return Balance;
    }
}