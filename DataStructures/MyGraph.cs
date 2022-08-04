using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CrackTheCodeInterview.DataStructures
{
    public class MyGraph
    {
        public List<GraphNode> Nodes { get; set; }
        public MyGraph()
        {
            Nodes = new List<GraphNode>();
        }

        public MyGraph(List<GraphNode> nodes)
        {
            Nodes = nodes;
        }

        public override string ToString()
        {
            var sb = new StringBuilder();
            foreach (var node in Nodes)
            {
                sb.AppendLine($"{node} => {string.Join(",", node.Childrens.Select(x => x.Value).ToArray())}");
            }
            return sb.ToString();
        }
    }

    public class GraphNode
    {
        public string Value { get; set; }

        public List<GraphNode> Childrens { get; set; }

        public bool Touched { get; set; }

        public GraphNode()
        {
            Childrens = new List<GraphNode>();
        }

        public GraphNode(string value)
        {
            Value = value;
            Childrens = new List<GraphNode>();
        }

        public override string ToString()
        {
            return Value;
        }
    }
}
