using CrackTheCodeInterview.DataStructures;
using System;
using System.Collections.Generic;
using System.Text;

namespace CrackTheCodeInterview.TreesAndGraphs
{
    public class FourPointSix
    {

        public BinaryNode InOrderSuc(BinaryNode n)
        {
            if (n == null) return n;

            if (n.Right != null)
                return LeftMostChild(n.Right);
            else
            {
                BinaryNode q = n;
                BinaryNode x = q.Parent;
                while (x != null && x.Left != q)
                {
                    q = x;
                    x = x.Parent;
                }
                return x;
            }
        }

        private BinaryNode LeftMostChild(BinaryNode n)
        {
            if (n == null)
                return n;
            while(n.Left != null)
            {
                n = n.Left;
            }
            return n;
        }
    }
}
