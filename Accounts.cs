using System;

namespace OnlineBank
{
public abstract class Accounts
{

    public int AccountNumber { get; private set; }

    public string AccountType => $"{this.GetType().Name} Account";

    public abstract decimal Overdraft { get; protected set; }

    public decimal Opening { get; protected set; }
    public decimal Deposits { get; protected set; }
    public decimal Withdrawals { get; protected set; }
    public decimal Interest { get; protected set; }
    public decimal Fees { get; protected set; }

    public decimal InterestRate { get; protected set; } = 4m;

 
    public decimal Balance => this.Opening + this.Deposits - this.Withdrawals + this.Interest - this.Fees;

    private static Random _random = new Random();
    public static int GenerateAccountNumber() => _random.Next(100000000, 1000000000);

    public (decimal Withdrawn, decimal Fee) Withdraw(decimal amount)
    {
        if (amount <= 0m)
        {
            throw new System.InvalidOperationException("Withdrawal amount must be positive");
        }
        decimal fee = 0;
        if (amount > this.Overdraft)
        {
            amount = 0m;
            fee = 10m;
        }
        else if (this.Balance < amount)
        {
            amount = this.Balance;
        }
        this.Withdrawals += amount;
        this.Fees += fee;
        return (amount, fee);
    }

    public decimal Deposit(decimal amount)
    {
        if (amount <= 0m)
        {
            throw new System.InvalidOperationException("Deposit amount must be positive");
        }
        this.Deposits += amount;
        return amount;
    }


    public class Everyday : Accounts
    {
        public decimal MinBalance { get; private set; } = 0m;
        public decimal MaxBalance { get; private set; } = 1000000000000m;

        public override decimal Overdraft { get; protected set; } = 100m;

     
    }

    public class Investment : Accounts
    {
        public decimal InvestmentFee { get; private set; } = 10m;

        public override decimal Overdraft { get; protected set; } = 100m;


    }

    public class Omni : Accounts
    {
        public override decimal Overdraft { get; protected set; } = 1000m;

    }
 }
}
