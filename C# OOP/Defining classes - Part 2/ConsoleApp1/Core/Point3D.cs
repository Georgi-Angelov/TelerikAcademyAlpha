using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Defining_classes
{
    public struct Point3D
    {
        private static readonly Point3D o;
        private double x;
        private double y;
        private double z;

        public static Point3D O
        {
            get { return o; }
        }

        static Point3D()
        {
            o = new Point3D(0, 0, 0);
        }
        public Point3D(double x, double y, double z) : this()
        {
            this.x = x;
            this.y = y;
            this.z = z;
        }

        public double X
        {
            get { return x; }
            set { this.x = value; }
        }
        public double Y
        {
            get { return y; }
            set { this.y = value; }
        }
        public double Z
        {
            get { return z; }
            set { this.z = value; }
        }
            

        public override string ToString() 
        {
            return $"X = {this.X}; Y = {this.Y}; Z = {this.Z}";
        }

        public static Point3D Parse(string input)
        {
            StringBuilder coordinates = new StringBuilder();

            double[] xyz = new double[3];
            int index = 0;

            for (int i = 0; i < input.Length; i++)
            {
                if (Char.IsDigit(input[i]) || input[i] == '-')
                {
                    while (i < input.Length && (Char.IsDigit(input[i]) || input[i] == '-' || input[i] == '.')) 
                    {
                        coordinates.Append(input[i]);
                        i++;
                    }
                }

                if (coordinates.Length > 0)
                {
                    double coord = double.Parse(coordinates.ToString());
                    xyz[index] = coord;
                    index++;
                    coordinates.Clear();
                }

            }
            return new Point3D(xyz[0], xyz[1], xyz[2]);
        }
    }
}
