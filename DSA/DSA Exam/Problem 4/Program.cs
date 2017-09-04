using System;
using System.Collections.Generic;
using System.Linq;

namespace KnapsackAlgo
{

    class KnapsackAlgorithm
    {

        private int[,] picks = new int[20, 20];

        static void Main(string[] args)
        {


            int capacity = int.Parse(Console.ReadLine());
            int itemsCount = int.Parse(Console.ReadLine());
            Food[] foods = new Food[itemsCount];

            for (int i = 0; i < itemsCount; i++)
            {
                string[] inputParams = Console.ReadLine().Split().ToArray();
                foods[i] = new Food(inputParams[0], int.Parse(inputParams[1]), int.Parse(inputParams[2]));
            }


            //Knapsack algorithm
            int[,] K = new int[itemsCount + 1, capacity + 1];

            for (int i = 0; i <= itemsCount; ++i)
            {
                for (int w = 0; w <= capacity; ++w)
                {
                    if (i == 0 || w == 0)
                    {
                        K[i, w] = 0;
                    }
                    else if (foods[i - 1].Weight <= w)
                    {
                        K[i, w] = Math.Max(foods[i - 1].Value + K[i - 1, w - foods[i - 1].Weight], K[i - 1, w]);
                    }
                    else
                    {
                        K[i, w] = K[i - 1, w];
                    }
                }
            }
            int result = K[itemsCount, capacity];

            PrintMatrix(capacity, itemsCount, K);

            Console.WriteLine(result);
        }
        //int result = Knapsack(itemsCount - 1, capacity, foods);
            //Console.WriteLine(result);
            //}
            //public static int Knapsack(int itemsCount, int capacity, Food[] foods)
            //{

            //    int[,] K = new int[itemsCount + 1, capacity + 1];
            //    int[,] picks = new int[itemsCount + 1,capacity + 1];
            //    int take = 0;
            //    int dontTake = 0;

            //    if (K[itemsCount, capacity] != 0)
            //    {
            //        return K[itemsCount,capacity];
            //    }

            //    if (itemsCount == 0)
            //    {
            //        if (foods[0].Weight <= capacity)
            //        {
            //            picks[itemsCount,capacity] = 1;
            //            K[itemsCount,capacity] = foods[0].Value;
            //            return foods[0].Value;
            //        }
            //        else
            //        {
            //            picks[itemsCount,capacity] = -1;
            //            K[itemsCount,capacity] = 0;
            //            return 0;
            //        }
            //    }

            //    if (foods[itemsCount].Weight <= capacity)
            //        take = foods[itemsCount].Weight + Knapsack(itemsCount - 1, capacity - foods[itemsCount].Weight, foods);

            //    dontTake = Knapsack(itemsCount - 1, capacity, foods);

            //    K[itemsCount,capacity] = Math.Max(take, dontTake);

            //    if (take > dontTake)
            //        picks[itemsCount,capacity] = 1;
            //    else
            //        picks[itemsCount,capacity] = -1;

            //    return K[itemsCount,capacity];

            //}

            //public void printPicks(int item, int size, Food[] foods)
            //{

            //    while (item >= 0)
            //    {
            //        if (picks[item,size] == 1)
            //        {
            //            Console.WriteLine(item);
            //            item--;
            //            size -= foods[item].Weight;
            //        }
            //        else
            //        {
            //            item--;
            //        }
            //    }



            //    return;
            //}
        private static void PrintMatrix(int capacity, int itemsCount, int[,] K)
        {
            for (int i = 0; i <= itemsCount; i++)
            {
                for (int w = 0; w < capacity; w++)
                {
                    Console.Write(K[i, w] + " ");
                }
                Console.WriteLine();
            }
        }

        public class Food
        {

            private string description;
            private int weight;
            private int value;

            public Food(string description, int weight, int value)
            {
                Description = description;
                Weight = weight;
                Value = value;
            }

            public string Description { get; set; }
            public int Weight { get; set; }
            public int Value { get; set; }

        }
    }
}
