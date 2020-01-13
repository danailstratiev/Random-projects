using System;
using System.Linq;

namespace Day_12_Inheritance
{
    class Person
    {
        protected string firstName;
        protected string lastName;
        protected int id;

        public Person() { }
        public Person(string firstName, string lastName, int identification)
        {
            this.firstName = firstName;
            this.lastName = lastName;
            this.id = identification;
        }
        public void printPerson()
        {
            Console.WriteLine("Name: " + lastName + ", " + firstName + "\nID: " + id);
        }
    }

    class Student : Person
    {
        private int[] testScores;

        /*	
        *   Class Constructor
        *   
        *   Parameters: 
        *   firstName - A string denoting the Person's first name.
        *   lastName - A string denoting the Person's last name.
        *   id - An integer denoting the Person's ID number.
        *   scores - An array of integers denoting the Person's test scores.
        */
        // Write your constructor here

        public Student(string firstName, string lastName, int id, int[] scores) 
            :base(firstName, lastName, id) 
        {
            this.testScores = scores;
        }

        /*	
        *   Method Name: Calculate
        *   Return: A character denoting the grade.
        */
        // Write your method here

        public char Calculate()
        {
            var grade = ' ';
            var averageGrade = this.testScores.Average();

            if (averageGrade >= 90 && averageGrade <= 100)
            {
                grade = 'O';
            }
            else if (averageGrade >= 80 && averageGrade < 90)
            {
                grade = 'E';
            }
            else if (averageGrade >= 70 && averageGrade < 80)
            {
                grade = 'A';

            }
            else if (averageGrade >= 55 && averageGrade < 70)
            {
                grade = 'P';
            }
            else if (averageGrade >= 40 && averageGrade < 55)
            {
                grade = 'D';
            }
            else if (averageGrade < 40)
            {
                grade = 'T';
            }
            return grade;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            string[] inputs = Console.ReadLine().Split();
            string firstName = inputs[0];
            string lastName = inputs[1];
            int id = Convert.ToInt32(inputs[2]);
            int numScores = Convert.ToInt32(Console.ReadLine());
            inputs = Console.ReadLine().Split();
            int[] scores = new int[numScores];
            for (int i = 0; i < numScores; i++)
            {
                scores[i] = Convert.ToInt32(inputs[i]);
            }

            Student s = new Student(firstName, lastName, id, scores);
            s.printPerson();
            Console.WriteLine("Grade: " + s.Calculate() + "\n");
        }
    }
}
