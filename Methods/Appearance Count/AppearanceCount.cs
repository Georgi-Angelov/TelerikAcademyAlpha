using System;
using System.Linq;

namespace Appearance_Count
{
    class AppearanceCount
    {
        static void Main(string[] args)
        {
            int arraySize = int.Parse(Console.ReadLine());
            var numbers = Console.ReadLine().Split(' ').ToArray();
            int searchedNumber = int.Parse(Console.ReadLine());

            Console.WriteLine(NumberCount(numbers, searchedNumber));
        }

        private static int NumberCount(string[] numbers, int searchedNumber)
        {
            int count = 0;
            foreach (var number in numbers)
            {
                if (int.Parse(number) == searchedNumber)
                {
                    count++;
                }
            }
            return count;
        }
    }
}
