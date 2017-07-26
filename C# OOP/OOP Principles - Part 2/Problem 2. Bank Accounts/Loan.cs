using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem_2.Bank_Accounts
{
    public class Loan : BankAccount, IDepositable
    {
        public Loan(Customer customer, decimal balance, decimal rate, DateTime openDate) : base(customer, balance, rate, openDate)
        {
        }
        public void MakeDeposit(decimal depositAmount)
        {
            if (depositAmount <= 0)
            {
                Console.WriteLine("Deposit amount can't be less or equal to zero!");
            }
            this.Balance += depositAmount;
        }
        public override decimal CalculateInterestAmount()
        {
            if (this.Customer.Type == CustomerType.Individuals && this.NumberOfMonths < 3)
            {
                return 0;
            }
            if (this.Customer.Type == CustomerType.Companies && this.NumberOfMonths < 2)
            {
                return 0;
            }

            return base.CalculateInterestAmount();
        }
    }
}
