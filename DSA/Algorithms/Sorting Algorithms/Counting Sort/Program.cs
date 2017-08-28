using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Counting_Sort
{
    static class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = new List<int>();
            int min = 0;
            int max = 100;
            numbers.CountingSort(min, max);
            Console.WriteLine(numbers);
        }

        private static List<T> CountingSort<T>(List<T> elements, int min, int max, Func<T, int> getValue)
        {
            int positionsCount = max - min + 1;
            List<List<T>> positions = new List<List<T>>();
            for (int i = 0; i < positionsCount; i++)
            {
                positions.Add(new List<T>());
            }
            for (int i = 0; i < elements.Count; i++)
            {
                int position = getValue(elements[i]) - min;
                positions[elementsPosition].Add(elements[i]);

            }
        }
        private static List<int> CountingSort(this List<int> numbers, int min, int max)
        {
            int[] position = new int[max - min + 1];
            for (int i = 0; i < numbers.Count; i++)
            {
                position[numbers[i] - min]++;
            }
            List<int> result = new List<int>();

            for (int i = 0; i < position.Length; i++)
            {
                int j = position[i];
                while (j > 0)
                {
                    result.Add(i + min);
                    j--;
                }
            }

            return result;
        }
    }
}