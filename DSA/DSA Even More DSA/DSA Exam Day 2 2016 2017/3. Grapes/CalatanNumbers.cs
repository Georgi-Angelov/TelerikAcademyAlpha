using System;
using System.Numerics;

namespace _3.Grapes
{

    public class CatalanNumbers
    {
        static void Main()
        {
            int n = int.Parse(Console.ReadLine());
            if (n == 1 || n == 0)
            {
                Console.WriteLine("1");
            }
            else
            {
                BigInteger Factorial2N = 1;
                BigInteger FactorialN = 1;
                BigInteger FacturialNPlus1 = 1;
                for (int i = 1; i <= 2 * n; i++)
                {
                    Factorial2N *= i;
                    if (i <= n)
                    {
                        FactorialN *= i;
                    }
                }
                for (int i = 1; i <= n + 1; i++)
                {
                    FacturialNPlus1 *= i;
                }
                Console.WriteLine("{0}", Factorial2N / (FactorialN *
                FacturialNPlus1));
            }

        }
    }

}
