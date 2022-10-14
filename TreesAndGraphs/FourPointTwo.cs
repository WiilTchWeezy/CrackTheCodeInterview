using CrackTheCodeInterview.DataStructures;
using System;
using System.Collections.Generic;
using System.Text;

namespace CrackTheCodeInterview.TreesAndGraphs
{
    public class FourPointTwo
    {
        //BIG O - O(log N) AddNode go to all tree on every insertion
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

        public MinimalNode CreateMinimal(int[] elements)
        {
            var minimalTree = CreateMinimal(elements, 0, elements.Length - 1);
            return minimalTree;
        }

        private MinimalNode CreateMinimal(int[] elements, int start, int end)
        {
            if (end < start)
                return null;
            int mid = (start + end) / 2;
            MinimalNode n = new MinimalNode(elements[mid]);
            n.Left = CreateMinimal(elements, start, mid - 1);
            n.Right = CreateMinimal(elements, mid + 1, end);
            return n;
        }
    }

    public class MinimalTree
    {
        public MinimalNode Root { get; set; }
    }

    public class MinimalNode
    {
        public MinimalNode(int value)
        {
            Value = value;
        }
        public int Value { get; set; }

        public MinimalNode Left { get; set; }
        public MinimalNode Right { get; set; }
    }
}
