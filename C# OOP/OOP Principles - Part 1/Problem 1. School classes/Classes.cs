using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem_1.School_classes
{
    public abstract class Classes : IComment
    {
        private string classID;
        private List<Student> students;
        private List<Teacher> teachers;
       
        //TODO: Fix naming 

        protected Classes (string classID)
        {
            this.classID = classID;
        }
        public List<Teacher> Teachers {
            get { return teachers; }
            set { this.teachers = new List<Teacher>(); }
                
        }
        public List<Student> Students
        {
            get { return students; }
            set { this.students = new List<Student>(); }
        }
        public void AddTeacher(Teacher teacher)
        {
            teachers.Add(teacher);
        }
        public void AddStudent(Student student)
        {
            students.Add(student);
        }

        public string AddComment(string comment)
        {
            return comment;
        }
    }
}
