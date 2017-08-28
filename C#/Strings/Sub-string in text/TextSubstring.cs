using System;

namespace Sub_string_in_text
{
    class TextSubstring
    {
        static void Main(string[] args)
        {
            string pattern = Console.ReadLine().ToLower();
            string textToCheck = Console.ReadLine().ToLower();
            int numberOfOccurrences = FindOccurrences(pattern, textToCheck);
            Console.WriteLine(numberOfOccurrences);
        }
        private static int FindOccurrences(string pattern, string textToCheck)
        {
            int startIndex = 0;
            int numberOfOccurrences = 0;
            while ((startIndex = textToCheck.IndexOf(pattern, startIndex, StringComparison.CurrentCultureIgnoreCase)) != -1)
            {
                numberOfOccurrences++;
                startIndex++;
            }

            return numberOfOccurrences;
        }
    }
}
