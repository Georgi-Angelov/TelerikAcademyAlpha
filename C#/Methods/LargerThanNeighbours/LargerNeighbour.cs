using System;

namespace LargerThanNeighbours
{
    class LargerNeighbour
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

            int neighbourCount = LargerThanNeighbour(numArray);
            Console.WriteLine(neighbourCount);
        }

        private static int LargerThanNeighbour(int[] numArray)
        {
            int neighbourCount = 0;

            for (int i = 1; i < numArray.Length - 1; i++)
            {
                if (numArray[i] > numArray[i - 1] && numArray[i] > numArray[i + 1])
                {
                    neighbourCount++;
                }
            }
            return neighbourCount;
        }
    }
}
