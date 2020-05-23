using System;

namespace Task7_3
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] array1 = new int[10];
            int[] array2 = new int[10];
            Random random = new Random();

            for (int i = 0; i < 10; i++)
            {
                array1[i] = random.Next(2, 6);
            }

            for (int i = 2; i <= 8; i++)
            {
                array2[i] = array1[i - 1] + array1[i + 1];
            }

            array2[0] = array1[0] * 2;

            array2[array2.Length - 1] = array1[array1.Length - 2] * 2;

            Console.WriteLine(string.Join(", ", array1));
            Console.WriteLine(string.Join(", ", array2));
        }
    }
}
