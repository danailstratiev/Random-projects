using System;

namespace Task7_1
{
    class Program
    {
        static void Main(string[] args)
        {
            int productCount = int.Parse(Console.ReadLine());
            double[] prices = new double[productCount];

            for (int i = 0; i < productCount; i++)
            {
                prices[i] = double.Parse(Console.ReadLine());
            }

            int discount_count = 0;

            for (int i = 0; i < productCount; i++)
            {
                if (prices[i] > 10)
                {
                    prices[i] *= 0.95;
                    discount_count++;
                }
            }

            Console.WriteLine(string.Join(", ", prices));
            Console.WriteLine(discount_count);
        }
    }
}
