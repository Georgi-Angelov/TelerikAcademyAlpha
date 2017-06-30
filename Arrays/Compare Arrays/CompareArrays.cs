using System;

namespace Compare_Arrays
{
    class CompareArrays
    {
        static void Main(string[] args)
        {

            var s1 = Console.ReadLine();
            var s2 = Console.ReadLine();

            for (int i = 0; i < Math.Min(s1.Length, s2.Length); i++)
            {
                if (s1[i] < s2[i])
                {
                    Console.WriteLine("<", s1, s2);
                    return;
                }
                if (s1[i] > s2[i])
                {
                    Console.WriteLine(">", s1, s2);
                    return;
                }
            }
            if (s1.Length == s2.Length)
            {
                Console.WriteLine("=");
            }
            else
            {
                Console.WriteLine(s1.Length < s2.Length ? "<" : ">");
            }
        }
    }
}
