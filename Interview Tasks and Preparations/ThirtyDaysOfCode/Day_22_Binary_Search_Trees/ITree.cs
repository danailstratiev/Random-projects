using System;
using System.Collections.Generic;
using System.Text;

namespace Day_22_Binary_Search_Trees
{
    public interface ITree<T> : IComparable
    {
        public bool IsEmpty();

        public int Cardinality();

        public bool Member(T elt);

        public NonEmptyBST<T> Add(T elt); 
    }
}
