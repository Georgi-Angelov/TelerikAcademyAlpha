using System;

namespace Compare_Arrays
{
    class CompareArrays
    {
        static void Main(string[] args)
        {

            var firstString = Console.ReadLine();
            var secondString = Console.ReadLine();

            for (int i = 0; i < Math.Min(firstString.Length, secondString.Length); i++)
            {
                if (firstString[i] < secondString[i])
                {
                    Console.WriteLine("<", firstString, secondString);
                    return;
                }
                if (firstString[i] > secondString[i])
                {
                    Console.WriteLine(">", firstString, secondString);
                    return;
                }
            }
            if (firstString.Length == secondString.Length)
            {
                Console.WriteLine("=");
            }
            else
            {
                Console.WriteLine(firstString.Length < secondString.Length ? "<" : ">");
            }
        }
    }
}
