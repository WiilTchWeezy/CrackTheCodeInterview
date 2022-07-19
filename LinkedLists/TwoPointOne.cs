using CrackTheCodeInterview.DataStructures;
using System;
using System.Collections.Generic;
using System.Text;

namespace CrackTheCodeInterview.LinkedLists
{
    public class TwoPointOne
    {
        public DataStructures.LinkedList<T> RemoveDups<T>(DataStructures.LinkedList<T> list)
        {
            Dictionary<T, int> keyValues = new Dictionary<T, int>();
            Node<T> currentNode = list.Head;
            int position = 0;
            while (currentNode != null)
            {
                if (keyValues.ContainsKey(currentNode.Data))
                {
                    list.DeleteAtIndex(position);
                    position--;
                }
                else
                {
                    keyValues.Add(currentNode.Data, position);
                }
                currentNode = currentNode.Next;
                position++;
            }
            return list;
        }
    }
}
