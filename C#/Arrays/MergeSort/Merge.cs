using System;

namespace MergeSort
{
    class Merge
    {
        static void Main(string[] args)
        {
            int arraySize = int.Parse(Console.ReadLine());
            int[] unsortedArray = new int[arraySize];
            ReadArray(unsortedArray);
            //int[] array = { 3, 8, 7, 5, 2, 1, 9, 6, 4 }; /// For Testing

            MergeRecursive(unsortedArray, 0, unsortedArray.Length - 1);

            foreach (var number in unsortedArray)
            {
                Console.WriteLine(number);
            }
            //Console.WriteLine(string.Join(" ", array)); /// For Testing
        }
        private static void ReadArray(int[] unsortedArray)
        {
            for (int i = 0; i < unsortedArray.Length; i++)
            {
                unsortedArray[i] = int.Parse(Console.ReadLine());
            }
        }
        private static void MergeRecursive(int[] unsortedArray, int leftIndex, int rightIndex)
        {
            if (rightIndex > leftIndex)
            {
                int middleIndex = (rightIndex + leftIndex) / 2;
                MergeRecursive(unsortedArray, leftIndex, middleIndex);
                MergeRecursive(unsortedArray, (middleIndex + 1), rightIndex);
                DoMerge(unsortedArray, leftIndex, middleIndex, rightIndex);
            }

        }
        private static void DoMerge(int[] unsortedArray, int leftIndex, int middleIndex, int rightIndex)
        {
            int lengthLeft = middleIndex - leftIndex + 1;
            int lengthRight = rightIndex - middleIndex;
            int[] leftArray = new int[lengthLeft + 1];
            int[] rightArray = new int[lengthRight + 1];
            for (int i = 0; i < lengthLeft; i++)
            {
                leftArray[i] = unsortedArray[leftIndex + i];
            }
            for (int j = 0; j < lengthRight; j++)
            {
                rightArray[j] = unsortedArray[middleIndex + j + 1];
            }
            leftArray[lengthLeft] = Int32.MaxValue;
            rightArray[lengthRight] = Int32.MaxValue;
            int iIndex = 0;
            int jIndex = 0;
            for (int k = leftIndex; k <= rightIndex; k++)
            {
                if (leftArray[iIndex] <= rightArray[jIndex])
                {
                    unsortedArray[k] = leftArray[iIndex];
                    iIndex++;
                }
                else
                {
                    unsortedArray[k] = rightArray[jIndex];
                    jIndex++;
                }
            }
        }
    }
}