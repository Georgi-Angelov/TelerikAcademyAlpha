using System;
using System.Text.RegularExpressions;

namespace _15.Replace_Tags
{
    class ExtractSentences
    {
        static void Main(string[] args)
        {
            // TODO Improve RegexExpression 80/100 in BGCoder
            string input = Console.ReadLine();
            
            Regex r = new Regex(@"(<\s*a\s*href\s*=)\s*""(.*?)""\s*>(.*?)<\s*/\s*a\s*>");
            string result = r.Replace(input, m => "[" + m.Groups[3] + "](" + m.Groups[2] + ")");

            Console.WriteLine(result);
        }
    }
}