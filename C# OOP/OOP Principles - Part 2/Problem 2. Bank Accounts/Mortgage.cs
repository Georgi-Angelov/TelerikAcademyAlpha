using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem_2.Bank_Accounts
{
    public class Mortgage : BankAccount
    {
        public Mortgage(Customer customer, decimal balance, decimal rate, DateTime openDate) : base(customer, balance, rate, openDate)
        {
        }
        public override decimal CalculateInterestAmount()
        {
            if (this.Customer.Type == CustomerType.Companies && this.NumberOfMonths < 12)
            {
                return base.CalculateInterestAmount() / 2;
            }
            if (this.Customer.Type == CustomerType.Companies && this.NumberOfMonths < 2)
            {
                return base.CalculateInterestAmount() / 2;
            }

            return base.CalculateInterestAmount();
        }
    }
}
