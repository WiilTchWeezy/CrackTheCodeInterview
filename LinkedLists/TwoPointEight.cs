﻿using System;
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
    }
}
