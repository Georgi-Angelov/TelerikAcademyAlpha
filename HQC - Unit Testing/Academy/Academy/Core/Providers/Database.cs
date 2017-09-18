using Academy.Core.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Academy.Models.Contracts;

namespace Academy.Core.Providers
{
    public class Database : IDatabase
    {
        private IList<ISeason> seasons;

        private IList<IStudent> students;

        private IList<ITrainer> trainers;

        private IList<string> logResult;

        public Database()
        {
            this.seasons = new List<ISeason>();
            this.students = new List<IStudent>();
            this.trainers = new List<ITrainer>();
            this.logResult = new List<string>();
        }

        public IList<ISeason> Seasons
        {
            get
            {
                return this.seasons;
            }
            set
            {
                this.seasons = value;
            }
        }
        public IList<IStudent> Students
        {
            get
            {
                return this.students;
            }
            set
            {
                this.students = value;
            }
        }
        public IList<ITrainer> Trainers
        {
            get
            {
                return this.trainers;
            }
            set
            {
                this.trainers = value;
            }
        }
        public IList<string> LogResult
        {
            get
            {
                return this.logResult;
            }
            set
            {
                this.logResult = value;
            }
        }

    }
}