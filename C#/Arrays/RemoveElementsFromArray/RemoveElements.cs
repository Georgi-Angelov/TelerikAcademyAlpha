using System;

namespace RemoveElementsFromArray
{
    class RemoveElementsFromArray
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int[] inputArray = new int[n];
            for (int i = 0; i <= inputArray.Length - 1; i++)
            {
                inputArray[i] = int.Parse(Console.ReadLine());
            }

            int[] LongestIncreasingSequence = new int[n]; 

            for (int i = 0; i <= LongestIncreasingSequence.Length - 1; i++)
            {
                LongestIncreasingSequence[i] = 1;
            }

            for (int index = 1; index < n; index++)
            {
                for (int subIndex = 0; subIndex < index; subIndex++)
                {
                    if ((inputArray[index] >= inputArray[subIndex]) && (LongestIncreasingSequence[subIndex] >= LongestIncreasingSequence[index]))
                    {
                        LongestIncreasingSequence[index] = LongestIncreasingSequence[subIndex] + 1;
                    }
                }
            }

            Array.Sort(LongestIncreasingSequence);
            int printResult = n - LongestIncreasingSequence[LongestIncreasingSequence.Length - 1];
            Console.WriteLine(printResult);
        }
    }
}