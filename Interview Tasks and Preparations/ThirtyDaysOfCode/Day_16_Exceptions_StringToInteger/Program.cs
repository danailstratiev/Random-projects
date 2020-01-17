using System;

namespace Day_16_Exceptions_StringToInteger
{
    class Program
    {
        static void Main(string[] args)
        {
            string S = Console.ReadLine();

            try
            {
                Console.WriteLine(int.Parse(S));
            }
            catch (Exception)
            {
                Console.WriteLine("Bad String");                
            }
        }
    }
}
