using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem_3.Animal_hierarchy
{
    class StartUp
    {
        static void Main(string[] args)
        {
            var animals = new List<Animal>();

            animals.Add(new Kitten(2, "Jorkata"));
            animals.Add(new Kitten(6, "Jorkata"));
            animals.Add(new Dog(15, "Haralampi", "Male"));
            animals.Add(new Dog(5, "Haralampi", "Male"));
            animals.Add(new Tomcat(6, "Magelan"));
            animals.Add(new Tomcat(2, "Magelan"));
            animals.Add(new Frog(8, "Ribit", "Female"));
            animals.Add(new Frog(2, "Ribit", "Female"));
            animals.Add(new Frog(6, "Ribit", "Female"));
            animals.Add(new Frog(1, "Ribit", "Female"));

            // TODO: calculate avg. age of each animal

        }
    }
}
