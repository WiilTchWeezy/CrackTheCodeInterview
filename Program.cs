using CrackTheCodeInterview.ArrayAndStrings;
using CrackTheCodeInterview.DataStructures;
using CrackTheCodeInterview.LinkedLists;
using CrackTheCodeInterview.StacksAndQueue;
using System;

namespace CrackTheCodeInterview
{
    public class Program
    {
        static void Main()
        {
            MyGraph graph = new MyGraph();

            GraphNode node0 = new GraphNode("0");
            GraphNode node1 = new GraphNode("1");
            GraphNode node2 = new GraphNode("2");
            GraphNode node3 = new GraphNode("3");
            GraphNode node4 = new GraphNode("4");
            GraphNode node5 = new GraphNode("5");
            GraphNode node6 = new GraphNode("6");
            node1.Childrens.Add(node2);
            node2.Childrens.Add(node3);
            node2.Childrens.Add(node0);
            node3.Childrens.Add(node2);
            node0.Childrens.Add(node1);

            node5.Childrens.Add(node4);
            node4.Childrens.Add(node6);
            node6.Childrens.Add(node5);

            graph.Nodes.Add(node0);
            graph.Nodes.Add(node1);
            graph.Nodes.Add(node2);
            graph.Nodes.Add(node3);
            graph.Nodes.Add(node4);
            graph.Nodes.Add(node5);
            graph.Nodes.Add(node6);
            Console.WriteLine(graph);
            Console.ReadKey();
        }
    }
}
