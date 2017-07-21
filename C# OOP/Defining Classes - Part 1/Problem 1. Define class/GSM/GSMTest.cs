using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem_1.Define_class
{
    public class GSMTest
    {
        public List<GSM> phoneArray;
        public GSMTest()
        {
            phoneArray = new List<GSM>();
        }
        public void ReadInput()
        {
            string inputString = Console.ReadLine();
            while (inputString != "end")
            {

                inputString = Console.ReadLine();
            }

        }

    }
}
