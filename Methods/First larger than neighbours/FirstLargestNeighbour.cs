using System;

namespace First_larger_than_neighbours
{
    class FirstLargestNeighbour
    {
        static void Main(string[] args)
        {
            int arraySize = int.Parse(Console.ReadLine());
            var numbers = Console.ReadLine().Split(' ');
            int[] numArray = new int[arraySize];
            for (int i = 0; i < arraySize; i++)
            {
                numArray[i] = int.Parse(numbers[i]);
            }

            int neighbourCount = GetFirstLargestNeighbour(numArray);
            Console.WriteLine(neighbourCount);
        }

        private static int GetFirstLargestNeighbour(int[] numArray)
        {
            int firstLargest = 0;

            for (int i = 1; i < numArray.Length - 1; i++)
            {
                if (numArray[i] > numArray[i - 1] && numArray[i] > numArray[i + 1])
                {
                    firstLargest = i;
                    break;
                }
            }
            return firstLargest;
        }

    }
}
