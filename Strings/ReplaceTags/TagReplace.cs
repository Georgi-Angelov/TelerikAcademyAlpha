using System;
using System.Text.RegularExpressions;

namespace _15.Replace_Tags
{
    class ExtractSentences
    {
        static void Main(string[] args)
        {
            // TODO Improve RegexExpression 80/100 in BGCoder or Whole Solution
            string input = Console.ReadLine();
            Regex r = new Regex(@"<a href=""(.*?)"">(.*?)</a>");
            string result = r.Replace(input, m => "[" + m.Groups[2] + "](" + m.Groups[1] + ")");
            Console.WriteLine(result);
        }
    }
}