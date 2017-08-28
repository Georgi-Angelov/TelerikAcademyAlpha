using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sorting_Algorithms
{
    public static class Program
    {
        static void Main(string[] args)
        {
            var array = new int[] { 1234, 12512, 152, 15, 21, 3, 214, 12, 34, 1234, 1, 234, 55, 2, 13, 41, 24, 12, 43, 12, 5, 62, 35, 12, 34 };
            array.QuickSort();
            Console.WriteLine(string.Join(" ", array));

            int agregate = 0;
            for (int i = 0; i < 10; i++)
            {
                agregate = 1 - agregate;
                Console.WriteLine(agregate);
            }
        }
        public static void QuickSort<T>(this IList<T> collection, Comparer<T> comparer = null)
        {
            const int startIndex = 0;
            int endIndex = collection.Count - 1;

            comparer = comparer ?? Comparer<T>.Default;

            collection.InternalQuickSort(startIndex, endIndex, comparer);
        }
        private static void InternalQuickSort<T>(this IList<T> collection, int leftmostIndex, int rightmostIndex, Comparer<T> comparer)
        {
            if (leftmostIndex < rightmostIndex)
            {
                int wallIndex = collection.InternalPartition(leftmostIndex, rightmostIndex, comparer);
                collection.InternalQuickSort(leftmostIndex, wallIndex - 1, comparer);
                collection.InternalQuickSort(wallIndex + 1, rightmostIndex, comparer);
            }
        }
        private static int InternalPartition<T>(this IList<T> collection, int leftmostIndex, int rightmostIndex, Comparer<T> comparer)
        {
            int pivotIndex = rightmostIndex;
            T pivotValue = collection[pivotIndex];

            var wallIndex = leftmostIndex;

            for (int i = leftmostIndex; i <= rightmostIndex - 1; i++)
            {
                if (comparer.Compare(collection[i], pivotValue) <= 0)
                {
                    collection.Swap(i, wallIndex);
                    wallIndex++;

                }
            }

            collection.Swap(wallIndex, pivotIndex);

            return wallIndex;
        }

        public static void Swap<T>(this IList<T> list, int firstIndex, int secondIndex)
        {
            if (list.Count < 2 || firstIndex == secondIndex)
            {
                return;
            }

            var temp = list[firstIndex];
            list[firstIndex] = list[secondIndex];
            list[secondIndex] = temp;
        }
    }
}
