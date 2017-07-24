using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem_2.Students_and_workers
{
    class StartUp
    {
        static void Main(string[] args)
        {
            List<Student> students = new List<Student>();
            
            students.Add(new Student("Pesho", "Stamatov", 6.00f));
            students.Add(new Student("Shisho", "BackShisho", 3.25f));
            students.Add(new Student("Return", "Vrushtalov", 2.00f));
            students.Add(new Student("Svetlio", "Hakera", 5.50f));
            students.Add(new Student("Hristo", "SurbqtGoRucete", 5.99f));
            students.Add(new Student("Gosho", "GledaLosho", 6.90f));
            students.Add(new Student("Ganka", "Gerdanka", 3.40f));
            students.Add(new Student("Beshamel", "Lazaniov", 5.49f));
            students.Add(new Student("Ucho", "Oopetov", 4.24f));
            students.Add(new Student("Mimi", "Hackentosh-a", 3.60f));

            
            foreach (var student in students.OrderBy(x => x.Grade))
            {
                Console.WriteLine($"{student.FirstName} {student.LastName} {student.Grade}");
            }
            Console.WriteLine("\n");
            List<Worker> workers = new List<Worker>();

            workers.Add(new Worker("Aragorn", "Angelov", 1050, 10));
            workers.Add(new Worker("Strider", "Angelov", 1432, 10));
            workers.Add(new Worker("Elessar", "Angelov", 9999, 10));
            workers.Add(new Worker("Thorongil", "Angelov", 12005, 10));
            workers.Add(new Worker("Arathorn II", "Angelov", 99999, 10));
            workers.Add(new Worker("Arador", "Angelov", 12344, 10));
            workers.Add(new Worker("Argonui", "Angelov", 12532, 10));
            workers.Add(new Worker("Arathorn I", "Angelov", 12346, 10));
            workers.Add(new Worker("Arassuil", "Angelov", 19876, 10));
            workers.Add(new Worker("Arahad II", "Angelov", 77777, 10));

            foreach (var worker in workers.OrderBy(x => x.MoneyPerHour()))
            {
                Console.WriteLine($"{worker.FirstName} {worker.LastName} {worker.MoneyPerHour()}");
            }

            Console.WriteLine("\n");
            List<Human> humans = new List<Human>();

            humans.AddRange(students);
            humans.AddRange(workers);

            foreach (var human in humans.OrderBy(x => x.FirstName).ThenBy(x => x.LastName))
            {
                Console.WriteLine($"{human.FirstName} {human.LastName}");
            }
        }
    }
}
