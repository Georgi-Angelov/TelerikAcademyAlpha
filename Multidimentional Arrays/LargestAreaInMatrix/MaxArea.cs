using System;

namespace _07_Largest_area_in_matrix
{
    class MaxArea
    {
        private static int max = 0; 
        private static int[,] matrix;   
        private static int rows, cols;
        private static int currentSequence = 0;  
        private static bool[,] usedNums;    

        static void Main()
        {
            string[] input = Console.ReadLine().Split(' ');
            rows = int.Parse(input[0]);
            cols = int.Parse(input[1]);
            matrix = new int[rows, cols];
            usedNums = new bool[rows, cols];

            for (int row = 0; row < rows; row++)
            {
                input = Console.ReadLine().Split(' ');
                for (int col = 0; col < cols; col++)
                {
                    matrix[row, col] = int.Parse(input[col]);
                }
            }

            for (int row = 0; row < rows; row++)
            {
                for (int col = 0; col < cols; col++)
                {
                    currentSequence = 0;
                    FindChildren(matrix[row, col], row, col);
                    if (currentSequence > max)
                    {
                        max = currentSequence;
                    }
                }
            }

            Console.WriteLine(max);
        }

        //Recursion
        private static void FindChildren(int num, int row, int col)
        {
            currentSequence++;
            usedNums[row, col] = true;

            //Check Down Cell
            if (row + 1 < rows)
            {
                if (matrix[row + 1, col] == num && usedNums[row + 1, col] == false)
                {
                    FindChildren(num, row + 1, col);
                }
            }

            //Check Up Cell
            if (row - 1 >= 0)
            {
                if (matrix[row - 1, col] == num && usedNums[row - 1, col] == false)
                {
                    FindChildren(num, row - 1, col);
                }
            }

            //Check Left Cell
            if (col - 1 >= 0)
            {
                if (matrix[row, col - 1] == num && usedNums[row, col - 1] == false)
                {
                    FindChildren(num, row, col - 1);
                }
            }

            //Check Right Cell
            if (col + 1 < cols)
            {
                if (matrix[row, col + 1] == num && usedNums[row, col + 1] == false)
                {
                    FindChildren(num, row, col + 1);
                }
            }
        }
    }
}