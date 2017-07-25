using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem_2.Bank_Accounts
{
    public interface IWithdrawable
    {
        void Withdraw(decimal withdrawAmount);
    }
}
