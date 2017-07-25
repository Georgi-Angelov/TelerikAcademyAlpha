﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem_1.Shape
{
    public class Triangle : Shape
    {
        private double width;
        private double hight;

        public Triangle(double width, double hight) 
            : base(width, hight)
        {

        }

        public override double CalculateSurface()
        { 
            return (base.Hight * base.Width) / 2;
        }
        public override string ToString()
        {
            return $"Triangle: w={base.Width} h={base.Hight} S={this.CalculateSurface():0.000}";
        }
    }
}
