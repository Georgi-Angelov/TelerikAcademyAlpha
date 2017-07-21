using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem_1.Define_class
{
    public class Display
    {
        private int size;
        private int numberOfColors;

        public Display(int size, int numberOfColors)
        {
            this.size = size;
            this.numberOfColors = numberOfColors;
        }

        public int Size
        {
            get { return size; }
            set
            {
                if (value < 0)
                {
                    throw new ArgumentOutOfRangeException("Can NOT be a negative number!");
                }
                size = value;
            }
        }
        public int Colors
        {
            get { return numberOfColors; }
            set
            {
                if (value < 0)
                {
                    throw new ArgumentOutOfRangeException("Can NOT be a negative number!");
                }
                numberOfColors = value;
            }
        }
    }
}
