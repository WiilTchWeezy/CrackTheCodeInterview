using CrackTheCodeInterview.DataStructures;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CrackTheCodeInterview.TreesAndGraphs
{
    public class FourPointFour
    {
        public bool IsBalanced(MyBinaryTree binaryTree)
        {
            List<BinaryNode> treeNodes = new List<BinaryNode>();
            treeNodes.Add(binaryTree.Root);
            while (treeNodes.Any())
            {
                List<BinaryNode> nexNodes = new List<BinaryNode>();
                foreach (var item in treeNodes)
                {
                    if (item.Right != null && item.Left == null)
                        return false;
                    else if(item.Right != null && item.Left != null)
                    {
                        nexNodes.Add(item.Left);
                        nexNodes.Add(item.Right);
                    }
                }
                treeNodes = nexNodes;
            }
            return true;
        }

        #region BookSolution
        public int GetHeight(BinaryNode root)
        {
            if (root == null)
                return -1;
            int leftHeight = GetHeight(root.Left);
            if (leftHeight == int.MinValue) return int.MinValue;

            int rightHeight = GetHeight(root.Right);
            if (rightHeight == int.MinValue) return int.MinValue;

            int heightDiff = leftHeight - rightHeight;
            if (Math.Abs(heightDiff) > 1)
                return int.MinValue;
            else
                return Math.Max(leftHeight, rightHeight) + 1;
        }

        public bool IsBalanced(BinaryNode root)
        {
            return GetHeight(root) != int.MinValue;
        } 
        #endregion
    }
}
