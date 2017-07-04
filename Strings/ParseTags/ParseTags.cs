using System;
using System.Text;

namespace ParseTags
{
    class ParseTags
    {
        static void Main()
        {
            string text = Console.ReadLine();
            StringBuilder builder = ParseTagInString(text);

            Console.WriteLine(builder.ToString());

        }

        private static StringBuilder ParseTagInString(string text)
        {
            StringBuilder builder = new StringBuilder();

            while (text.IndexOf('<') != -1)
            {
                builder.Append(text.Substring(0, text.IndexOf('<')));

                text = text.Remove(0, text.IndexOf('<') + 1);

                builder.Append(text.Substring(text.IndexOf('>') + 1, (text.IndexOf('<') - text.IndexOf('>') - 1)).ToUpper());

                text = text.Remove(0, text.IndexOf('>') + 1);
                text = text.Remove(0, text.IndexOf('>') + 1);

            }

            builder.Append(text);
            return builder;
        }
    }
}
