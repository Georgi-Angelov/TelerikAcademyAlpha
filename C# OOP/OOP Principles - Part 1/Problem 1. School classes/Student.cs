using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem_1.School_classes
{
    public class Student : Human, IComment
    {
        public Student(string Name, int studentID) : base(Name)
        {
            this.StudentClassNumber = studentID;
        }

        public string StudentName { get; set; }

        public int StudentClassNumber { get; set; }

        public string AddComment(string comment)
        {
            return comment;
        }
    }
}
