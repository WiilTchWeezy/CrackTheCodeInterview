using CrackTheCodeInterview.DataStructures;
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
            while (nodeOne != null && nodeTwo != null)
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

            while (current != null)
            {
                next = current.Next;
                current.Next = previous;
                previous = current;
                current = next;
            }
            return previous;
        }

        #region BookSolution
        public bool IsPalindrome(Node<int> head)
        {
            Node<int> reversed = ReverseAndClone(head);
            return IsEqual(head, reversed);
        }

        private Node<int> ReverseAndClone(Node<int> node)
        {
            Node<int> head = null;
            while (node != null)
            {
                Node<int> n = new Node<int>(node.Data);
                n.Next = head;
                head = n;
                node = node.Next;
            }
            return head;
        }

        private bool IsEqual(Node<int> nodeOne, Node<int> nodeTwo)
        {
            while (nodeOne != null && nodeTwo != null)
            {
                if (nodeOne.Data != nodeTwo.Data)
                    return false;
                nodeOne = nodeOne.Next;
                nodeTwo = nodeTwo.Next;
            }
            return nodeOne == null && nodeTwo == null;
        }

        #region RecursiveSolution
        public bool IsAPalindromeRecursive(Node<int> head)
        {
            RecursiveResult result = IsAPalindromeRecurse(head, Length(head);
            return result.Result;
        }

        private int Length(Node<int> node)
        {
            int size = 0;
            while (node != null)
            {
                size++;
                node = node.Next;
            }
            return size;
        }

        private RecursiveResult IsAPalindromeRecurse(Node<int> head, int length)
        {
            if (head == null || length <= 0)
            {
                return new RecursiveResult() { Node = head, Result = true };
            }
            else if (length == 1)
            {
                return new RecursiveResult() { Node = head.Next, Result = true };
            }

            RecursiveResult res = IsAPalindromeRecurse(head.Next, length - 2);

            if (!res.Result || res.Node == null)
                return res;
            res.Result = head.Data == res.Node.Data;
            res.Node = res.Node.Next;
            return res;
        } 
        #endregion
        #endregion
    }

    public class RecursiveResult
    {
        public Node<int> Node { get; set; }
        public bool Result { get; set; }
    }
}
