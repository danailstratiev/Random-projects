using System;
using System.Linq;
using System.Collections.Generic;

namespace Day_8_Dictionaries_and_Maps
{
    class Program
    {
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());
            var phoneBook = new Dictionary<string, string>();

            for (int i = 0; i < n; i++)
            {
                var kvp = Console.ReadLine().Split(" ");
                var name = kvp[0];

                if (kvp[1].Length == 8)
                {
                    phoneBook[name] = kvp[1];
                }
            }

            while (true)
            {
                var randomContact = Console.ReadLine();

                if (randomContact == null || randomContact == string.Empty)
                {
                    break;
                }
                var foundContact = phoneBook.FirstOrDefault(x => x.Key == randomContact);


                if (foundContact.Key == null)
                {
                    Console.WriteLine("Not found");
                }
                else
                {
                    Console.WriteLine($"{foundContact.Key}={foundContact.Value}");
                }
            }
        }
    }
}
