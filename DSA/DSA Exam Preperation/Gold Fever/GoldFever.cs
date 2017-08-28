using System;
using System.Linq;

namespace Gold_Fever
{
    public class GoldFever
        {
            static void Main()
            {
                int numberOfDays = int.Parse(Console.ReadLine());
                int[] values = Console.ReadLine()
                                      .Split()
                                      .Select(int.Parse)
                                      .ToArray();

                long profit = 0;
                int currentBiggest = values[numberOfDays - 1];

                for (int i = numberOfDays - 1; i > 0; i--)
                {
                    if (currentBiggest >= values[i - 1])
                    {
                        profit += currentBiggest - values[i - 1];
                    }
                    else
                    {
                        currentBiggest = values[i - 1];
                    }
                }

                Console.WriteLine(profit);
            
            // O(n^2)

            //long invested = 0;
            //int unitsOfGold = 0;
            //while (i < numberOfDays) 
            //{
            //    var currentValues = values.Skip(i);
            //    int maxValue = currentValues.Max();
            //    int maxIndex = currentValues.ToList().IndexOf(maxValue);
            //    i += maxIndex + 1;
            //    int innerMax = maxIndex;
            //    while (innerMax > 0)
            //    {
            //        invested += currentValues.ToArray()[innerMax - 1];
            //        unitsOfGold++;
            //        innerMax--;
            //        if (innerMax == 0)
            //        {
            //            profit += unitsOfGold * maxValue - invested;
            //            invested = 0;
            //            unitsOfGold = 0;
            //        }
            //    }
            //}

        }

    }
    }
