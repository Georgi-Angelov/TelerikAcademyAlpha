using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace sortQuickAlgorithm
{
    class quickSortAlgorithm
    {

        private int[] array = new int[20];
        private int len;

        public void QuickSortAlgorithm()
        {
            Sort(0, len - 1);
        }

        public void Sort(int left, int right)
        {
            var leftend = left;
            var rightend = right;
            var pivot = array[left];

            while (left < right)
            {
                while ((array[right] >= pivot) && (left < right))
                {
                    right--;
                }

                if (left != right)
                {
                    array[left] = array[right];
                    left++;
                }

                while ((array[left] >= pivot) && (left < right))
                {
                    left++;
                }

                if (left != right)
                {
                    array[right] = array[left];
                    right--;
                }
            }

            array[left] = pivot;
            pivot = left;
            left = leftend;
            right = rightend;

            if (left < pivot)
            {
                Sort(left, pivot - 1);
            }
            if (right > pivot)
            {
                Sort(pivot + 1, right);
            }
        }

        public static void Main()
        {
            quickSortAlgorithm q_Sort = new quickSortAlgorithm();

            int[] array = {41, 32, 15, 45, 63, 72, 57, 43, 32, 52, 183};
            q_Sort.array = array;
            q_Sort.len = q_Sort.array.Length;
            q_Sort.QuickSortAlgorithm();

            for (int j = 0; j < q_Sort.len; j++)
            {
                Console.WriteLine(q_Sort.array[j]);
            }
            Console.ReadKey();
        }
    }
}