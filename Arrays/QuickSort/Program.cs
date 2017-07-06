using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Quicksort
{
    class Program
    {
        static void Main(string[] args)
        {
            int numberOfLines = int.Parse(Console.ReadLine());
            int[] unsorted = new int[numberOfLines];

            for (int i = 0; i < numberOfLines; i++)
            {
                unsorted[i] = int.Parse(Console.ReadLine());

            }
            //PrintUnsortedArray(unsorted);
            
            PerformQuicksort(unsorted, 0, unsorted.Length - 1);
            
            PrintSortedArray(unsorted);

        }

        private static void PrintSortedArray(int[] unsorted)
        {
            for (int i = 0; i < unsorted.Length; i++)
            {
                Console.WriteLine(unsorted[i]);
            }
        }

        private static void PrintUnsortedArray(int[] unsorted)
        {
            for (int i = 0; i < unsorted.Length; i++)
            {
                Console.Write(unsorted[i] + " ");
            }
        }

        public static void PerformQuicksort(int[] elements, int left, int right)
        {
            int i = left, j = right;
            int pivot = elements[(left + right) / 2];

            while (i <= j)
            {
                while (elements[i].CompareTo(pivot) < 0)
                {
                    i++;
                }

                while (elements[j].CompareTo(pivot) > 0)
                {
                    j--;
                }

                if (i <= j)
                {
                    // Swap
                    int tmp = elements[i];
                    elements[i] = elements[j];
                    elements[j] = tmp;

                    i++;
                    j--;
                }
            }

            // Recursive calls
            if (left < j)
            {
                PerformQuicksort(elements, left, j);
            }

            if (i < right)
            {
                PerformQuicksort(elements, i, right);
            }
        }

    }
}