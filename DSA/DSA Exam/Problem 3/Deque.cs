using System;
using System.Linq;
using Wintellect.PowerCollections;

namespace Problem_3
{
    class Deque
    {
        static void Main(string[] args)
        {
            int numberOfCommands = int.Parse(Console.ReadLine());
            Deque<int> deque = new Deque<int>(); 
            for (int i = 0; i < numberOfCommands; i++)
            {
                string[] commandParams = Console.ReadLine().Split().ToArray();

                switch (commandParams[0])
                {
                    case "add":
                        deque.AddToFront(int.Parse(commandParams[1]));
                        Console.WriteLine(string.Format("Added {0}", commandParams[1]));
                        break;
                    case "slide":
                        int numberOfSlides = int.Parse(commandParams[1]);
                        for (int j = 0; j < numberOfSlides ; j++)
                        {
                            int firstToBe = deque.Last();
                            deque.RemoveFromBack();
                            deque.AddToFront(firstToBe);
                        }
                        Console.WriteLine(string.Format("Slided {0}", commandParams[1]));

                        break;
                    case "print":
                        Console.WriteLine(string.Join(" ", deque));
                        break;


                }
            }
        }
    }
}
