using System;

namespace Documents
{
    class Docs
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            int left = 0;
            if (input == null) return;
            int right = input.Length - 1;
            int result = 0;
            while (left < right)
            {
                char a = input[left] <= 90 && input[left] >= 65 ? (char)(input[left] + 32) : input[left];
                char b = input[right] <= 90 && input[right] >= 65 ? (char)(input[right] + 32) : input[right];
                if (input[left] == '.'
                    || input[left] == ','
                    || input[left] == ' '
                    || input[left] == '!'
                    || input[left] == '?')
                {
                    left++;
                    continue;
                }
                if (input[right] == '.'
                    || input[right] == ','
                    || input[right] == ' '
                    || input[right] == '!'
                    || input[right] == '?')
                {
                    right--;
                    continue;
                }

                if (input[left] == input[right])
                {
                    left++;
                    right--;
                    continue;
                }

                int first = a;
                int second = b;
                int difference = first - second > 0 ? first - second : -(first - second);
                if (difference < 14)
                {
                    result += difference;
                }
                else
                {
                    difference = 26 - difference;
                    result += difference;
                }

                left++;
                right--;

            }
            Console.WriteLine(result);
        }
        

    }
}
