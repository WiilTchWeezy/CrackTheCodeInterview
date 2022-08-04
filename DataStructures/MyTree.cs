using System;
using System.Collections.Generic;
using System.Text;

namespace CrackTheCodeInterview.DataStructures
{
    public class MyTree
    {
        public TreeNode Root { get; set; }

        public void DeepFirstSearch(TreeNode root)
        {
            if (root == null) return;
            foreach (var item in root.Children)
            {
                DeepFirstSearch(item);
            }
            Console.WriteLine(root.Value);
        }


    }

    public class TreeNode
    {
        public string Value { get; set; }

        public List<TreeNode> Children { get; set; }

        public bool IsFull { get { return Children.Count == 2; } }

        public TreeNode(string value)
        {
            Value = value;
            Children = new List<TreeNode>();
        }

        public override string ToString()
        {
            return Value;
        }
    }
}
