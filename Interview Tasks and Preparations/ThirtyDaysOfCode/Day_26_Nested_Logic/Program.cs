using System;
using System.Linq;
using System.Collections.Generic;


namespace Day_26_Nested_Logic
{
    class Program
    {
        static void Main(string[] args)
        {
            var realDates = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            var expectedDates = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();

            var realDay = realDates[0];
            var realMonth = realDates[1];
            var realYear = realDates[2];

            var expectedDay = expectedDates[0];
            var expectedMonth = expectedDates[1];
            var expectedYear = expectedDates[2];

            var fine = 0;

            if (realYear < expectedYear || realMonth <= expectedMonth && realYear <= expectedYear && realDay <= expectedDay)
            {
                fine = 0;
            }
            else if (realMonth == expectedMonth && realYear == expectedYear && realDay > expectedDay)
            {
                fine = 15 * (realDay - expectedDay);
            }
            else if (realMonth > expectedMonth && realYear == expectedYear)
            {
                fine = 500 * (realMonth - expectedMonth);
            }
            else
            {
                fine = 10000;
            }

            Console.WriteLine(fine);
        }
    }
}
