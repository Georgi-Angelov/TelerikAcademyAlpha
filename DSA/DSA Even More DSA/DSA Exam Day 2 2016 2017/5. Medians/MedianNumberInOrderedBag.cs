using System;
using System.Linq;
using Wintellect.PowerCollections;

namespace _5.Medians
{
    public class MedianNumberInOrderedBag
    {
        public static void Main(string[] args)
        {

            string input = string.Empty;
            var list = new OrderedBag<int>();

            while ((input = Console.ReadLine()) != "EXIT")
            {
                var splitInput = input.Split().ToArray();
                if (splitInput[0] == "ADD")
                {
                    list.Add(int.Parse(splitInput[1]));
                }

                else
                {
                    double median;
                    if (list.Count % 2 == 0)
                    {
                        median = (double)(list[list.Count / 2] + list[list.Count / 2 - 1]) / 2;
                    }
                    else
                    {
                        median = (double)list[list.Count / 2];
                    }
                    Console.WriteLine(median);
                }
            }
        }
    }
}