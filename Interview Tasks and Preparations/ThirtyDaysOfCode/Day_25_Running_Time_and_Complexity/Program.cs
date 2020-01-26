using System;

namespace Day_25_Running_Time_and_Complexity
{
    class Program
    {
        static void Main(string[] args)
        {
            var m = int.Parse(Console.ReadLine());

            for (int j = 0; j < m; j++)
            {
                var n = int.Parse(Console.ReadLine());
                var isPrime = true;

                if (n < 2)
                {
                    Console.WriteLine("Not prime");
                    continue;
                }
                for (int i = 2; i <= Math.Sqrt(n); i++)
                {
                    if (n % i == 0)
                    {
                        Console.WriteLine("Not prime");
                        isPrime = false;
                        break;
                    }
                }

                if (isPrime)
                {
                    Console.WriteLine("Prime");
                }
            }
        }
    }
}
