using System;

namespace Day_6_Lets_Review
{
    class Program
    {
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                var word = Console.ReadLine();
                var miniWordEven = "";
                var miniWordOdd = "";

                for (int j = 0; j < word.Length; j++)
                {
                    if (j % 2 == 0)
                    {
                        miniWordEven += word[j];
                    }
                    else
                    {
                        miniWordOdd += word[j];
                    }
                }

                Console.WriteLine($"{miniWordEven} {miniWordOdd}");
            }
        }
    }
}
