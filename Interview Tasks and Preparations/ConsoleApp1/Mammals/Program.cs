using System;

namespace Mammals
{
    public abstract class Mammal
    {
        private void Eat()
        {
            Console.WriteLine("The Mammal is eating");
        }
        public static void Main(string[] args)
        {

        }
        public int conversion(int n)
        {
            int divisor = -1;
            for (int i = 2; i <= n / 2; i++)
            {
                if (!IsPrimeNumber(i) && n % i == 0)
                {

                    divisor = i;

                }
            }

            return divisor;
        }
        public bool IsPrimeNumber(int number)
        {
            for (int i = 2; i <= number / 2; i++)
            {
                if (number % i == 0)
                {
                    return true;
                }
            }

            return false;
        }
    }
    public class Whale : Mammal
    {
        protected void Eat()
        {
            Console.WriteLine("The whale is eating");
        }
    }
}
