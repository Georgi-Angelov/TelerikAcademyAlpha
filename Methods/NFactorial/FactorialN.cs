using System;
using System.Numerics;

namespace NFactorial
{
    class FactorialN
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            BigInteger product = 1;
            for (int i = 1; i <= n; i++)
            {
                product *= i;
            }
            Console.WriteLine(product);
        }
    }
}
