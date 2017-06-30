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
            int k = int.Parse(Console.ReadLine());
            int[] array = new int[n];
            ReadArray(array);
            Console.WriteLine(GetSumOfKElements(array, k)); 
        }

        private static int GetSumOfKElements(int[] array, int k)
        {
            int bestSum = 0;

            int[] sorted = array.OrderBy(x => x).ToArray();
            for (int i = 0; i < k; i++)
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
