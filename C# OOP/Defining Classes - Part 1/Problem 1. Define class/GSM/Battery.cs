using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem_1.Define_class
{
    public class Battery
    {
        private string batteryModel;
        private int hoursIdle;
        private int hoursTalked;
        private BatteryType batteryType;
        
        public Battery(string batteryModel)
        {
            this.batteryModel = BatteryModel;
        }
        public Battery(string batteryModel, int hoursIdle ) : this(batteryModel)
        {
            this.hoursIdle = hoursIdle;
        }
        public Battery(string batteryModel, int hoursIdle, int hoursTalked ) : this(batteryModel,hoursIdle)
        {
            this.hoursTalked = hoursTalked;
        }
        public Battery(string batteryModel, int hoursIdle, int hoursTalked, BatteryType batteryType ) : this(batteryModel,hoursIdle,hoursTalked)
        {
            this.batteryType = batteryType;
        }   
        

        public string BatteryModel
        {
            get { return batteryModel; }
            set { batteryModel = value; }
        }
        public int HoursIdle
        {
            get { return hoursIdle; }
            set
            {
                if (hoursIdle <=  0)
                {
                    throw new ArgumentOutOfRangeException("Hours Idle must be above 0");
                }
                hoursIdle = value;
            }
        }
        public int HoursTalked
        {
            get { return hoursTalked; }
            set {
                if (hoursTalked <= 0)
                {
                    throw new ArgumentOutOfRangeException(" Hours Talked must be a positive number");
                }
                hoursTalked = value; }
        }

        public BatteryType BatteryType
        {
            get { return batteryType; }
            set { batteryType = value; }
        }
        
    }
}
