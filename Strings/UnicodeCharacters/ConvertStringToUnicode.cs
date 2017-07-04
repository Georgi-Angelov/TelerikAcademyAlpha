using System;
using System.Linq;
using System.Text;

namespace UnicodeCharacters
{
    class ConvertStringToUnicode
    {
        static void Main(string[] args)
        {
            string inputString = Console.ReadLine();
            //// BGCoder Solution
            //StringBuilder sb = new StringBuilder();
            //foreach (char c in inputString)
            //{
            //    sb.AppendFormat("\\u{0:X4}", (uint)c);
            //}
            //string result = sb.ToString();
            //Console.Write(result);

            //Second Solution with LINQ
            var chars = inputString
                    .Select(a => (int)a)
                    .Select(a => $@"\u{a:x4}");

            var result = string.Concat(chars);
            Console.Write(result);
        }
    }
}
