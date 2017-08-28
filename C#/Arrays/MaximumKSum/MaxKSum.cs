using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MaximumKSum
{
    class MaxKSum
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int numberOfBiggestElements  = int.Parse(Console.ReadLine());
            int[] array = new int[n];
            ReadArray(array);
            Console.WriteLine(SumOfArrayElements(array, numberOfBiggestElements));
            
        }

        private static int SumOfArrayElements(int[] array, int numberOfBiggestElements)
        {
            int bestSum = 0;

            Array.Sort(array);
            Array.Reverse(array);
            for (int i = 0; i < numberOfBiggestElements; i++)
            {
                bestSum += array[i];
            }

            return bestSum;
        }
        private static void ReadArray(int[] array)
        {
            for (int i = 0; i < array.Length; i++)
            {
                array[i] = int.Parse(Console.ReadLine());
            }
        }
    }
}
