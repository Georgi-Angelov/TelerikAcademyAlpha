using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem_3.Animal_hierarchy
{
    public class Tomcat : Cat
    {
        public Tomcat(int age, string name)
        {
            base.Age = age;
            base.Name = name;
            base.Sex = "male";
        }
    }
}
