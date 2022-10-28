using CrackTheCodeInterview.DataStructures;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CrackTheCodeInterview.TreesAndGraphs
{
    public class FourPointFive
    {
        public bool IsSearchTree(MyBinaryTree binaryTree)
        {
            List<BinaryNode> treeNodes = new List<BinaryNode>();
            int rootValue = 0;
            int.TryParse(binaryTree.Root.Data, out rootValue);
            if (binaryTree.Root.Left != null)
                treeNodes.Add(binaryTree.Root.Left);
            if (binaryTree.Root.Right != null)
                treeNodes.Add(binaryTree.Root.Right);
            while (treeNodes.Any())
            {
                List<BinaryNode> nexNodes = new List<BinaryNode>();
                foreach (var item in treeNodes)
                {
                    int nodeValue = 0;
                    int.TryParse(item.Data, out nodeValue);
                    if (nodeValue < rootValue)
                        return false;
                }
                treeNodes = nexNodes;
            }
            return true;
        }

        public bool CheckBTS(BinaryNode root)
        {
            return CheckBTS(root, null, null);
        }

        public bool CheckBTS(BinaryNode n, int? min, int? max)
        {
            if (n == null)
                return true;
            if ((min != null && Convert.ToInt32(n.Data) < min) || (max != null && Convert.ToInt32(n.Data) > max))
                return false;
            if (!CheckBTS(n.Left, min, Convert.ToInt32(n.Data)) || !CheckBTS(n.Right, Convert.ToInt32(n.Data), max))
                return false;

            return true;
        }
    }
}
