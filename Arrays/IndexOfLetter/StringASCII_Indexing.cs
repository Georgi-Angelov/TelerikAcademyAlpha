using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IndexOfLetter
{
    class StringASCII_Indexing
    {
        static void Main(string[] args)
        {
            string dictionary = "abcdefghijklmnopqrstyuvwxyz" ;
            string input = Console.ReadLine().ToLower();
            for (int i = 0; i < input.Length; i++)
            {
                int j = 0;
                while (j < dictionary.Length)
                {
                    if (input[i] == dictionary[j])
                    {
                        Console.WriteLine(input[i] - 'a');
                        break;
                    }
                    else
                    {
                        j++;
                    }
                }
            }
        }
    }
}
