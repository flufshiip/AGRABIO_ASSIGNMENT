public class CheckingAccount : Account
{
    public double OverdraftLimit { get; private set; }

    public CheckingAccount(int accountNumber, double overdraftLimit) : base(accountNumber)
    {
        OverdraftLimit = overdraftLimit;
    }

    public override double Withdraw(double amount)
    {
        if (amount <= 0)
        {
            Console.WriteLine("Invalid withdrawal amount.");
            return Balance;
        }

        if (Balance >= amount || (Balance - amount) >= -OverdraftLimit)
        {
            Balance -= amount;
        }
        else
        {
            Console.WriteLine("Exceeds overdraft limit.");
        }

        return Balance;
    }
}
