using System;
using System.Linq;

namespace Guards
{
    class MazeWithGuards
    {
        static void Main()
        {
            int[] dimentions = Console.ReadLine()
                .Split(' ')
                .Select(x => int.Parse(x))
                .ToArray();

            var guardedMaze = new int[dimentions[0], dimentions[1]];

            int guardCount = int.Parse(Console.ReadLine());

            for (int i = 0; i < guardCount; i++)
            {
                string[] inputGuard = Console.ReadLine().Split(' ').ToArray();
                AssignGuards(guardedMaze, inputGuard);
            }
            //PrintMatrix(rows, cols, guardedMaze);
            int shortestPath = ShortestPath(guardedMaze);

            if (shortestPath == -1)
            {
                Console.WriteLine("Meow");
            }
            else
            {
                Console.WriteLine(shortestPath);
            }
            //PrintMatrix(rows, cols, guardedMaze);

        }

        private static void AssignGuards(int[,] guardedMaze, string[] inputGuard)
        {
            int row = int.Parse(inputGuard[0]);
            int col = int.Parse(inputGuard[1]);
            string direction = inputGuard[2];

            guardedMaze[row, col] = -1;
            int rowsOfGuardedMatrix = guardedMaze.GetLength(0);
            int colsOfGuardedMatrix = guardedMaze.GetLength(1);

            switch (direction)
            {
                case "D":
                    if (row < rowsOfGuardedMatrix - 1 && guardedMaze[row + 1, col] != -1)
                    {
                        guardedMaze[row + 1, col] = 3;
                    }
                    break;
                case "U":
                    if (row > 0 && guardedMaze[row - 1, col] != -1)
                    {
                        guardedMaze[row - 1, col] = 3;
                    }
                    break;
                case "R":
                    if (col < colsOfGuardedMatrix - 1 && guardedMaze[row, col + 1] != -1)
                    {
                        guardedMaze[row, col + 1] = 3;
                    }
                    break;
                case "L":
                    if (col > 0 && guardedMaze[row, col - 1] != -1)
                    {
                        guardedMaze[row, col - 1] = 3;
                    }
                    break;
            }
        }

        //private static void PrintMatrix(int rows, int cols, int[,] guardedMaze)
        //{
        //    for (int i = 0; i < rows; i++)
        //    {
        //        for (int j = 0; j < cols; j++)
        //        {
        //            Console.Write($"{guardedMaze[i, j]} ");
        //        }
        //        Console.WriteLine();
        //    }
        //}

        private static int ShortestPath(int[,] guardedMaze)
        {
            for (int row = 0; row < guardedMaze.GetLength(0); row++)
            {
                for (int col = 0; col < guardedMaze.GetLength(1); col++)
                {
                    if (guardedMaze[row, col] == 0)
                    {
                        guardedMaze[row, col] = 1;
                    }
                    else if (guardedMaze[row, col] == -1)
                    {
                        continue;
                    }

                    if (row == 0 && col == 0)
                    {
                        continue;
                    }

                    else if (row == 0 || guardedMaze[row - 1, col] == -1)
                    {
                        if (col == 0 || guardedMaze[row, col - 1] == -1)
                        {
                            guardedMaze[row, col] = -1;
                        }
                        else
                        {
                            guardedMaze[row, col] = guardedMaze[row, col - 1] + guardedMaze[row, col];

                        }
                    }
                    else if (col == 0 || guardedMaze[row, col - 1] == -1)
                    {

                        guardedMaze[row, col] = guardedMaze[row - 1, col] + guardedMaze[row, col];
                    }
                    else
                    {
                        guardedMaze[row, col] = Math.Min(guardedMaze[row, col - 1], guardedMaze[row - 1, col]) + guardedMaze[row, col];
                    }
                }
            }

            if (guardedMaze[guardedMaze.GetLength(0) - 1, guardedMaze.GetLength(1) - 1] == -1)
            {
                return -1;
            }

            return guardedMaze[guardedMaze.GetLength(0) - 1, guardedMaze.GetLength(1) - 1];
        }
    }
}
