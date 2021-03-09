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

        public void Add(T data)
        {
            var Item = new Node<T>(data);
            if (head == null)
                head = Item;
            else
                tail.Next = Item;
            tail = Item;

            length++;
        }

        public void Delete(T data)
        {
            Node<T> current = head;
            Node<T> previous = null;
            while (current != null)
            {
                if (current.Data.Equals(data))
                {
                    if (previous != null)
                    {
                        previous.Next = current.Next;
                        if (current.Next == null)
                            tail = previous;
                    }
                    else
                    {
                        head = head.Next;
                        if (head == null)
                            tail = null;
                    }
                    length--;
                }
                previous = current;
                current = current.Next;
            }
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
