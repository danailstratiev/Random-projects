using System;
using System.Collections.Generic;
using System.Text;

namespace Day_15_Linked_List
{
   public class LinkedList
    {
        Node head;
        int count;

        //public LinkedList()
        //{
        //    head = null;
        //    count = 0;
        //}

        public LinkedList(Node newHead)
        {
            head = newHead;
            count = 1;
        }

        public void Add(int newData)
        {
            Node temp = new Node(newData);
            Node current = head;

            while (current.GetNext() != null)
            {
                current = current.GetNext();
            }
            current.SetNext(temp);
            count++;
        }

        public int Get(int index)
        {
            if (index <= 0)
            {
                return -1;
            }

            Node current = head;

            for (int i = 1; i < index; i++)
            {
                current = current.GetNext();
            }

            return current.GetData();
        }

        public int Size()
        {
            return count;
        }

        public bool IsEmpty()
        {
            return this.head == null;
        }

        public void Remove()
        {
            Node current = head;

            while (current.GetNext().GetNext() != null)
            {
                current = current.GetNext();
            }
            current.SetNext(null);
            count--;
        }
    }

}
