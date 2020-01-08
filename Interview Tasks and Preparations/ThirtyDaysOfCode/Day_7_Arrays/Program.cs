using System;
using System.Linq;

namespace Day_7_Arrays
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = Convert.ToInt32(Console.ReadLine());

            int[] arr = Array.ConvertAll(Console.ReadLine().Split(' '), arrTemp => Convert.ToInt32(arrTemp))
            ;

            Console.WriteLine(string.Join(" ", arr.Reverse().ToArray()));
        }
    }
}
