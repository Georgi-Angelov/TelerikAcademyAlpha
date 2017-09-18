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
            List<Food> foods = new List<Food>();

            for (int i = 0; i < itemsCount; i++)
            {
                var inputParams = Console.ReadLine().Split().ToArray();
                Food food = new Food(inputParams[0], int.Parse(inputParams[1]), int.Parse(inputParams[2]));
                foods.Add(food);
            }
            
            var knapsackArray = Knapsack(capacity, itemsCount, foods);
            var result = GetElements(knapsackArray, foods);

            //PrintMatrix(capacity, itemsCount, K);

            Console.WriteLine(knapsackArray[knapsackArray.GetLength(0) - 1, knapsackArray.GetLength(1) - 1]);
            Console.WriteLine(string.Join("\n", result));
        }
        //Knapsack algorithm
        private static int[,] Knapsack(int capacity, int itemsCount, List<Food> foods)
        {
            var K = new int[itemsCount + 1, capacity + 1];
            for (int i = 0; i <= itemsCount; ++i)
            {
                for (int j = 0; j <= capacity; ++j)
                {
                    if (i == 0 || j == 0)
                    {
                        K[i, j] = 0;
                    }
                    else if (foods[i - 1].Weight <= j)
                    {
                        K[i, j] = Math.Max(foods[i - 1].Value + K[i - 1, j - foods[i - 1].Weight], K[i - 1, j]);
                    }
                    else
                    {
                        K[i, j] = K[i - 1, j];
                    }
                }
            }
            return K;
        }
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

        public static HashSet<Food> GetElements(int[,] knapsackArray, List<Food> foods)
        {
            var res = new HashSet<Food>();

            for (int col = knapsackArray.GetLength(1) - 1; col > 0; col--)
            {
                for (int rol = knapsackArray.GetLength(0) - 1; rol > 0; rol--)
                {

                    if (knapsackArray[rol, col] == knapsackArray[rol - 1, col])
                    {
                        continue;
                    }
                    else if (knapsackArray[rol, col] == 0)
                    {
                        return res;
                    }
                    else
                    {
                        res.Add(foods[rol - 1]);
                        col -= foods[rol - 1].Weight;
                    }
                }
            }
            return res;
        }
        public class Food
        {
            public Food(string description, int weight, int value)
            {
                Description = description;
                Weight = weight;
                Value = value;
            }

            public string Description { get; set; }
            public int Weight { get; set; }
            public int Value { get; set; }
            public override string ToString()
            {
                return this.Description;
            }
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



    }
}
