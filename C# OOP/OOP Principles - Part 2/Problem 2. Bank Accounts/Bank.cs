using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem_2.Bank_Accounts
{
    public class Bank
    {
        private string name;
        private IList<BankAccount> allBankAccounts;

        public Bank(string name)
        {
            this.Name = name;
            this.allBankAccounts = new List<BankAccount>();
        }
        public IList<BankAccount> AllBankAccounts
        {
            get
            {
                return this.allBankAccounts;
            }
            set
            {
                this.allBankAccounts = value;
            }
        }
        public string Name
        {
            get
            {
                return this.name;
            }
            private set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new ArgumentException("The name of the bank cannot be null!");
                }

                this.name = value;
            }
        }
        public void AddAccount(BankAccount newBankAccount)
        {
            this.allBankAccounts.Add(newBankAccount);
        }

        public override string ToString()
        {
            return $"The Bank \"{this.Name}\"\nOpened accounts: {this.allBankAccounts.Count}";
        }

    }
}
