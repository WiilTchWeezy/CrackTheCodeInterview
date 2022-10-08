using CrackTheCodeInterview.DataStructures;
using System;
using System.Collections.Generic;
using System.Text;

namespace CrackTheCodeInterview.LinkedLists
{
    public class TwoPointEight
    {
        public T ReturnCircularNode<T>(DataStructures.LinkedList<T> linkedList)
        {
            DataStructures.Node<T> circularNode = null;

            Dictionary<T, int> hashTable = new Dictionary<T, int>();
            int position = 0;
            DataStructures.Node<T> currentNode = linkedList.Head;
            while (currentNode != null)
            {
                if (hashTable.ContainsKey(currentNode.Data))
                    return currentNode.Data;

                hashTable.Add(currentNode.Data, position);
                currentNode = currentNode.Next;
                position++;
            }

            return circularNode.Data;
        }

        #region BookSolution
        public Node<int> FindBeginning(Node<int> head)
        {
            Node<int> slow = head;
            Node<int> fast = head;

            //Finding the meeting point
            while (fast != null && fast.Next != null)
            {
                slow = slow.Next;
                fast = fast.Next.Next;
                if (slow == fast)
                    break;
            }

            //Cheking for error - No meeting point no loop
            if (fast == null || fast.Next == null)
                return null;

            slow = head;
            while (slow != fast)
            {
                slow = slow.Next;
                fast = fast.Next;
            }

            return fast;
        } 
        #endregion
    }
}
