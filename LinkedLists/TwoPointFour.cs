using CrackTheCodeInterview.DataStructures;
using System;
using System.Collections.Generic;
using System.Text;

namespace CrackTheCodeInterview.LinkedLists
{
    public class TwoPointFour
    {
        public DataStructures.LinkedList<int> PartitionByX(int x, DataStructures.LinkedList<int> list)
        {
            List<int> smaller = new List<int>();
            List<int> greather = new List<int>();

            DataStructures.Node<int> currentNode = list.Head;
            while (currentNode != null)
            {
                if (currentNode.Data >= x)
                    greather.Add(currentNode.Data);
                else
                    smaller.Add(currentNode.Data);
                currentNode = currentNode.Next;
            }

            DataStructures.LinkedList<int> returnList = new DataStructures.LinkedList<int>();
            foreach (var item in smaller)
            {
                returnList.Insert(item);
            }
            foreach (var item in greather)
            {
                returnList.Insert(item);
            }
            return returnList;
        }

        #region BookSolution
        Node<int> Partition(Node<int> node, int x)
        {
            Node<int> beforeStart = null;
            Node<int> beforeEnd = null;
            Node<int> afterStart = null;
            Node<int> afterEnd = null;

            while (node != null)
            {
                Node<int> next = node.Next;
                node.Next = null;
                if (node.Data < x)
                {
                    if (beforeStart == null)
                    {
                        beforeStart = node;
                        beforeEnd = beforeStart;
                    }
                    else
                    {
                        beforeEnd.Next = node;
                        beforeEnd = node;
                    }
                }
                else
                {
                    if (afterStart == null)
                    {
                        afterStart = node;
                        afterEnd = afterStart;
                    }
                    else
                    {
                        afterEnd.Next = node;
                        afterEnd = node;
                    }
                }
                node = next;
            }
            if (beforeStart == null)
                return afterStart;

            beforeEnd.Next = afterStart;
            return beforeStart;
        }

        Node<int> PartitionWithouKeppTrackingOriginalOrder(Node<int> node, int x)
        {
            Node<int> head = node;
            Node<int> tail = node;

            while (node != null)
            {
                Node<int> next = node.Next;
                if (node.Data < x)
                {
                    node.Next = head;
                    head = node;
                }
                else
                {
                    tail.Next = node;
                    tail = node;
                }
            }
            tail.Next = null;
            return head;
        } 
        #endregion
    }
}
