using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem_1.Shape
{

    class StartUp
    {
        public static double[] widths = { 1.2, 2.0, 3.5, 4, 18, 3.6, 8.9, 10 };
        public static double[] heights = { 2.5, 3.4, 0.2, 0.1, 0.15, 18.5, 10, 11 };
        public const int numberOfShapes = 10;
        public static Random rng = new Random();
        static void Main(string[] args)
        {
            Shape[] shapes = new Shape[numberOfShapes];

            for (int i = 0; i < numberOfShapes; i++)
            {
                switch (rng.Next() % 3)
                {
                    case 0:
                        shapes[i] = new Triangle(widths[rng.Next(0, widths.Length)],
                                                 heights[rng.Next(0, heights.Length)]);
                        break;
                    case 1:
                        shapes[i] = new Rectangle(widths[rng.Next(0, widths.Length)],
                                                  heights[rng.Next(0, heights.Length)]);
                        break;
                    case 2:
                        shapes[i] = new Square(heights[rng.Next(0, heights.Length)]);
                        break;
                }
            }
            foreach (var item in shapes)
            {
                Console.WriteLine(item.ToString());
            }
        }
    }
}
