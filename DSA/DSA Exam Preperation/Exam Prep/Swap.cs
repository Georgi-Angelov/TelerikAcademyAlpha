using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace Swapping
{
    static class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            var nodes = Enumerable.Range(0, n + 1)
                        .Select(x => new DoubleLinkedListNode(x))
                        .ToArray();

            for (int i = 1; i < n; i++)
            {
                nodes[i].Link(nodes[i + 1]);
            }

            var first = nodes[1];
            var last = nodes[n];

            Console.ReadLine()
                   .Split(' ')
                   .Select(int.Parse)
                   .ToList()
                   .ForEach(num =>
                   {
                       var newLast = nodes[num].Left;
                       var newFirst = nodes[num].Right;

                       nodes[num].Detatch();

                       if (last != nodes[num])
                       {
                           last.Link(nodes[num]);
                       }
                       else
                       {
                           newFirst = nodes[num];
                       }
                       if (first != nodes[num])
                       {
                           nodes[num].Link(first);
                       }
                       else
                       {
                           newLast = nodes[num];
                       }

                       first = newFirst;
                       last = newLast;
                   });
            //Console.WriteLine(first.Value);
            //Console.WriteLine(last.Value);
            //Console.WriteLine(last.Right); /* if empty last is actually last, if there is a value there is a mistake in asigning last element */
            Console.WriteLine(string.Join(" ", first));
        }
    }
    class DoubleLinkedListNode : IEnumerable<int>
    {
        private int value;
        private DoubleLinkedListNode left;
        private DoubleLinkedListNode right;

        public DoubleLinkedListNode(int v)
        {
            this.value = v;
            this.left = null;
            this.right = null;
        }
        public DoubleLinkedListNode Left
        {
            get { return this.left; }
            set { this.left = value; }
        }
        public DoubleLinkedListNode Right
        {
            get { return this.right; }
            set { this.right = value; }
        }
        public int Value 
        {
            get { return this.value; }
            set { this.value = value; }
        }

        public void Link(DoubleLinkedListNode row)
        {
            this.Right = row;
            row.Left = this;
        }
        public void Detatch()
        {
            if (this.Left != null)
            {
                this.Left.Right = null;
                this.Left = null;
            }
            if (this.Right != null)
            {
                this.Right.Left = null;
                this.Right = null;
            }

        }
        public IEnumerator<int> GetEnumerator()
        {
            var node = this;
            while (node != null)
            {
                yield return node.Value;
                node = node.Right;
            }
        }
        IEnumerator IEnumerable.GetEnumerator()
        {
            throw new NotImplementedException();
        }
    }
}
