using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;

namespace _15.Replace_Tags
{
    class ExtractSentences
    {
        static void Main(string[] args)
        {

            string input = Console.ReadLine();
            Regex r = new Regex(@"<a href=""(.*?)"">(.*?)</a>");
            string result = r.Replace(input, m => "[" + m.Groups[2] + "](" + m.Groups[1] + ")");
            Console.WriteLine(result);



            //string text = Console.ReadLine();
            //StringBuilder result = new StringBuilder();

            //string openTag = "<a href=";
            //string endTag = "</a>";

            //int startIndexOpenTag = text.IndexOf(openTag);
            //int endIndexCloseTag = text.IndexOf(endTag);
            //int indexCurrPart = 0;

            //while (startIndexOpenTag != -1 || endIndexCloseTag != -1)
            //{
            //    string currPart = text.Substring(indexCurrPart, startIndexOpenTag - indexCurrPart);
            //    string toEdit = text.Substring(startIndexOpenTag, endIndexCloseTag - startIndexOpenTag + endTag.Length);
            //    string url = "(" + toEdit.Substring(openTag.Length + 1, (toEdit.IndexOf(">") - openTag.Length - 1 - 1)) + ")";
            //    string innerText = "[" + toEdit.Substring(toEdit.IndexOf(">") + 1, toEdit.LastIndexOf("<") - toEdit.IndexOf(">") - 1) + "]";

            //    result.Append(currPart);
            //    result.Append(innerText);
            //    result.Append(url);

            //    indexCurrPart = endIndexCloseTag + endTag.Length;
            //    startIndexOpenTag = text.IndexOf(openTag, startIndexOpenTag + 1);
            //    endIndexCloseTag = text.IndexOf(endTag, endIndexCloseTag + 1);

            //    if (startIndexOpenTag == -1 && endIndexCloseTag == -1)
            //    {
            //        currPart = text.Substring(indexCurrPart);
            //        result.Append(currPart);
            //    }
            //}

            //Console.WriteLine(result);
        }
    }
}