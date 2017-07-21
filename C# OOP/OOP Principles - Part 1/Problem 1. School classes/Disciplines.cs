using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem_1.School_classes
{
    public class Discipline : IComment
    {
        public string AddComment(string comment)
        {
            return comment;
        }
        public Discipline(string enteredDisciplineName, int enteredNumOfLectures, int enteredNumOfExercises)
        {
            this.DisciplineName = enteredDisciplineName;
            this.NumOfExercises = enteredNumOfExercises;
            this.NumOfLectures = enteredNumOfLectures;
        }
        public string DisciplineName { get; set; }

        public int NumOfLectures { get; set; }

        public int NumOfExercises { get; set; }
    }
}
