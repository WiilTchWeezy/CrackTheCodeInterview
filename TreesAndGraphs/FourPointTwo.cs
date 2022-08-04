using CrackTheCodeInterview.DataStructures;
using System;
using System.Collections.Generic;
using System.Text;

namespace CrackTheCodeInterview.TreesAndGraphs
{
    public class FourPointTwo
    {
        public MyTree MinimalTree(int[] elements)
        {
            MyTree myTree = new MyTree();

            for (int i = 0; i < elements.Length; i++)
            {
                if (i == 0)
                {
                    myTree.Root = new TreeNode(i.ToString());
                    continue;
                }
                if (myTree.Root.IsFull == false) {
                    myTree.Root.Children.Add(new TreeNode(i.ToString()));
                    continue;
                }
                AddNode(myTree.Root.Children, i);
            }
            return myTree;
        }

        private bool AddNode(List<TreeNode> childrens, int value)
        {
            if (childrens.TrueForAll(x => x.IsFull))
            {
                foreach (var item in childrens)
                {
                    if (AddNode(item.Children, value))
                        break;
                }
                return true;
            }

            foreach (var item in childrens)
            {
                if (item.IsFull)
                    continue;
                else
                {
                    item.Children.Add(new TreeNode(value.ToString()));
                    return true;
                }
            }
            return false;

        }
    }
}
