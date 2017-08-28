using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NNestedLoops
{
    class NNestedLoops
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int[] arr = new int[n];
            Loops(arr, 0);
        }

        static void Loops(int[] arr, int index)
        {
            if (index >= arr.Length)
            {
                foreach (int element in arr)
                {
                    Console.Write($"{element} ");
                }
                Console.WriteLine();
            }
            else
            {
                for (int i = 1; i <= arr.Length; i++)
                {
                    arr[index] = i;
                    Loops(arr, index + 1);
                }
            }
        }
    }
}
