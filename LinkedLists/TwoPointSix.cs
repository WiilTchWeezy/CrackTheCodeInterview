using System;
using System.Collections.Generic;
using System.Text;

namespace CrackTheCodeInterview.LinkedLists
{
    public class TwoPointSix
    {
        public bool IsAPalindrome<T>(DataStructures.LinkedList<T> linkedList)
        {
            var values = linkedList.GetElements();
            var reverseNode = ReverseIn(linkedList.Head);
            DataStructures.LinkedList<T> reversedList = new DataStructures.LinkedList<T>();
            reversedList.Head = reverseNode;

            var originalLinkedList = new DataStructures.LinkedList<T>(values);
            DataStructures.Node<T> nodeOne = originalLinkedList.Head;
            DataStructures.Node<T> nodeTwo = reversedList.Head;
            while(nodeOne != null && nodeTwo != null)
            {
                if (nodeTwo.Data.Equals(nodeOne.Data) == false)
                    return false;
                nodeOne = nodeOne.Next;
                nodeTwo = nodeTwo.Next;
            }
            return true;
        }

        public DataStructures.Node<T> Reverse<T>(DataStructures.Node<T> head)
        {
            if (head == null || head.Next == null)
                return head;
            DataStructures.Node<T> rest = Reverse(head.Next);
            head.Next.Next = head;
            head.Next = null;
            return rest;
        }

        public DataStructures.Node<T> ReverseIn<T>(DataStructures.Node<T> head)
        {
            DataStructures.Node<T> previous = null;
            DataStructures.Node<T> current = head;
            DataStructures.Node<T> next = null;

            while(current != null)
            {
                next = current.Next;
                current.Next = previous;
                previous = current;
                current = next;
            }
            return previous;
        }
    }
}
