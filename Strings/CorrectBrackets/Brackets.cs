using System;

namespace CorrectBrackets
{
    class Brackets
    {
        static void Main(string[] args)
        {
            string expression = Console.ReadLine();
            string result = BracketsEvaluation(expression);
            Console.WriteLine(result);
        }

        private static string BracketsEvaluation(string expression)
        {
            int closingBracket = 0;
            int openingBracket = 0;
            for (int i = 0; i < expression.Length; i++)
            {
                if (expression[i] == '(')
                {
                    openingBracket++;
                }
                else if (expression[i] == ')')
                {
                    closingBracket++;
                }
            }
            string result = openingBracket == closingBracket ? "Correct" : "Incorrect";
            return result;
        }
    }
}
