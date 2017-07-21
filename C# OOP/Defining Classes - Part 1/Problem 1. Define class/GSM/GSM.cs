using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem_1.Define_class
{
    public class GSM
    {
        private string gsmModel;
        private string gsmManifacturer;
        private decimal? gsmPrice; 
        private string gsmOwner;
        private static GSM iPhone7S = new GSM("iPhone7S", "Ябълка", 999.99m, "Steven Jobsu");
        
        private List<Call> callHistory;


        public GSM(string gsmModel, string gsmManifacturer)
        {
            this.gsmModel = gsmModel;
            this.gsmManifacturer = gsmManifacturer;
        }
        public GSM(string gsmModel, string gsmManifacturer, decimal? gsmPrice = null, string gsmOwner = null) : this(gsmModel,gsmManifacturer)
        {
            this.gsmPrice = gsmPrice;
            this.gsmOwner = gsmOwner;
        }
        public GSM(string gsmModel, string gsmManifacturer, decimal? gsmPrice = null, string gsmOwner = null, Battery BatteryCharacteristics = null, Display DisplayCharacteristics = null) : this(gsmModel,gsmManifacturer,gsmPrice,gsmOwner)
        {
            
        }
        
        public string GSMModel
        {
            get {   return gsmModel; }
            set
            {
                if (value.Length < 2)
                {
                    throw new ArgumentOutOfRangeException("The model name must be at least 2 characters long!");
                }
                this.gsmModel = value;
            }

        }
        public string GSMManifacturer
        {
            get {   return gsmManifacturer; }
            set
            {
                if (value.Length < 2)
                {
                    throw new ArgumentOutOfRangeException("The manifacturer name must be at least 2 characters long!");
                }
                this.gsmManifacturer = value;
            }
        }
        public decimal? GSMPrice
        {
            get {   return gsmPrice; }
            set
            {
                if (gsmPrice < 0)
                {
                    throw new ArgumentOutOfRangeException(" price must me more than 0 ");
                }
                gsmPrice = value;
            }
        }
        public string GSMOwner
        {
            get { return gsmOwner; }
            set
            {
                if (value.Length < 2)
                {
                    throw new ArgumentOutOfRangeException("The value must be long at least 2 characters!");
                }
                this.gsmOwner = value;
            }
        }
        public GSM IPhone7S { get { return iPhone7S; } }


        public override string ToString()
        {
            Console.WriteLine("        GSM        ");
            Console.WriteLine($"GSM model is:{this.gsmModel}");
            Console.WriteLine($"GSM manifacturer is:{this.gsmManifacturer}");
            Console.WriteLine($"GSM price is:{this.gsmPrice}");
            Console.WriteLine($"GSM owner is:{this.gsmOwner}");
            return base.ToString();
        }

        public List<Call> CallHistory
        {
            get;
            private set;
        }

        public void AddCall(DateTime date, int time, int phoneNum, int seconds)
        {
            Call firstCall = new Call(date,time,phoneNum,seconds);
            callHistory.Add(firstCall);
        }

        public void RemoveCall(Call call)
        {

            callHistory.Remove(call);
        }
        public int GetCallPrice()
        {
            return 0;
        }
    }
}
