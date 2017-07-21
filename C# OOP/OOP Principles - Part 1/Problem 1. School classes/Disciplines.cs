using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem_1.School_classes
{
    public class Discipline : IComment
    {
        private string disciplineName;
        private int numOfExercises;
        private int numOfLectures;

        public string AddComment(string comment)
        {
            return comment;
        }
        public Discipline(string enteredDisciplineName, int enteredNumOfLectures, int enteredNumOfExercises)
        {
            this.disciplineName = enteredDisciplineName;
            this.numOfExercises = enteredNumOfExercises;
            this.numOfLectures = enteredNumOfLectures;
        }
        public string DisciplineName
        {
            get { return this.disciplineName; }
            set { this.disciplineName = value; }
        }

        public int NumOfLectures
        {
            get { return this.numOfLectures; }
            set { this.numOfLectures = value; }
        }

        public int NumOfExercises
        {
            get { return this.numOfExercises; }
            set { this.numOfExercises = value; }
        }
    }
}
