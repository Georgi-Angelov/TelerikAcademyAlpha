using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem_2.Students_and_workers
{
    public class Worker : Human
    {
        private int weekSalary;
        private int workHoursPerDay;

        public int WorkHoursPerDay { get; set; }
        public int WeekSalary { get; set; }

        public Worker(string firstName, string lastName, int weekSalary, int workHoursPerDay) : base(firstName,lastName)
        {
            this.weekSalary = weekSalary;
            this.workHoursPerDay = workHoursPerDay;
        }
        public double MoneyPerHour()
        {
            double moneyPerHour = 0;
            double moneyPerDay = this.weekSalary / 7;

            moneyPerHour = moneyPerDay / (double)this.workHoursPerDay;

            return moneyPerHour;
        }


    }
}
