using System;
using System.Collections.Generic;
using System.Linq;

namespace Box_Full_Of_Balls
{
    class BoxOfBalls
    {
        static void Main(string[] args)
        {
            int[] possibleMoves = Console.ReadLine()
                            .Split()
                            .Select(int.Parse)
                            .ToArray();

            int[] range = Console.ReadLine()
                            .Split()
                            .Select(int.Parse)
                            .ToArray();
           
            int rangeStart = range[0];
            int rangeEnd = range[1];

            bool[] isWins = new bool[rangeEnd + 1];
            isWins[0] = false;

            for (int i = 1; i <= rangeEnd; i++)
            {
                foreach (var possibleMove in possibleMoves)
                {
                    if (possibleMove > i)
                    {
                        continue;
                    }
                    if (!isWins[i - possibleMove])
                    {
                        isWins[i] = true;
                    }
                }
            }

            int totalWins = 0;

            for (int i = rangeStart; i <= rangeEnd; i++)
            {
                if (isWins[i])
                {
                    totalWins++;
                }
            }
            
            Console.WriteLine(totalWins);
        }

        
    }
}
