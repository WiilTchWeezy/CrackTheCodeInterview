using System;
using System.Collections.Generic;
using System.Text;

namespace CrackTheCodeInterview.LinkedLists
{
    public class TwoPointTwo
    {
        public DataStructures.Node<T> ReturnKthElementToLast<T>(DataStructures.LinkedList<T> list, int k)
        {
            return list.GetAtIndex(list.GetTotalElements() - k);
        }
    }
}
