using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem_1.Shape
{
    public abstract class Shape
    {
        private double width;
        private double hight;

        public double Width { get; set; }
        public double Hight { get; set; }

        public Shape(double width)
        {
            this.width = width;
        }
        public Shape(double width, double hight) : this(width)
        {
            this.hight = hight;
        }

        public abstract double CalculateSurface();
    }
}
