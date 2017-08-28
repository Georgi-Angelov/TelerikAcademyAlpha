using System;


namespace MaximumSequence
{
    class MaxSequence
    {
        static void Main(string[] args)
        {
            int arraySize = int.Parse(Console.ReadLine());
            int[] array = new int[arraySize];

            ReadArray(array);
            
            Console.WriteLine(BiggestSequence(array, arraySize));
        }

        private static int BiggestSequence(int[] array, int arraySize)
        {
            int count = 1;
            int maxCount = 0;
            for (int i = 0; i < arraySize - 1; i++)
            {
                if (array[i] == array[i + 1])
                {
                    count++;
                }
                else if (array[i] != array[i + 1])
                {
                    count = 1;
                }
                if (maxCount < count)
                {
                    maxCount = count;
                }

            }
            return maxCount;
        }

        private static void ReadArray(int[] array)
        {
            for (int i = 0; i < array.Length; i++)
            {
                array[i] = int.Parse(Console.ReadLine());
            }
        }
        
    }
}
