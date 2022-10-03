using CrackTheCodeInterview.DataStructures;
using System;
using System.Collections.Generic;
using System.Text;

namespace CrackTheCodeInterview.LinkedLists
{
    public class TwoPointThree
    {
        public bool DeleteNode(Node<int> n)
        {
            if (n == null || n.Next == null)
                return false;

            Node<int> next = n.Next;
            n.Data = next.Data;
            n.Next = next.Next;
            return true;
        }
    }
}
