using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem_3
{
    class _40_out_of_100
    {
        static void NotMain(string[] args)
        {
            int numberOfCommands = int.Parse(Console.ReadLine());
            LinkedList<int> linkedList = new LinkedList<int>();
            for (int i = 0; i < numberOfCommands; i++)
            {
                string[] commandParams = Console.ReadLine().Split().ToArray();

                switch (commandParams[0])
                {
                    case "add":
                        linkedList.AddFirst(int.Parse(commandParams[1]));
                        Console.WriteLine(string.Format("Added {0}", commandParams[1]));
                        break;
                    case "slide":
                        int numberOfSlides = int.Parse(commandParams[1]);
                        for (int j = 0; j < numberOfSlides; j++)
                        {
                            int firstToBe = linkedList.Last();
                            linkedList.RemoveLast();
                            linkedList.AddFirst(firstToBe);
                        }
                        Console.WriteLine(string.Format("Slided {0}", commandParams[1]));

                        break;
                    case "print":
                        Console.WriteLine(string.Join(" ", linkedList));
                        break;


                }
            }
        }
    }
}
