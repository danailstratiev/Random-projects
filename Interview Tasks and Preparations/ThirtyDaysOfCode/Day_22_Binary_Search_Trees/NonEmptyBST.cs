using System;

namespace Day_22_Binary_Search_Trees
{
    public class NonEmptyBST<T> : ITree<T>, IComparable
    {
        T data;
        ITree<T> left;
        ITree<T> right;

        public NonEmptyBST(T elt)
        {
            data = elt;
            left = new EmptyBST<T>();
            right = new EmptyBST<T>();
        }

        public NonEmptyBST(T elt, ITree<T> leftTree, ITree<T> rightTree)
        {
            data = elt;
            left = leftTree;
            right = rightTree;
        }

        public NonEmptyBST<T> Add(T elt)
        {
            if ((IComparable)data == (IComparable)elt)
            {
                return this;
            }
            else
            {
                var e = (IComparable)elt;
                var d = (IComparable)data;

                if (e.CompareTo(d) < 0)
                {
                    return new NonEmptyBST<T>(data, left.Add(elt), right);
                }
                else
                {
                    return new NonEmptyBST<T>(data, left, right.Add(elt));

                }
            }
        }

        public int Cardinality()
        {
            return 1 + left.Cardinality() + right.Cardinality();
        }

        public int CompareTo(object obj)
        {
            throw new NotImplementedException();
        }

        public bool IsEmpty()
        {
            return false;
        }

        public bool Member(T elt)
        {
            if ((IComparable)data == (IComparable)elt)
            {
                return true;
            }
            else
            {
                var e = (IComparable)elt;
                var d = (IComparable)data;

                if (e.CompareTo(d) < 0)
                {
                    return left.Member(elt);
                }
                else
                {
                    return right.Member(elt);
                }
            }
        }
    }
}