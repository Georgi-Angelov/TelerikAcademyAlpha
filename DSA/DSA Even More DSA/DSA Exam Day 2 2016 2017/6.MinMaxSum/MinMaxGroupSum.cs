using System;
using System.Linq;

namespace _6.MinMaxSum
{
    public class MinMaxGroupSum
    {
        static void Main(string[] args)
        {
            int N = int.Parse(Console.ReadLine());

            for (int i = 0; i < N; i++)
            {
                var mAndG = Console.ReadLine()
                                   .Split()
                                   .Select(int.Parse)
                                   .ToArray();
                var sequenceCount = mAndG[0];
                var groupsCount = mAndG[1];

                var numbers = Console.ReadLine()
                                     .Split()
                                     .Select(int.Parse)
                                     .ToArray();




                //Console.WriteLine(MinSum(numbers, n, k));
            }


        }
        ///Maximal sequence of size k
        //private static int MinSum(int[] numbers, int n, int k)
        //{
        //    if (n < k)
        //    {
        //        return -1;
        //    }
            
        //    int res = 0;
        //    for (int i = 0; i < k; i++)
        //    {
        //        res += numbers[i];
        //    }

        //    int curr_sum = res;
        //    for (int i = k; i < n; i++)
        //    {
        //        curr_sum += numbers[i] - numbers[i - k];
        //        res = Math.Max(res, curr_sum);
        //    }

        //    return res;
        //}
    }
}
