using System;

namespace TextInput
{
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

    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }
    }
}
