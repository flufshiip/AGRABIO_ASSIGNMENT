public class SavingsAccount : Account
{
    private double interestRate; // Private backing field for the interest rate

    protected double InterestRate
    {
        get { return interestRate; }
        private set
        {
            if (value < 0)
            {
                throw new ArgumentException("Interest rate must be non-negative.");
            }
            interestRate = value; // Set the backing field
        }
    }

    public SavingsAccount(int accountNumber, double interest) : base(accountNumber)
    {
        InterestRate = interest;
    }

    public double CalculateInterest()
    {
        double annualInterest = Balance * (InterestRate / 100);
        double monthlyInterest = annualInterest / 12;
        Balance += monthlyInterest;
        return monthlyInterest;
    }
}
