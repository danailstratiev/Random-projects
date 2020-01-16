using System;
using System.Collections.Generic;
using System.Text;

namespace Day_15_Linked_List
{
   public class LinkedList
    {
        Node head;
        int count;

        public LinkedList()
        {
            head = null;
            count = 0;
        }

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
        }
    }

}
