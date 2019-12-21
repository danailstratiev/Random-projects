using System;
using System.Linq;
using System.Collections.Generic;
using System.IO;

namespace ConsoleApp1
{
    public class Answer
    {
        /// Executes the service with the given​​​​​​‌​​​‌​‌​​​‌‌‌​‌‌‌‌‌‌​​​‌‌ connection.
        public void Run(Service s, Connection c)
        {
            s.SetConnection(c);
            try
            {
                s.Execute();

            }
            catch (Exception)
            {

                c.Rollback();
            }
            finally
            {
                c.Commit();
            }
        }
    }

    /// Definition of a service
    public interface Service
    {
        void Execute();
        void SetConnection(Connection c);
    }

    /// Definition of a connection
    public interface Connection
    {
        void Commit();
        void Rollback();
        void Close();
    }
    class A
    {
    }

    /// class B
    class B : A
    {
    }
    class StartUp
    {
        static void Main(string[] args)
        {

            //var name = Console.ReadLine();
            //Console.WriteLine($"Hello, {name} ! ");
            //var a = int.Parse(Console.ReadLine());
            //var b = int.Parse(Console.ReadLine());
            //var result = a + b;
            //var i = 0;

            //Console.WriteLine(i++);

            string fileName = "myfile.ext";
            string path1 = @"mydir";
            //string path2 = @"\mydir";
            //string fullPath;

            var fullPath = Path.GetFullPath(path1);

            //GetWordFromText("one two three", 2);

            //Reverse("one");

            //TextInput input = new NumericInput();
            //input.Add('1');
            //input.Add('a');
            //input.Add('0');
            //Console.WriteLine(input.GetValue());

        }
        public class TextInput
        {
            public TextInput()
            {
                this.Input = string.Empty;
            }

            public string Input { get; set; }

            public virtual void Add(char c)
            {
                this.Input = this.Input + c;
            }

            public string GetValue()
            {
                return this.Input;
            }
        }

        public class NumericInput : TextInput
        {
            public override void Add(char c)
            {
                if (char.IsDigit(c))
                {
                    this.Input = this.Input + c;
                }

            }
        }

        public static bool Test(int i, int j)
        {
            if (i == 1 || j == 1)
            {
                return true;
            }
            else if (i + j == 1)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public static int Calc(int[] array, int n1, int n2)
        {
            var sum = 0;

            for (int i = n1; i <= n2; i++)
            {
                sum += array[i];
            }
            return sum;
        }
        public static string LocateUniverseFormula()
        {
            string newPath = Path.Combine(@"/tmp/documents", "universe-formula");
            var fullPath = new FileInfo("universe-formula").Directory.FullName;

            if (fullPath != string.Empty)
            {
                return fullPath;

            }
            else
            {
                return null;
            }
        }

        public static int FindLargest(int[] numbers)
        {
            return numbers.Max();
        }

        public static string[] UniqueNames(string[] names1, string[] names2)
        {
            var uniques = new List<string>();
            uniques.AddRange(names1);
            uniques.AddRange(names2);
            var names = uniques.Distinct().ToArray();

            return names;
        }

        public static string Print(string text)
        {
            return text;
        }

        private static string Reverse(string word)
        {
            var wordChars = word.ToCharArray().Reverse();

            if (word == string.Empty)
            {
                return string.Empty;
            }

            return wordChars.ToString();
        }

        private static string GetWordFromText(string input, int wordNumberToFind)
        {
            var wordNumbers = new Dictionary<int, string>
            {
                {1, "one" },
                {2, "two" },
                {3, "three" },
                {4, "four" },
                {5, "five" },
                {6, "six" },
                {7, "seven" },
                {8, "eight" },
                {9, "nine" }

            };

            var output = string.Empty;

            if (wordNumberToFind < 1)
            {
                throw new ArgumentOutOfRangeException();
            }
            if (input == null)
            {
                throw new ArgumentException();
            }

            var kvp = wordNumbers.Where(x => x.Key == wordNumberToFind).FirstOrDefault();

            var words = input.Split(" ").ToList();

            var foundWord = words.FirstOrDefault(x => x == kvp.Value);

            if (foundWord == string.Empty || foundWord == null)
            {
                throw new ArgumentNullException();
            }

            return foundWord;
        }

        public static bool FindTheNUmber(int[] arr, int n)
        {

            if (arr.Contains(n))
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public static List<int> OddNumbers(int l, int r)
        {
            var oddNums = new List<int>();

            for (int i = l; i <= r; i++)
            {
                if (i % 2 != 0)
                {
                    oddNums.Add(i);
                }
            }


            return oddNums;
        }

        public static bool Exists(int[] ints, int k)
        {
            return ints.Contains(k);
        }
    }
}
