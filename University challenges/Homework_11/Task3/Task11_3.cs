using System;

namespace Task3
{
    class Program
    {
        static void Main(string[] args)
        {
            Note[] notes = new Note[5];

            for (int i = 0; i < 5; i++)
            {
                notes[i] = new Note();
                notes[i].Name = Console.ReadLine();
                notes[i].PhoneNumber = Console.ReadLine();
                notes[i].BirthDate = new int[3];

                for (int j = 0; j < 3; j++)
                {
                    notes[i].BirthDate[j] = int.Parse(Console.ReadLine());
                }
            }

            int birthDate = int.Parse(Console.ReadLine());

            for (int i = 0; i < 5; i++)
            {
                if (notes[i].BirthDate[1] == birthDate)
                {
                    Console.WriteLine($"{notes[i].Name} {notes[i].PhoneNumber}");
                }
            }
        }
    }

    public class Note
    {
        public string Name { get; set; }

        public string PhoneNumber { get; set; }

        public int[] BirthDate { get; set; }
    }
}
