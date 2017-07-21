using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem_1.School_classes
{
    public class Teacher : Human, IComment
    {
        private readonly List<Discipline> disciplines;
        public Teacher(string name, Discipline enteredDiscipline) : base(name)
        {
            disciplines = new List<Discipline>();
            disciplines.Add(enteredDiscipline);
        }
        public void AddDiscipline(Discipline addedDiscipline)
        {
            disciplines.Add(addedDiscipline);
        }
        public string AddComment(string comment)
        {
            return comment;
        }
    }
}
