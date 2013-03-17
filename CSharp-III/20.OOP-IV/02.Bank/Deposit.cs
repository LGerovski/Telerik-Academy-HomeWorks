using System;

namespace _02.Bank
{
    class Deposit : Account, IWithdraw
    {
        public Deposit(Customer accountHolder, decimal balance) : base(accountHolder, balance) { }
        public void Withdraw(decimal amount)
        {
            if (amount <= 0)
            {
                throw new ArgumentException("The amount for withdraw should be positive.");
            }
            else if (this.Balance < amount)
            {
                throw new ArgumentException("Insufficient balance");
            }
            else
            {
                this.Balance -= amount;
                Console.WriteLine("The withdraw was successful.");
                Console.WriteLine("Remaining balance: {0}", this.Balance);
            }
        }
        protected override decimal InterestRate(decimal interestRate, int months)
        {
            if (this.Balance < 1000)
            {
                interestRate = 0;
            }
            return this.Balance * interestRate * months;
        }

    }
}
