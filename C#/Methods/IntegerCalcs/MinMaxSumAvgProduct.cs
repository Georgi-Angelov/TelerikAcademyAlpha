using System;
using System.Linq;

namespace IntegerCalcs
{
    class MinMaxSumAvgProduct
    {
        static void Main(string[] args)

        {
            var numArray = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            Console.WriteLine(Min(numArray));
            Console.WriteLine(Max(numArray));
            Console.WriteLine("{0:F2}", Average(numArray));
            Console.WriteLine(Sum(numArray));
            Console.WriteLine(Product(numArray));
        }


        private static int Min(int[] numArray)
        {
            int maxValue = numArray.Min();
            return maxValue;
        }
        private static int Max(int[] numArray)
        {
            int minValue = numArray.Max();
            return minValue;
        }
        private static double Average(int[] numArray)
        {
            double average = 0;
            int sum = 0;
            foreach (var number in numArray)
            {
                sum += number;
            }
            average = (double)(sum) / numArray.Length;
            return average;
        }
        private static int Sum(int[] numArray)
        {
            int sum = 0;
            foreach (var number in numArray)
            {
                sum += number;
            }
            return sum;
        }
        private static long Product(int[] numArray)
        {
            long product = 1;
            foreach (var number in numArray)
            {
                product *= number;
            }
            return product;
        }
    }
}
