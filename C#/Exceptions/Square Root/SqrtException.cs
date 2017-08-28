using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Square_Root
{
    class SqrtException
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            double number;
            double squareRoot;
            try
            {
                if (double.IsNaN(double.Parse(input)) || double.Parse(input) < 0)
                {
                    throw new Exception("Invalid number");
                }
                number = double.Parse(input);
                squareRoot = Math.Sqrt(number);
                Console.WriteLine("{0:F3}", squareRoot);
            }
            catch (Exception)
            {
                Console.WriteLine("Invalid number");
            }
            
            finally
            {
                Console.WriteLine("Good bye");
            }
        }
    }
}
