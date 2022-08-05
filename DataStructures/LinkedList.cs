using System;
using System.Collections.Generic;
using System.Text;

namespace CrackTheCodeInterview.DataStructures
{
    public class LinkedList<T> : ICloneable
    {
        public LinkedList()
        {

        }

        public LinkedList(T[] values)
        {
            for (int i = 0; i < values.Length; i++)
            {
                this.Insert(values[i]);
            }
        }


        public Node<T> Head { get; set; }

        public void Insert(T data)
        {
            Node<T> newNode = new Node<T>(data);
            newNode.Next = null;

            if (Head == null)
            {
                Head = newNode;
            }
            else
            {
                Node<T> last = GetTail();
                last.Next = newNode;
            }
        }

        public void DeleteAtIndex(int index)
        {
            if (Head == null)
                throw new ArgumentNullException();
            Node<T> currentNode = Head, previous = null;
            if (index == 0)
            {
                Head = currentNode.Next;
            }
            int counter = 0;
            while (currentNode != null)
            {
                if (counter == index)
                {
                    previous.Next = currentNode.Next;
                    break;
                }
                else
                {
                    previous = currentNode;
                    currentNode = currentNode.Next;
                    counter++;
                }
            }
            if (currentNode == null)
                throw new IndexOutOfRangeException();
        }

        public Node<T> GetAtIndex(int index)
        {
            if (Head == null)
                throw new ArgumentNullException();
            Node<T> currentNode = Head;
            if (index == 0)
            {
                Head = currentNode.Next;
            }

            int counter = 0;
            while (currentNode != null)
            {
                if (counter == index)
                {
                    return currentNode;
                }
                else
                {
                    currentNode = currentNode.Next;
                    counter++;
                }
            }
            return null;
        }

        public int GetTotalElements()
        {
            if (Head == null)
                throw new ArgumentNullException();
            Node<T> currentNode = Head;
            int counter = 0;
            while (currentNode != null)
            {
                currentNode = currentNode.Next;
                counter++;
            }
            return counter;
        }

        private Node<T> GetTail()
        {
            if (Head == null)
                throw new ArgumentNullException();
            Node<T> last = Head;
            while (last.Next != null)
            {
                last = last.Next;
            }
            return last;
        }

        public override string ToString()
        {
            Node<T> currentNode = Head;
            StringBuilder sb = new StringBuilder();
            while (currentNode != null)
            {
                sb.Append(currentNode.ToString() + " => ");
                currentNode = currentNode.Next;
            }
            return sb.ToString();
        }

        public T[] GetElements()
        {
            List<T> elements = new List<T>();
            DataStructures.Node<T> currentNode = this.Head;
            while(currentNode != null)
            {
                elements.Add(currentNode.Data);
                currentNode = currentNode.Next;
            }
            return elements.ToArray();
        }

        public object Clone()
        {
            return new LinkedList<T>() { Head = this.Head };
        }
    }

    public class Node<T>
    {
        public Node<T> Next { get; set; } = null;
        public T Data { get; set; }

        public Node(T data)
        {
            Data = data;
        }

        public override string ToString()
        {
            return Data.ToString();
        }
    }
}
