using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Text;

namespace Lab1_AtSD
{
    class SortedLinkedList<T> : IEnumerable<T>, IComparer<T>
    {
        private Node<T> head = null;
        private Node<T> tail = null;
        private int length = 0;

        public int ListLength
        {
            get => length;
        }

        public int Compare( T x, T y)
        {
            throw new NotImplementedException();
        }

        public IEnumerator<T> GetEnumerator()
        {
            throw new NotImplementedException();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            throw new NotImplementedException();
        }
    }
}
