using System;

namespace SelectionSort
{
    class StartUp
    {
        static void Main(string[] args)
        {
            //int[] inputArray = new int[] { 1, 1, 23, 3, 24, 4, 123, 4, 1, 234, 1, 2, 34, 123, 22, 43, 1, 6, 8, 8, 8, 6, 76, 456, };
            int arraySize = int.Parse(Console.ReadLine());
            int[] array = new int[arraySize];
            ReadArray(array);
            PerformSelectionSort(array);

            foreach (var number in array)
            {
                Console.WriteLine(number);
            }
            //Console.WriteLine(string.Join(" ", PerformSelectionSort(array)));
        }
        private static void ReadArray(int[] array)
        {
            for (int i = 0; i < array.Length; i++)
            {
                array[i] = int.Parse(Console.ReadLine());
            }
        }
        private static int[] PerformSelectionSort(int[] inputArray)
        {
            for (int index = 0; index < inputArray.Length - 1; index++)
            {
                int smallestIndex = index;
                for (int comparedIndex = index + 1; comparedIndex < inputArray.Length; comparedIndex++)
                {
                    if (inputArray[comparedIndex] < inputArray[smallestIndex])
                    {
                        smallestIndex = comparedIndex;
                    }
                }
                int swap = inputArray[smallestIndex];
                inputArray[smallestIndex] = inputArray[index];
                inputArray[index] = swap;

            }
            return inputArray;
        }
    }
}
