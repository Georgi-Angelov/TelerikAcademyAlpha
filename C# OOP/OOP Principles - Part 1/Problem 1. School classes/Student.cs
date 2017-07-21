using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem_1.School_classes
{
    public class Student : Human, IComment
    {
        private string studentName;
        private int studentID;

        public Student(string Name, int studentID) : base(Name)
        {
            this.studentID = studentID;
        }

        public string StudentName
        {
            get
            {
                return studentName;
            }
            set
            {
                this.studentName = value;
            }
        }
        public int StudentClassNumber
        {
            get
            {
                return studentID;
            }
            set
            {
                this.studentID = value;
            }
        }

        public string AddComment(string comment)
        {
            return comment;
        }
    }
}
