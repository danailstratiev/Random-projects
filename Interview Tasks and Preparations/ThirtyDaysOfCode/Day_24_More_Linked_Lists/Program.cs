using System;

namespace Day_24_More_Linked_Lists
{
    class Node
    {
        public int data;
        public Node next;
        public Node(int d)
        {
            data = d;
            next = null;
        }

    }

    class Program
    {
        public static Node removeDuplicates(Node head)
        {
            //Write your code here
            bool areDuplicatesRemoved = false;

            var nextNode = head.next;

            while (nextNode != null)
            {
                if (nextNode.data != head.data)
                {
                    var current = nextNode.next;

                    if (current == null)
                    {
                        break;
                    }
                    else
                    {
                        if (current.data == nextNode.data)
                        {
                            nextNode.next = current.next;
                            current = null;
                        }
                        else
                        {
                            nextNode = current;
                        }
                    }
                }
                else
                {
                    nextNode = nextNode.next;
                    head.next = nextNode;
                }
            }          

            return head;
        }

        public static Node insert(Node head, int data)
        {
            Node p = new Node(data);


            if (head == null)
                head = p;
            else if (head.next == null)
                head.next = p;
            else
            {
                Node start = head;
                while (start.next != null)
                    start = start.next;
                start.next = p;

            }
            return head;
        }
        public static void display(Node head)
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
                head = insert(head, data);
            }
            head = removeDuplicates(head);
            display(head);
        }
    }
}
