using System;

namespace Sequence_in_a_Matrix
{
    class MatrixSequence
    {
        static void Main()
        {
            string[] numbers = Console.ReadLine().Split();
            int lines = int.Parse(numbers[0]);
            int strings = int.Parse(numbers[1]);
            int maxSequence = 0;
            string[,] matrix = new string[lines, strings];
            int counter;
            ReadMatrix(matrix);
            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                for (int col = 0; col < matrix.GetLength(1); col++)
                {
                    counter = 0;
                    while (row + counter < matrix.GetLength(0))
                    {
                        if (matrix[row, col] == matrix[row + counter, col])
                        {
                            counter++;
                        }
                        else
                        {
                            break;
                        }
                    }
                    if (maxSequence < counter)
                    {
                        maxSequence = counter;
                    }
                    counter = 0;
                    while (col + counter < matrix.GetLength(1))
                    {
                        if (matrix[row, col] == matrix[row, col + counter])
                        {
                            counter++;
                        }
                        else
                        {
                            break;
                        }
                    }
                    if (maxSequence < counter)
                    {
                        maxSequence = counter;
                    }
                    counter = 0;
                    while (row + counter < matrix.GetLength(0) && col + counter < matrix.GetLength(1))
                    {
                        if (matrix[row, col] == matrix[row + counter, col + counter])
                        {
                            counter++;
                        }
                        else
                        {
                            break;
                        }
                    }
                    if (maxSequence < counter)
                    {
                        maxSequence = counter;

                    }
                    // TODO: Get other diagonal working
                }
            }
            
            Console.WriteLine(maxSequence);

        }
            private static void ReadMatrix(string[,] matrix)
            {
                for (int row = 0; row < matrix.GetLength(0); row++)
                {
                    var values = Console.ReadLine().Split(' ');
                    for (int column = 0; column < matrix.GetLength(1); column++)
                    {
                        matrix[row, column] = values[column];
                    }
                }
            }
    }
}

