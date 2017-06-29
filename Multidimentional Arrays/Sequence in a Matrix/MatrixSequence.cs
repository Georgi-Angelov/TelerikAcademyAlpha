using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sequence_in_a_Matrix
{
    class MatrixSequence
    {
        static void Main(string[] args)
        {
            string[] numbers = Console.ReadLine().Split();
            int lines = int.Parse(numbers[0]);
            int strings = int.Parse(numbers[1]);

            int[,] matrix = new int[lines, strings];
            for (int row = 0; row < lines; row++)
            {
                var values = (Console.ReadLine().Split(' '));
                for (int column = 0; column < strings; column++)
                {
                    matrix[row, column] = int.Parse(values[column]);
                }
            }

        }
    }
}
