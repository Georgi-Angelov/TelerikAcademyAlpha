using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem_2.Students_and_workers
{
    public class Student : Human
    {
        private double grade;
        
        public Student(string firstName, string lastName, double grade) : base(firstName,lastName) 
        {
            this.grade = grade;
        }
        public double Grade
        {
            get
            {
                return this.grade;
            }
        }
    }
}
