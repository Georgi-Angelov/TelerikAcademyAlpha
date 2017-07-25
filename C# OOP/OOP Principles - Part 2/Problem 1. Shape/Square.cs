using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem_1.Shape
{
    public class Square : Shape
    {
        public Square(double width) 
            : base(width)
        {
            
        }

        public override double CalculateSurface()
        {
            return base.Width * base.Width;
        }
        public override string ToString()
        {
            return $"Square: w={base.Width} S={this.CalculateSurface():0.000}";
        }
    }
}
