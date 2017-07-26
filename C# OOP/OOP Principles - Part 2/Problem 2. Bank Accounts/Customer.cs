using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem_2.Bank_Accounts
{
    public class Customer 
    {
        private string name;
        private CustomerType type;

        public Customer(string name, CustomerType type)
        {
            this.Name = name;
            this.Type = type;
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
                    throw new ArgumentException("The name cannot be null!");
                }
                this.name = value;
            }
        }
        public CustomerType Type
        {
            get
            {
                return this.type;
            }
            private set
            {
                this.type = value;
            }
        }
    }
}
