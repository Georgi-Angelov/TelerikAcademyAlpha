namespace DFSGraphTraversal
{
    using System;
    using System.Collections.Generic;

    public class DfsTraverse
    {
        private static readonly HashSet<string> Visited = new HashSet<string>();
        private static Dictionary<string, List<string>> graph;

        public static void Main()
        {
            var graph = new Dictionary<string, List<string>>
            {
                {"sofiq", new List<string> {"burgas", "varna", "plovdiv", "kyustendil"} },
                {"burgas", new List<string> {"varna", "vidin", "gabrovo"} },
                {"plovdiv", new List<string> {"burgas", "vidin", "gabrovo"} },
                {"gabrovo", new List<string> {"sofiq"} },
                {"kyustendil", new List<string> {"blagoevgrad", "sofiq", "dupnica"} },
                {"varna", new List<string> {"sofiq", "burgas"} },
                {"vidin", new List<string> {"plovdiv", "burgas"} },
                {"dupnica", new List<string> {"kyustendil", "blagoevgrad"} },
                {"blagoevgrad", new List<string> {"sofiq", "kyustendil", "dupnica"} },
            };

            DFS("burgas");



            // DFS Recursive
            var recursiveGraph = new Graph(
                new[]
                {
                    new[] { 3, 6 }, // successors of vertice 0
                    new[] { 2, 3, 4, 5, 6 }, // successors of vertice 1
                    new[] { 1, 4, 5 }, // successors of vertice 2
                    new[] { 0, 1, 5 }, // successors of vertice 3
                    new[] { 1, 2, 6 }, // successors of vertice 4
                    new[] { 1, 2, 3 }, // successors of vertice 5
                    new[] { 0, 1, 4 } // successors of vertice 6
                });

            recursiveGraph.DfsRecursive(0);

        }
        /// <summary>
        /// DFS Recursive
        /// </summary>
        /// <param name="node"></param>
        /// namespace DFSRecursiveOOPGraph
        
        public class Graph
        {
            private readonly HashSet<int> visited;
            private readonly int[][] childNodes;

            public Graph(int[][] nodes)
            {
                this.childNodes = nodes;
                this.visited = new HashSet<int>();
            }

            public void DfsRecursive(int node)
            {
                if (!this.visited.Contains(node))
                {
                    this.visited.Add(node);
                    Console.WriteLine(node);

                    for (int i = 0; i < this.childNodes[node].Length; i++)
                    {
                        this.DfsRecursive(this.childNodes[node][i]);
                    }
                }
            }
        }
        /// <summary>
        /// DFS Traversal
        /// </summary>
        /// <param name="node"></param>
       
        public static void DFS(string node)
        {
            var nodes = new Stack<string>();
            nodes.Push(node);
            Visited.Add(node);

            while (nodes.Count != 0)
            {
                string currentNode = nodes.Pop();
                Console.WriteLine(currentNode);

                for (int i = 0; i < graph[currentNode].Count; i++)
                {
                    if (!Visited.Contains(graph[currentNode][i]))
                    {
                        nodes.Push(graph[currentNode][i]);
                        Visited.Add(graph[currentNode][i]);
                    }
                }
            }
        }
    }
}
