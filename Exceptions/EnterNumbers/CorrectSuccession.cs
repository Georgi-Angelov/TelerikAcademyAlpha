using System;

namespace EnterNumbers
{
    class CorrectSuccession
    {
        static void Main(string[] args)
        {
            try
            {
                int start = 1;
                int end = 100;
                int arraySize = 10;
                string output = ReadNumbers(start, end, arraySize);
                Console.WriteLine(output);// without arraySize in assignment
            }
            catch (FormatException)
            {
                Console.WriteLine("Exception");
            }
            catch (ArgumentOutOfRangeException)
            {
                Console.WriteLine("Exception");
            }
        }

        private static string ReadNumbers(int start, int end, int arraySize)
        {
            int[] array = new int[arraySize];
            string result;
            array[0] = int.Parse(Console.ReadLine());
            if (array[0] < start || array[0] > end)
            {
                throw new ArgumentOutOfRangeException();
            }
            for (int i = 1; i < array.Length; i++)
            {
                array[i] = int.Parse(Console.ReadLine());
                if (array[i - 1] >= array[i] || array[i] < start || array[i] > end )
                {
                    throw new ArgumentOutOfRangeException();
                }
            }
            result = "1 < " + string.Join(" < ", array) + " < 100";

            return result;
        }
    }
}