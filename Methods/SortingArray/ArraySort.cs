using System;
using System.Linq;

namespace SortingArray
{
    class ArraySort
    {
        static void Main(string[] args)
        {
            var arraySize = Console.ReadLine();
            var array = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
             
            Console.WriteLine(string.Join(" ",PerformArraySort(array)));
        }

        private static int[] PerformArraySort(int[] array)
        {
            Array.Sort(array);
            return array;
        }
    }
}
