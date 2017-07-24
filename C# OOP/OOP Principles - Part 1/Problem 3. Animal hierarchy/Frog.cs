using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem_3.Animal_hierarchy
{
    public class Frog : Animal, ISound
    {
        public Frog(int age, string name, string sex)
        {
            this.Age = age;
            this.Name = name;
            this.Sex = sex;
        }

        public void Sound()
        {
            Console.WriteLine("Ribbit!");
        }
    }
}