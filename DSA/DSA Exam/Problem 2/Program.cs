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
        static void Main(string[] args)
        {
            int numberOfComparisons = int.Parse(Console.ReadLine());
            List<Item> itemList = new List<Item>();
            
            for (int i = 0; i < numberOfComparisons; i++)
            {
                string[] inputParams = Console.ReadLine().Split().ToArray();
                switch (inputParams[2])
                {
                    case "before":
                        
                        break;
                    case "after":

                        break;
                }
            }
            
            List<int> sorted = unsorted.TSort(dependencies);
        }

        public static List<int> GraphDependencies(Item item)
        {
            
        }
        public class Item
        {
            public int Number { get; }
            public Item[] Dependencies { get; }

            public Item(int number, params Item[] dependencies)
            {
                Number = number;
                Dependencies = dependencies;
            }
        }
        public static IList<T> TSort<T>(IEnumerable<T> source, Func<T, IEnumerable<T>> getDependencies)
        {
            var sorted = new List<T>();
            var visited = new Dictionary<T, bool>();

            foreach (var item in source)
            {
                Visit(item, getDependencies, sorted, visited);
            }

            return sorted;
        }

        public static void Visit<T>(T item, Func<T, IEnumerable<T>> getDependencies, List<T> sorted, Dictionary<T, bool> visited)
        {
            bool inProcess;
            var alreadyVisited = visited.TryGetValue(item, out inProcess);

            if (alreadyVisited)
            {
                if (inProcess)
                {
                    throw new ArgumentException("Cyclic dependency found.");
                }
            }
            else
            {
                visited[item] = true;

                var dependencies = getDependencies(item);
                if (dependencies != null)
                {
                    foreach (var dependency in dependencies)
                    {
                        Visit(dependency, getDependencies, sorted, visited);
                    }
                }

                visited[item] = false;
                sorted.Add(item);
            }
        }
    }
}

