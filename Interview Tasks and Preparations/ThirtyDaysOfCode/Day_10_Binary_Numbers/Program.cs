using System;
using System.Linq;

namespace Day_10_Binary_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = Convert.ToInt32(Console.ReadLine());
            var binary = Convert.ToString(n, 2);
            var countOfOne = 0;
            var maxSequence = 1;

            foreach (var digit in binary)
            {
                if (digit == '1')
                {
                    countOfOne++;
                    if (countOfOne > maxSequence)
                    {
                        maxSequence = countOfOne;
                    }
                }
                else
                {
                    countOfOne = 0;
                }
            }
            Console.WriteLine(maxSequence);
        }
    }
}
