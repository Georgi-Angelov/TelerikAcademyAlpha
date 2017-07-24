using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem_2.Students_and_workers
{
    public class Worker
    {
        private int weekSalary;
        private int workHoursPerDay;

        public int WorkHoursPerDay { get; set; }
        public int WeekSalary { get; set; }

        public Worker(int weekSalary, int workHoursPerDay)
        {
            this.weekSalary = weekSalary;
            this.workHoursPerDay = workHoursPerDay;
        }
        public double MoneyPerHour()
        {
            double moneyPerHour = 0;

            moneyPerHour = (double)this.weekSalary / (double)this.workHoursPerDay ;

            return moneyPerHour;
        }


    }
}
