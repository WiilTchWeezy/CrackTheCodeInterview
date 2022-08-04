using CrackTheCodeInterview.DataStructures;
using System;
using System.Collections.Generic;
using System.Text;

namespace CrackTheCodeInterview.TreesAndGraphs
{
    public class FourPointOne
    {
        public string FindAPathBetweenNodes(GraphNode nodeA, GraphNode nodeB)
        {
            StringBuilder sb = new StringBuilder();
            DepthFirstSearch(nodeA, nodeB, sb);
            return sb.ToString();
        }

        private void DepthFirstSearch(GraphNode root, GraphNode nodeToFind, StringBuilder path)
        {
            if (root == null) return;
            if (VisitNode(root, nodeToFind, path))
                return;

            foreach (var item in root.Childrens)
            {
                if (path.ToString().Contains(nodeToFind.ToString()))
                    break;
                if (item.Touched == false)
                    DepthFirstSearch(item, nodeToFind, path);
            }
        }

        private bool VisitNode(GraphNode nodeToVisit, GraphNode nodeToFind, StringBuilder path)
        {
            nodeToVisit.Touched = true;
            path.AppendLine(nodeToVisit.ToString());
            return nodeToVisit.Value == nodeToFind.Value;
        }


    }
}
