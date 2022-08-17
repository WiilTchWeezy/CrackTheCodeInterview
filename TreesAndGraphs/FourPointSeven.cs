using CrackTheCodeInterview.DataStructures;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CrackTheCodeInterview.TreesAndGraphs
{
    public class FourPointSeven
    {
        public string ProjectDependencies(string[] projects, List<KeyValuePair<string, string>> projectDependencies)
        {
            StringBuilder sb = new StringBuilder();
            List<TreeNode> nodes = new List<TreeNode>();
            for (int i = 0; i < projects.Length; i++)
            {
                nodes.Add(new TreeNode(projects[i]));
            }
            foreach (var item in projectDependencies)
            {
                var node = nodes.Where(x => x.Value == item.Value).FirstOrDefault();
                var dependencyNode = nodes.Where(x => x.Value == item.Key).FirstOrDefault();
                node.Children.Add(dependencyNode);
            }
            BuildNodes(nodes, sb);
            return sb.ToString();
        }

        public void BuildNodes(List<TreeNode> nodes, StringBuilder sb)
        {
            foreach (var item in nodes)
            {
                if (item.Children.Count > 0)
                {
                    BuildNodes(item.Children, sb);
                    if (sb.ToString().Contains(item.Value) == false)
                        sb.Append($"{item.Value}, ");
                }
                else
                {
                    if (sb.ToString().Contains(item.Value) == false)
                        sb.Append($"{item.Value}, ");
                }
            }
        }
    }
}
