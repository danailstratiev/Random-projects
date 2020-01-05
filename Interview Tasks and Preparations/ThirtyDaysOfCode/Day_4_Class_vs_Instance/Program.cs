﻿using System;

namespace Day_4_Class_vs_Instance
{
    class Person
    {
        private int age;
        public Person(int initialAge)
        {
            // Add some more code to run some checks on initialAge

            if (initialAge < 0)
            {
                Console.WriteLine("Age is not valid, setting age to 0.");
                this.age = 0;
            }

            age = initialAge;
        }
        public void AmIOld()
        {
            // Do some computations in here and print out the correct statement to the console 
            if (this.age < 13)
            {
                Console.WriteLine("You are young.");
            }
            else if (age >= 13 && age < 18)
            {
                Console.WriteLine("You are a teenager.");
            }
            else
            {
                Console.WriteLine("You are old.");
            }

        }

        public void YearPasses()
        {
            // Increment the age of the person in here
            this.age++;
        }
    }
        class Program
    {
        static void Main(string[] args)
        {
            int t = int.Parse(Console.In.ReadLine());
            for (int i = 0; i < t; i++)
            {
                int age = int.Parse(Console.In.ReadLine());
                Person p = new Person(age);
                p.AmIOld();
                for (int j = 0; j < 3; j++)
                {
                    p.YearPasses();
                }
                p.AmIOld();
                Console.WriteLine();
            }
        }
    }
}
