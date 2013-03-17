using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.Bank
{
    abstract class Account : IDeposit
    {
        private Customer accountHolder;
        private decimal balance;
        protected Account(Customer accountholder, decimal balance)
        {
            this.Accountholder = accountHolder;
            this.Balance = balance;
        }
        public Customer Accountholder
        {
            get
            {
                return this.accountHolder;
            }
            protected set
            {
                this.accountHolder = value;
            }
        }
        public decimal Balance
        {
            get
            {
                return this.balance;
            }
            protected set
            {
                this.balance = value;
            }
        }
        public void DepositMoney(decimal amount)
        {
            this.Balance += amount;
        }
        protected abstract decimal InterestRate(decimal interestRate, int months);
    }
}
