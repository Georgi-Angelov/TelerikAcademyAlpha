using System;
using System.Linq;

namespace Box_Full_Of_Balls
{
    class BoxOfBalls
    {
        static void Main(string[] args)
        {
            var possibleMoves = Console.ReadLine().Split().Select(int.Parse).ToArray();
            var range = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int wins = 0;
            for (int i = range[0]; i <= range[1]; i++)
            {
                foreach (var possibleMove in possibleMoves)
                {
                    if (possibleMove == i)
                    {
                        wins++;
                        continue;
                    }
                    else
                    {
                        
                    }
                }
            }
            Console.WriteLine(wins);
        }
    }
}
