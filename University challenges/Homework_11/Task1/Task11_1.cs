using System;

namespace Task1
{
    class Program
    {
        static void Main(string[] args)
        {
            Worker[] workers = new Worker[4];
            double salarySum = 0;

            for (int i = 0; i < 4; i++)
            {
                Worker worker = new Worker();
                worker.Name = Console.ReadLine();
                worker.WorkPosition = Console.ReadLine();
                worker.Salary = double.Parse(Console.ReadLine());
                salarySum += worker.Salary;
            }

            Console.WriteLine(salarySum/4);
        }
    }

    public class Worker
    {
        public string Name { get; set; }

        public string WorkPosition { get; set; }

        public double Salary { get; set; }
    }
}
