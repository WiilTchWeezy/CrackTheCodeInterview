using System;
using System.Collections.Generic;
using System.Text;

namespace CrackTheCodeInterview.LinkedLists
{
    public class TwoPointFour
    {
        public DataStructures.LinkedList<int> PartitionByX (int x, DataStructures.LinkedList<int> list)
        {
            List<int> smaller = new List<int>();
            List<int> greather = new List<int>();

            DataStructures.Node<int> currentNode = list.Head;
            while(currentNode != null)
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
    }
}
