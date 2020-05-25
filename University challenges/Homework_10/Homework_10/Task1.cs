using System;

namespace Homework_10
{
    class Task1
    {
        static void Main(string[] args)
        {
            var random = new Random();
            int rows = 5;
            int columns = 5;
            var matrix = new int[rows, columns];

            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j <= i; j++)
                {
                    matrix[i, j] = random.Next(10, 100);
                }
            }

            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < columns; j++)
                {
                    Console.Write(matrix[i, j]);
                }
                Console.WriteLine();
            }

            int sum = int.MinValue;

            for (int i = 0; i < rows; i++)
            {
                int rowSum = 0;

                for (int j = 0; j <= i; j++)
                {
                    rowSum += matrix[i, j];

                }
                Console.WriteLine(rowSum);

                if (rowSum > sum)
                {
                    sum = rowSum;
                }
            }

            Console.WriteLine(sum);
        }
    }
}
