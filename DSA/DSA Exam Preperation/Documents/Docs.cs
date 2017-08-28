using System;

namespace Documents
{
    class Docs
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            int left = 0;
            int right = input.Length - 1;
            int result = 0;
            while (left < right)
            {
                char a = input[left] <= 90 && input[left] >= 65 ? (char)(input[left] + 32) : input[left];
                char b = input[right] <= 90 && input[right] >= 65 ? (char)(input[right] + 32) : input[right];
                if (!char.IsLetter(a))
                {
                    left++;
                    continue;
                }
                if (!char.IsLetter(b))
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

                int first = (int)(a);
                int second = (int)(b);
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
