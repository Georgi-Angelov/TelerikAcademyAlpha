using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Wintellect.PowerCollections;

namespace Problem_2
{
    static class Program
    {
        private static List<int> parents = new List<int>(Enumerable.Repeat(int.MaxValue, 10));
        static void Main(string[] args)
        {
            int numberOfComparisons = int.Parse(Console.ReadLine());
            List<List<int>> parents = new List<List<int>>(10);
            
            
            for (int i = 0; i < 10; i++)
            {
                parents.Add(new List<int>());
            }
            for (int i = 0; i < numberOfComparisons; i++)
            {
                string[] inputParams = Console.ReadLine().Split().ToArray();
                switch (inputParams[2])
                {
                    case "before":
                        parents[int.Parse(inputParams[0])].Add(int.Parse(inputParams[3]));
                        break;
                    case "after":
                        parents[int.Parse(inputParams[3])].Add(int.Parse(inputParams[0]));
                        break;
                }
            }
            //Console.WriteLine(string.Join(" ", parents.TopologicalSort()));
            
        }

        //public static List<int> TopologicalSort(this List<List<int>> parents,  )
        //{
            
        //}
        
    }
}

