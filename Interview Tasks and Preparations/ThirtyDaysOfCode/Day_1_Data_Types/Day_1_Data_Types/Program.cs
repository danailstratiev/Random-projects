using System;

namespace Day_1_Data_Types
{
    class Program
    {
        static void Main(string[] args)
        {
            int i = 4;
            double d = 4.0;
            string s = "HackerRank ";


            // Declare second integer, double, and String variables.

            // Read and save an integer, double, and String to your variables.

            // Print the sum of both integer variables on a new line.

            // Print the sum of the double variables on a new line.

            // Concatenate and print the String variables on a new line
            // The 's' variable above should be printed first.

            int j = int.Parse(Console.ReadLine());
            double f = double.Parse(Console.ReadLine());
            string t = Console.ReadLine();

            Console.WriteLine(i+j);
            Console.WriteLine($"{d+f:F1}");
            Console.WriteLine(s+t);
        }
    }
}
