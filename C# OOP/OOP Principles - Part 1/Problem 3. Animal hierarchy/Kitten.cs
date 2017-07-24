using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem_3.Animal_hierarchy
{
    public class Kitten : Cat
    {
        public Kitten(int age, string name)
        {
            base.Age = age;
            base.Name = name;
            base.Sex = "female";
        }
    }
}
