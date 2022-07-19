using CrackTheCodeInterview.DataStructures;
using System;
using System.Text;

namespace CrackTheCodeInterview.LinkedLists
{
    public class TwoPointSeven
    {
        public bool IsIntersection<T>(LinkedList<T> listOne, LinkedList<T> listTwo)
        {
            Node<T> nodeOne = listOne.Head;
            Node<T> nodeTwo = listTwo.Head;
            while(nodeOne != null && nodeTwo != null)
            {
                if (nodeOne.Data.Equals(nodeTwo.Data))
                    return true;
            }
            return false;
        }
    }
}
