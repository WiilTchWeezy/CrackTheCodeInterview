using System;
using System.Collections.Generic;
using System.Text;

namespace CrackTheCodeInterview.DataStructures
{
    public class MyTree
    {
        public TreeNode Root { get; set; }

        public override string ToString()
        {
            var sb = new StringBuilder();
            if(Root != null)
            {
                sb.Append(DeepFirstSearch(this.Root));
            }
            return sb.ToString();
        }

        private string DeepFirstSearch (TreeNode root)
        {
            if (root == null) return string.Empty;
            foreach (var item in root.Children)
            {
                return DeepFirstSearch(item);
            }
            return string.Empty;
        }
    }

    public class TreeNode
    {
        public string Value { get; set; }

        public List<TreeNode> Children { get; set; }

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
