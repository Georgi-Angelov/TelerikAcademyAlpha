using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Maximum_increasing_sequence
{
    class MaxIncreasingSequence
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int[] array = new int[n];

            for (int i = 0; i < n; i++)
            {
                array[i] = int.Parse(Console.ReadLine());
            }
            int count = 1;
            int maxCount = 0;
            for (int i = 0; i < n - 1; i++)
            {
                if (array[i] < array[i + 1])
                {
                    count++;
                }
                else
                {
                    count = 1;
                }
                if (maxCount < count)
                {
                    maxCount = count;
                }
            }
            Console.WriteLine(maxCount);
        }
    }
}
