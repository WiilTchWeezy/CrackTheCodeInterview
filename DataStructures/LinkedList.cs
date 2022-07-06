using System;
using System.Collections.Generic;
using System.Text;

namespace CrackTheCodeInterview.DataStructures
{
    public class LinkedList<T>
    {
        private Node<T> _head;

        public LinkedList<T> Insert(LinkedList<T> list, T data)
        {
            Node<T> newNode = new Node<T>(data);
            newNode.Next = null;

            if (list._head == null)
            {
                list._head = newNode;
            }
            else
            {
                Node<T> last = GetTail(list);
                last.Next = newNode;
            }
            return list;
        }

        public LinkedList<T> DeleteAtIndex(LinkedList<T> list, int index)
        {
            if (list._head == null)
                throw new ArgumentNullException();
            Node<T> currentNode = list._head, previous = null;
            if(index == 0)
            {
                list._head = currentNode.Next;
                return list;
            }
            int counter = 0;
            while(currentNode != null)
            {
                if(counter == index)
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
            return list;
        }

        private Node<T> GetTail(LinkedList<T> list)
        {
            if (list._head == null)
                throw new ArgumentNullException();
            Node<T> last = list._head;
            while (last.Next != null)
            {
                last = last.Next;
            }
            return last;
        }

        public override string ToString()
        {
            Node<T> currentNode = _head;
            StringBuilder sb = new StringBuilder();
            while (currentNode != null)
            {
                sb.AppendLine(currentNode.ToString());
                currentNode = currentNode.Next;
            }
            return sb.ToString();
        }
    }

    public class Node<T>
    {
        public Node<T> Next { get; set; } = null;
        T _data;

        public Node(T data)
        {
            _data = data;
        }

        public override string ToString()
        {
            return _data.ToString();
        }
    }
}
