using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem_1.School_classes
{
    public abstract class Human
    {
        private string name;
        
        public Human(string Name)
        {
            this.name = Name;
        }

        public string Name
        {
            get { return this.name; }
            set { this.name = value; }
        }

    }
}
