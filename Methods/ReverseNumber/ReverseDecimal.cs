using System;
using System.Linq;

namespace ReverseNumber
{
    class ReverseDecimal
    {
        static void Main(string[] args)
        {
            char[] number = Console.ReadLine().ToCharArray().Reverse().ToArray();
            Console.WriteLine(number);
        }
    }
}
