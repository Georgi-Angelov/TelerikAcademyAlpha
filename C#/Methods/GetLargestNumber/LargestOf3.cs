using System;
using System.Linq;

namespace GetLargestNumber
{
    class LargestOf3
    {
        static void Main(string[] args)
        {
            var numbers = Console.ReadLine().Split(' ').ToArray();
            int firstNumber = int.Parse(numbers[0]) ;
            int secondNumber = int.Parse(numbers[1]) ;
            int thirdNumber = int.Parse(numbers[2]) ;

            int largestOf2 = GetMax(firstNumber, secondNumber);
            int largestOf3 = GetMax(largestOf2, thirdNumber);
            Console.WriteLine(largestOf3);
        }

        private static int GetMax(int firstNumber, int secondNumber)
        {
            int greaterNumber = 0;

            if (firstNumber >= secondNumber)
            {
                greaterNumber = firstNumber;
            }
            else
            {
                greaterNumber = secondNumber;
            }

            return greaterNumber;
        }
    }
}
