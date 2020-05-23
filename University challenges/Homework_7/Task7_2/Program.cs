using System;

namespace Task7_2
{
    class Program
    {
        static void Main(string[] args)
        {
            int size = int.Parse(Console.ReadLine());
            int[] numbers = new int[size];
            Random random = new Random();

            for (int i = 0; i < size; i++)
            {
                numbers[i] = random.Next(2, 6);
            }

            Console.WriteLine(string.Join(", ", numbers));

            int s_first = 0;
            int s_second = 0;

            for (int i = 0; i < numbers.Length/2; i++)
            {
                s_first += numbers[i];
            }

            for (int i = numbers.Length / 2; i < numbers.Length; i++)
            {
                s_second += numbers[i];
            }

            if (numbers.Length % 2 != 0)
            {
                s_first += numbers[numbers.Length / 2];
                s_second += numbers[numbers.Length / 2];
            }

            if (s_first > s_second)
            {
                Console.WriteLine(s_first);
            }
            else
            {
                Console.WriteLine(s_second);
            }
        }
    }
}
