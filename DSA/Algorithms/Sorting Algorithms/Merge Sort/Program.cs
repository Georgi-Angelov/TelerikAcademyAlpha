using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Merge_Sort
{
    static class Program
    {
        static void Main(string[] args)
        {

            List<int> numbers = new List<int>(Console.ReadLine().Split(' ').Select(int.Parse).ToList());
            
            numbers.MergeSort();
            
            Console.WriteLine();
        }

        private static List<int> MergeSort(this List<int> numbers)
        {
            if (numbers.Count < 2)
            {
                return numbers;
            }
            List<int> left = numbers.Take(numbers.Count / 2).ToList();
            List<int> right = numbers.Skip(numbers.Count / 2).ToList();
            Task leftResult = Task.Run(() => left = MergeSort(left));
            Task rightResult = Task.Run(() => right = MergeSort(right));
            Task.WaitAll(leftResult, rightResult);

            return MergeSortedList(left,right);
        }
        private static List<int> MergeSortedList(List<int> left, List<int> right)
        {
            int i = 0;
            int j = 0;
            List<int> result = new List<int>();
            while (i < left.Count() && j < right.Count)
            {
                if (left[i] <= right[j])
                {
                    result.Add(left[i]);
                    i++;
                }
                else
                {
                    result.Add(right[j]);
                    j++;
                }
            }
            while (i < left.Count )
            {
                result.Add(left[i]);
                i++;
            }
            while (j < right.Count)
            {
                result.Add(right[j]);
                j++;
            }
            return result;
        }
    }
}
