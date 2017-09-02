namespace Office
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class Solution
    {
        public const int MaxTasksCount = 50;

        private static int[] memory;
        private static bool[] beenThereDoneThat = new bool[MaxTasksCount];

        public static void Main()
        {
            var n = int.Parse(Console.ReadLine());
            memory = new int[n];
            var executionTimes = Console.ReadLine()
                .Split(' ')
                .Select(int.Parse)
                .ToArray();

            var tasks = new KeyValuePair<int, List<int>>[n];

            for (int i = 0; i < n; i++)
            {
                var dependencies = Console.ReadLine()
                    .Split(' ')
                    .Select(x => int.Parse(x) - 1)
                    .ToList();

                tasks[i] = new KeyValuePair<int, List<int>>(executionTimes[i], dependencies);
            }

            for (int i = 0; i < n; i++)
            {
                if (memory[i] == 0)
                {
                    memory[i] = CalculateMinimumTime(tasks, i);
                }
            }

            Console.WriteLine(memory.Max());
        }

        private static int CalculateMinimumTime(KeyValuePair<int, List<int>>[] tasks, int taskId)
        {
            if (memory[taskId] != 0)
            {
                return memory[taskId];
            }

            var executionTime = tasks[taskId].Key;
            var max = int.MinValue;

            foreach (var nextId in tasks[taskId].Value)
            {
                if (nextId != -1)
                {
                    if (beenThereDoneThat[nextId])
                    {
                        // TODO: Fix this shit!
                        Console.WriteLine(-1);
                        Environment.Exit(0);
                    }

                    beenThereDoneThat[nextId] = true;
                    var next = CalculateMinimumTime(tasks, nextId);

                    if (next > max)
                    {
                        max = next;
                    }
                    beenThereDoneThat[nextId] = false;
                }
            }

            memory[taskId] = (max > 0 ? max : 0) + executionTime;

            return memory[taskId];
        }
    }
}

//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace OfficeSpace
//{
//    public class Program
//    {
//        private static Dictionary<int, List<int>> dict = new Dictionary<int, List<int>>();
//        private static int[] times;
//        private static int[] optimalTimes;

//        public static void Main()
//        {
//            int tasks = int.Parse(Console.ReadLine());
//            times = Console.ReadLine().Split(' ').Select(x => int.Parse(x)).ToArray();

//            //reading in the dependancy data and setting our dictionary with descendants
//            for (int i = 0; i < tasks; i++)
//            {
//                var parents = Console.ReadLine().Split(' ').Select(x => int.Parse(x)).ToList();
//                if (parents[0] == 0)
//                {
//                    dict.Add(i + 1, new List<int>());
//                    continue;
//                }

//                dict.Add(i + 1, new List<int>());
//                dict[i + 1].AddRange(parents);
//            }
//            optimalTimes = new int[tasks + 1];
//            for (int i = 1; i < optimalTimes.Length; i++)
//            {
//                optimalTimes[i] = CalculateMinTime(i);
//            }

//            Console.WriteLine(optimalTimes.Max());
//        }

//        public static int CalculateMinTime(int task)
//        {
//            //if (optimalTimes[task] < 0)
//            //{
//            //    Console.WriteLine(-1);
//            //    Environment.Exit(0);
//            //}
//            //optimalTimes[task] = -1;//i start processing it, if encountere again it's a sign for a cyclic dependency


//            if (optimalTimes[task] != 0)
//            {
//                return optimalTimes[task];
//            }

//            if (dict[task].Count == 0)
//            {
//                return times[task - 1]; //times are zero based
//            }

//            int maxDependencyTime = 0;

//            foreach (int parent in dict[task])
//            {
//                int dependencyTime = CalculateMinTime(parent);
//                maxDependencyTime = Math.Max(dependencyTime, maxDependencyTime);
//            }

//            optimalTimes[task] = times[task - 1] + maxDependencyTime;
//            return optimalTimes[task];
//        }
//    }
//}