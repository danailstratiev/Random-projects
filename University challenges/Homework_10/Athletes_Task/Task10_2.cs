using System;

namespace Athletes_Task
{
    class Task10_2
    {
        static void Main(string[] args)
        {
            int athletes = 5;
            int tries = 5;
            var matrix = new double[athletes, tries];
            var random = new Random();

            double max_result = 0;
            int idx_athlete = -1;
            int idx_attempt = -1;

            for (int i = 0; i < athletes; i++)
            {
                for (int j = 0; j <= tries; j++)
                {
                    matrix[i, j] = random.Next(10, 50);
                    if (matrix[i, j] > max_result)
                    {
                        max_result = matrix[i, j];
                        idx_athlete = i;
                        idx_attempt = j;
                    }
                }
            }

            Console.WriteLine($"Winner is:{idx_athlete} with attempt:{idx_attempt} and result:{max_result}");
        }
    }
}
