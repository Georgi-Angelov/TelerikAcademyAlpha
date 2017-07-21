using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem_1.Define_class
{
    class Call
    {
        private DateTime date;
        private int time;
        private int dialedPhoneNum;
        private int seconds;

        public Call(DateTime date, int time, int dialedPhoneNum, int seconds)
        {
            this.date = date;
            this.time = time;
            this.dialedPhoneNum = dialedPhoneNum;
            this.seconds = seconds;
        }
        public DateTime Date
        {
            get { return date; }
            private set { this.date = value; }
        }
        public int Time
        {
            get { return time; }
            private set { this.time = value; }
        }
        public int DialedPhoneNum
        {
            get { return dialedPhoneNum; }
            private set { this.dialedPhoneNum = value; }
        }
        public int Seconds
        {
            get { return seconds; }
            private set { this.seconds = value; }
        }
    
    }
}
