using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Collections;
using System.ComponentModel;
using System.Diagnostics.CodeAnalysis;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Runtime.Serialization;
using System.Text.RegularExpressions;
using System.Text;

namespace Day_28_RegEx_Patterns_and_Intro_to_Databases
{
    class Program
    {
        static void Main(string[] args)
        {
            int N = Convert.ToInt32(Console.ReadLine());
            var names = new List<string>();

            for (int NItr = 0; NItr < N; NItr++)
            {
                string[] firstNameEmailID = Console.ReadLine().Split(' ');

                string firstName = firstNameEmailID[0];

                string emailID = firstNameEmailID[1];

                var pattern = @"[a-z]+@gmail.com";

                if (Regex.IsMatch(emailID, pattern))
                {
                    names.Add(firstName);
                }
            }

            names.Sort();

            Console.WriteLine(string.Join(Environment.NewLine, names));
        }
    }
}
