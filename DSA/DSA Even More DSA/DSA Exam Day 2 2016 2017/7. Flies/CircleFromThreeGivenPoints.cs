using System;
using System.Linq;

namespace _7.Flies
{
    public class CircleFromThreeGivenPoints
    {
        public static void Main(string[] args)
        {
            var first = Console.ReadLine().Split().Select(double.Parse).ToArray();
            var second = Console.ReadLine().Split().Select(double.Parse).ToArray();
            var third = Console.ReadLine().Split().Select(double.Parse).ToArray();

            Point2D p1 = new Point2D(first[0], first[1]);
            Point2D p2 = new Point2D(second[0], second[1]);
            Point2D p3 = new Point2D(third[0], third[1]);

            var circleCenter = new CircleCenter();
            Circle c = circleCenter.calculateCircleCoordinatesFromThreeRandomPoints(p1, p2, p3);
            Console.WriteLine(c.ToString());

        }
    }
    public class Point2D
    {
        private double x;
        private double y;

        public Point2D(double x, double y)
        {
            this.x = x;
            this.y = y;
        }

        public double X
        {
            get
            {
                return this.x;
            }
            set
            {
                this.x = value;
            }
        }
        public double Y
        {
            get
            {
                return this.y;
            }
            set
            {
                this.y = value;
            }
        }
    }
    public class Circle
    {
        private Point2D center;

        public Circle(Point2D center)
        {
            this.center = center;
        }

        public override string ToString()
        {
            string circleX = string.Format("{0:F4}", center.X);
            string circleY = string.Format("{0:F4}", center.Y);
            return circleX + " " + circleY;
        }
    }
    public class CircleCenter
    {
        public Circle calculateCircleCoordinatesFromThreeRandomPoints(Point2D p1, Point2D p2, Point2D p3)
        {
            // deltaT is offset
            double deltaT = p2.X * p2.X + p2.Y * p2.Y;
            double bc = (p1.X * p1.X + p1.Y * p1.Y - deltaT) / 2;
            double cd = (deltaT - p3.X * p3.X - p3.Y * p3.Y) / 2;

            double det = (p1.X - p2.X) * (p2.Y - p3.Y) - (p2.X - p3.X) * (p1.Y - p2.Y);
            double iDet = 1 / det;

            double centerX = (bc * (p2.Y - p3.Y) - cd * (p1.Y - p2.Y)) * iDet;
            double centerY = (cd * (p1.X - p2.X) - bc * (p2.X - p3.X)) * iDet;

            return new Circle(new Point2D(centerX, centerY));
        }
    }
}
