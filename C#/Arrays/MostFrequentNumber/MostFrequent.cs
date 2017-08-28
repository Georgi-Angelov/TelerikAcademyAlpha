using System;

namespace MostFrequentNumber
{
    class MostFrequent
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int[] array = new int[n];
            int currentMostFrequentCount = 1;
            int mostFrequentCount = 1;
            int mostFrequentNumber = 0;

            ReadArray(array);
            Array.Sort(array);

            for (int i = 0; i < n - 1; i++)
            {
                if (array[i] == array[i + 1])
                {
                    currentMostFrequentCount++;
                }
                else
                {
                    if (currentMostFrequentCount > mostFrequentCount)
                    {
                        mostFrequentCount = currentMostFrequentCount;
                        mostFrequentNumber = array[i];
                        currentMostFrequentCount = 1;
                    }
                    else
                    {
                        currentMostFrequentCount = 1;
                    }
                }
            }
            if (currentMostFrequentCount > mostFrequentCount)
            {
                mostFrequentCount = currentMostFrequentCount;
                mostFrequentNumber = array[array.Length - 1];
            }

            Console.WriteLine("{0} ({1} times)", mostFrequentNumber, mostFrequentCount); // For BGcoder
            //Console.WriteLine($"{mostFrequentNumber} ({mostFrequentCount} times)");


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