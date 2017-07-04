using System;
using System.Linq;

namespace ReverseString
{
    class ReverseString
    {
        static void Main(string[] args)
        {
            char[] inputString = Console.ReadLine().Reverse().ToArray();
            Console.WriteLine(inputString);
        }
    }
}
