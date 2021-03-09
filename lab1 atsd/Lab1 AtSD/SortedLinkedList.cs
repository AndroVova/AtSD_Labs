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

        public void Clear()
        {
            head = null;
            tail = null;
            length = 0;
        }

        public void Print()
        {
            int i = 0;
            Node<T> current = head;
            while (current != null)
            {
                Console.WriteLine($"{i++}:" + current.Data);
                current = current.Next;
            }
            Console.WriteLine();
        }

        public void Length()
        {
            Console.WriteLine("Length: " + length);
        }

        public void Search(T data)
        {
            Node<T> current = head;
            while (current != null)
            {
                if (current.Data.Equals(data))
                    Console.WriteLine($"{data} is located in a list");
                current = current.Next;
            }
            Console.WriteLine($"{data} is not located in a list");
        }

        public void IsEmpty()
        {
            if (head == null && tail == null && length == 0)
                Console.WriteLine("List is empty");
            else
                Console.WriteLine("List isn`t empty");
        }

        public int Compare(T x, T y) => Comparer.Default.Compare(x, y);

        public IEnumerator<T> GetEnumerator()
        {
            var current = head;
            while (current != null)
            {
                yield return current.Data;
                current = current.Next;
            }
        }

        IEnumerator IEnumerable.GetEnumerator() => ((IEnumerable)this).GetEnumerator();        
    }
}
