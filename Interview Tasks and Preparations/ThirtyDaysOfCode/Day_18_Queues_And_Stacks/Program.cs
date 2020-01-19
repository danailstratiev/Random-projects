using System;
using System.Collections.Generic;

namespace Day_18_Queues_And_Stacks
{
    class Solution
    {
        //Write your code here

        public Solution()
        {
            this.CharQueue = new Queue<char>();
            this.CharStack = new Stack<char>();
        }

        public Queue<char> CharQueue { get; set; }

        public Stack<char> CharStack { get; set; }

        public void PushCharacter (char c)
        {
            this.CharStack.Push(c);
        }

        public void EnqueueCharacter (char c)
        {
            this.CharQueue.Enqueue(c);
        }

        public char PopCharacter()
        {
            return this.CharStack.Pop();
        }

        public char DequeueCharacter()
        {
            return this.CharQueue.Dequeue();
        }
    }

        class Program
    {
        static void Main(string[] args)
        {

        }
    }
}
