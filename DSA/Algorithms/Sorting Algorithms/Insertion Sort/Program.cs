using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Insertion_Sort
{
    static class Program
    {
        static void Main(string[] args)
        {
            int sizeOfArray = int.Parse(Console.ReadLine());
            var array = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();

            array.InsertionSort();
            
        }
        static void InsertionSort(this int[] array)
        {
            for (int i = 1; i < array.Length; i++)
            {
                int temp = array[i];
                int j = i - 1;

                while (j >= 0 && array[j] > temp)
                {
                    array[j + 1] = array[j];
                    j--;
                }
                array[j + 1] = temp;
                Console.WriteLine(string.Join(" ", array));
            }
        }
    }
}
