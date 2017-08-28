using System;

namespace MaximumSum
{
    class BiggestSum
    {
        static void Main(string[] args)
        {
            int arraySize = int.Parse(Console.ReadLine());
            int[] array = new int[arraySize];

            ReadArray(array);
            
            Console.WriteLine(MaxSum(array, arraySize));
        }
        private static void ReadArray(int[] array)
        {
            for (int i = 0; i < array.Length; i++)
            {
                array[i] = int.Parse(Console.ReadLine());
            }
        }
        private static int MaxSum(int[] array, int arraySize)
        {
            int maxSum = int.MinValue;
            int sum = 0;
            int tmpStart = 0;
            int end = arraySize;
            int start = 0;

            for (int j = 0; j != arraySize; ++j)
            {
                sum += array[j];
                end = j;

                if (sum > maxSum || (sum == maxSum && (j - tmpStart) > (end - start)))
                {
                    maxSum = sum;
                    start = tmpStart;
                }
                if (sum < 0)
                {
                    sum = 0;
                    tmpStart = j + 1;
                }
            }
            return maxSum;
        }
    }
}