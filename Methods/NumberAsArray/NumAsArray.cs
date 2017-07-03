using System;
using System.Linq;

namespace NumberAsArray
{
    class NumAsArray
    {
        static void Main(string[] args)
        {
            var arraySizes = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            var firstArray = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            var secondArray = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            int firstArraySize = arraySizes[0];
            int secondArraySize = arraySizes[1];
            int remainder = 0;
            int[] result = SumNumArrays(firstArray, secondArray, firstArraySize, secondArraySize, ref remainder);
            Console.WriteLine(string.Join(" ", result));
        }

        private static int[] SumNumArrays(int[] firstArray, int[] secondArray, int firstArraySize, int secondArraySize, ref int remainder)
        {
            var result = new int[Math.Max(firstArraySize, secondArraySize)];

            for (int i = 0; i < Math.Min(firstArraySize, secondArraySize); i++)
            {
                result[i] = (firstArray[i] + secondArray[i] + remainder) % 10;
                remainder = (firstArray[i] + secondArray[i] + remainder) / 10;
            }
            if (firstArraySize > secondArraySize)
            {
                for (int i = secondArraySize; i < firstArraySize; i++)
                {
                    result[i] = (firstArray[i] + remainder) % 10;
                    remainder = (firstArray[i] + remainder) / 10;
                }
            }
            if (secondArraySize > firstArraySize)
            {
                for (int i = firstArraySize; i < secondArraySize; i++)
                {
                    result[i] = (secondArray[i] + remainder) % 10;
                    remainder = (secondArray[i] + remainder) / 10;
                }
            }

            return result;
        }
    }
}
