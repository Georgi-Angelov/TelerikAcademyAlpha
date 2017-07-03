using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AddingPolynomials
{
    class PolynomialSum
    {
        static void Main(string[] args)
        {
            var sizeOfArray = int.Parse(Console.ReadLine());
            var firstPolynomial = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            var secondPolynomial = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();

            string sum = SumOfTwoPolynomials(firstPolynomial, secondPolynomial, sizeOfArray);
            Console.WriteLine(sum);
        }

        private static string SumOfTwoPolynomials(int[] firstPolynomial, int[] secondPolynomial,int sizeOfArray)
        {
            int[] polynomialSum = new int[sizeOfArray];
            for (int i = 0; i < firstPolynomial.Length; i++)
            {
                polynomialSum[i] = firstPolynomial[i] + secondPolynomial[i];
            }
            polynomialSum.Reverse();
            string result = string.Join(" ", polynomialSum);
            return result;
        }
    }
}
