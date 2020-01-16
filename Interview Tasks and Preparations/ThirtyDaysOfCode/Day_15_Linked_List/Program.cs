using System;

namespace Day_15_Linked_List
{
   public class Node
    {
        public int data;
        public Node next;
        public Node(int d)
        {
            data = d;
            next = null;
        } 
        
        public Node(int newData, Node newNode)
        {
            data = newData;
            next = newNode;
        }

        public int GetData()
        {
            return data;
        }

        public Node GetNext()
        {
            return next;
        }

        public void SetData(int newData)
        {
            data = newData;
        }

        public void SetNext(Node newNode)
        {
            next = newNode;
        }
    }
    class Program
    {
        public static Node Insert(Node head, int data)
        {
            //Complete this method
           
            if (head == null)
            {
                head = new Node(data);

                return head;
            }

            Node temp = new Node(data);
            Node current = head;

            while (current.next != null)
            {
                current = current.next;
            }
            current.next = temp;

            return head;
        }

        public static void Display(Node head)
        {
            Node start = head;
            while (start != null)
            {
                Console.Write(start.data + " ");
                start = start.next;
            }
        }
        static void Main(string[] args)
        {
            Node head = null;
            int T = Int32.Parse(Console.ReadLine());
            while (T-- > 0)
            {
                int data = Int32.Parse(Console.ReadLine());
                head = Insert(head, data);
            }
            Display(head);
        }
    }
}
