using System;

namespace _02.Bank
{
    class Loan : Account
    {
        public Loan(Customer accountHolder, decimal balance) : base(accountHolder, balance) { }
        
        protected override decimal InterestRate(decimal interestRate, int months)
        {
            if (this.Accountholder is Individual)
            {
                months = Math.Max(0, months - 3);
            }
            else if (this.Accountholder is Company)
            {
                months = Math.Max(0, months - 2);
            }
            return this.Balance * interestRate * months;
        }
    }
}
