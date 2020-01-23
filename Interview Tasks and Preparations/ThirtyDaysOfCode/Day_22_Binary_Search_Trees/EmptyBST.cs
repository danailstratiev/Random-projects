using System;
using System.Collections.Generic;
using System.Text;

namespace Day_22_Binary_Search_Trees
{
    public class EmptyBST<T> :ITree<T>, IComparable
    {
        public EmptyBST()
        {

        }

        public NonEmptyBST<T> Add(T elt)
        {
            return new NonEmptyBST<T>(elt);
        }

        public int Cardinality()
        {
            return 0;
        }

        public int CompareTo(object obj)
        {
            throw new NotImplementedException();
        }

        public bool IsEmpty()
        {
            return true;
        }

        public bool Member(T elt)
        {
            return false;
        }
    }
}
