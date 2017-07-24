using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem_3.Animal_hierarchy
{
    public class Cat : Animal, ISound
    {
        public void Sound()
        {
            Console.WriteLine("Murrrr!");
        }
    }
}
