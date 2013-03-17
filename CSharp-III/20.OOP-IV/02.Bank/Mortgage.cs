using System;

namespace _02.Bank
{
    class Mortgage : Account
    {
        public Mortgage(Customer accountHolder, decimal balance) : base(accountHolder, balance) { }
        
        protected override decimal InterestRate(decimal interestRate, int months)
        {
            if (this.Accountholder is Company)
            {
                if (months <= 12)
                {
                    interestRate = interestRate / 2;
                }
                else
                {
                    decimal interest = this.Balance * interestRate / 2 * 12;
                    interest += this.Balance * interestRate * (months - 12);
                    return interest;
                }
            }
            else if (this.Accountholder is Individual)
            {
                months = Math.Max(0, months - 6);
            }
            return this.Balance * interestRate * months;
        }
    }
}
