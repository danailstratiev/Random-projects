using System;
using System.Linq;

namespace Day_29_Bitwise_AND
{
    class Program
    {
        static void Main(string[] args)
        {
            int t = Convert.ToInt32(Console.ReadLine());

            for (int tItr = 0; tItr < t; tItr++)
            {
                string[] nk = Console.ReadLine().Split(' ');

                int n = Convert.ToInt32(nk[0]);

                int k = Convert.ToInt32(nk[1]);

                var j = 0;

               
                for (int i = 1; i <= n; i++)
                {
                    

                    for (int m = 1; m <= n; m++)
                    {
                        var d = i & m;
                        if (d > j && d < k && i < m)
                        {
                            j = d;
                        }
                    }         
                }

                Console.WriteLine(j);
            }
        }
    }
}
