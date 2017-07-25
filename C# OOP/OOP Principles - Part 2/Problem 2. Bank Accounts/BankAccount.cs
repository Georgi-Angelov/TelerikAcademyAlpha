using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem_2.Bank_Accounts
{
    public class BankAccount : IDepositable
    {
        
        private Customer customer;
        private decimal balance;
        private decimal interestRate;
        private DateTime openDate;

        
        public BankAccount(Customer customer, decimal balance, decimal rate, DateTime openDate)
        {
            this.Customer = customer;
            this.Balance = balance;
            this.InterestRate = rate;
            this.openDate = openDate;
        }

        public Customer Customer
        {
            get { return this.customer; }
            set
            {
                if (value == null)
                {
                    throw new ArgumentNullException();
                }

                this.customer = value;
            }
        }

        public decimal Balance
        {
            get { return this.balance; }
            set { this.balance = value; }
        }

        public decimal InterestRate
        {
            get { return this.interestRate; }
            set { this.interestRate = value; }
        }
        public int NumberOfMonths
        {
            get
            {
                return (DateTime.Now.Year * 12 + DateTime.Now.Month) - (this.openDate.Year * 12 + this.openDate.Month);
            }
        }
        public void MakeDeposit(decimal amount)
        {
            if (amount <= 0)
            {
                throw new ArgumentException("You cannot deposite a negative or a zero sum!");
            }

            this.Balance += amount;
        }

        public virtual decimal CalculateInterestAmount()
        {
            return (this.NumberOfMonths * this.InterestRate);
        }
    }
}
