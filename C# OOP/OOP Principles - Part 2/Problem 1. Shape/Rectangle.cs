using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem_1.Shape
{
    public class Rectangle : Shape
    {
        public Rectangle(double width, double hight) 
            : base(width, hight)
        {
        }

        public override double CalculateSurface()
        {
            return base.Hight * base.Width;
        }
        public override string ToString()
        {
            return $"Rectangle: w={base.Width} h={base.Hight} S={this.CalculateSurface():0.000}";
        }
    }
}
