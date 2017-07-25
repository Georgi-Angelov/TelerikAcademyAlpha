using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem_2.Bank_Accounts
{
    public class Deposit : BankAccount,IDepositable, IWithdrawable
    {
        public Deposit(Customer customer, decimal balance, decimal rate, DateTime openDate) : base(customer, balance, rate, openDate)
        {
        }
        public override decimal CalculateInterestAmount()
        {
            if (this.Balance < 1000)
            {
                return 0;
            }

            return base.CalculateInterestAmount();
        }
        public void MakeDeposit(decimal depositedSum)
        {
            if (depositedSum <= 0)
            {
                Console.WriteLine("Deposit cannot be less or equal to zero!");
            }
            this.Balance += depositedSum;
        }

        public void Withdraw(decimal withdrawedSum)
        {
            if (withdrawedSum <= 0)
            {
                throw new ArgumentException("You cannot withdraw a negative or a zero sum!");
            }

            this.Balance -= withdrawedSum;
        }
    }
}
