using CrackTheCodeInterview.DataStructures;
using System;
using System.Linq;
using System.Text;

namespace CrackTheCodeInterview.TreesAndGraphs
{
    public class FourPointThree
    {
        public System.Collections.Generic.List<LinkedList<string>> CreateALinkedList(MyBinaryTree binaryTree)
        {
            var linkedLists = new System.Collections.Generic.List<LinkedList<string>>();
            System.Collections.Generic.List<BinaryNode> treeNodes = new System.Collections.Generic.List<BinaryNode>();
            treeNodes.Add(binaryTree.Root);
            while (treeNodes.Any())
            {
                var linkedListToAdd = new LinkedList<string>();
                System.Collections.Generic.List<BinaryNode> nexNodes = new System.Collections.Generic.List<BinaryNode>();
                foreach (var item in treeNodes)
                {
                    linkedListToAdd.Insert(item.Data);
                    if (item.Right != null)
                        nexNodes.Add(item.Right);
                    if (item.Left != null)
                        nexNodes.Add(item.Left);
                }
                linkedLists.Add(linkedListToAdd);
                treeNodes = nexNodes;
            }

            return linkedLists;
        }
    }
}
