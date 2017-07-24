using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem_2.Students_and_workers
{
    public class Student : Human
    {
        private int grade;


        public Student(string firstName, string lastName, int grade) : base(firstName,lastName)
        {
            this.grade = grade;
        }
    }
}
