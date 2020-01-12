using System;
using System.Linq;
using System.Collections.Generic;

namespace Day_11_2DArrays
{
    class Program
    {
        static void Main(string[] args)
        {
            int[][] arr = new int[6][];

            for (int i = 0; i < 6; i++)
            {
                arr[i] = Array.ConvertAll(Console.ReadLine().Split(' '), arrTemp => Convert.ToInt32(arrTemp));
            }

            var maxSum = int.MinValue;

            for (int i = 0; i < 4; i++)
            {
                for (int j = 0; j < arr[i].Length; j++)
                {
                    var currentGlassSum = 0;
                    var glassTopStart = j;
                    var glassEnd = j + 2;

                    if (glassEnd >= 6)
                    {
                        break;
                    }

                    var glassBottomStart = i + 2;

                    if (glassBottomStart >= 6)
                    {
                        break;
                    }

                    var glassMiddle = arr[i + 1][j + 1];

                    for (int k = glassTopStart; k <= glassEnd; k++)
                    {
                        currentGlassSum += arr[i][k];
                        currentGlassSum += arr[glassBottomStart][k];
                    }
                    
                    currentGlassSum += glassMiddle;

                    if (currentGlassSum > maxSum)
                    {
                        maxSum = currentGlassSum;
                    }
                }
            }

            Console.WriteLine(maxSum);
        }
    }
}
