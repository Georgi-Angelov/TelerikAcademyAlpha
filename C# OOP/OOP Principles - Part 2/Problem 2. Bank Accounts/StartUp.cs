using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem_2.Bank_Accounts
{
    class StartUp
    {
        static void Main(string[] args)
        {
            Bank bank = new Bank("Spiritus Sanctus");

            Customer firstOwner = new Customer("Ivaylo", CustomerType.Individuals);
            Deposit myDeposit = new Deposit(firstOwner, 6400, 23.55m, new DateTime(2016, 06, 28));
            bank.AddAccount(myDeposit);

            Customer secondOwner = new Customer("Telerik", CustomerType.Companies);
            Mortgage telerikLoanAccount = new Mortgage(secondOwner, 2000000, 25.25m, new DateTime(2009, 10, 20));
            bank.AddAccount(telerikLoanAccount);

            Console.WriteLine(bank);

            for (int i = 0; i < bank.AllBankAccounts.Count; i++)
            {
                Console.WriteLine();
                Console.WriteLine("Account {0}: ", i + 1);
                Console.WriteLine(bank.AllBankAccounts[i]);
            }

            decimal withdrawAmount = 1200M;
            decimal depositAmount = 20000M;


        }
    }
}
