using System;
using System.IO;

namespace Day_9_Recursion_3
{
    class Program
    {
        // Complete the factorial function below.
        static int factorial(int n)
        {
            var m = 1;

            for (int i = 1; i <= n; i++)
            {
                m *= i;
            }

            return m;
        }

        static void Main(string[] args)
        {
            TextWriter textWriter = new StreamWriter(@System.Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);

            int n = Convert.ToInt32(Console.ReadLine());

            int result = factorial(n);

            textWriter.WriteLine(result);

            textWriter.Flush();
            textWriter.Close();
        }
    }
}
