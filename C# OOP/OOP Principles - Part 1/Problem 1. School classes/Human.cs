using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem_1.School_classes
{
    public abstract class Human
    {
        protected Human(string Name)
        {
            this.Name = Name;
        }

        public string Name { get; set; }
    }
}
