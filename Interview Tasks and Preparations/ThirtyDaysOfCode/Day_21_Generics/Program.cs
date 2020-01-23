using System;
using System.Linq;
using System.Collections.Generic;

namespace Day_21_Generics
{   
    class Program
    {
        static void Main(string[] args)
        {
            int n = Convert.ToInt32(Console.ReadLine());
            int[] intArray = new int[n];
            for (int i = 0; i < n; i++)
            {
                intArray[i] = Convert.ToInt32(Console.ReadLine());
            }

            n = Convert.ToInt32(Console.ReadLine());
            string[] stringArray = new string[n];
            for (int i = 0; i < n; i++)
            {
                stringArray[i] = Console.ReadLine();
            }
        }

        public static void PrintArray <T> (T[] arr)
        {
            Console.WriteLine(string.Join(Environment.NewLine, arr));
        }
    }
}
