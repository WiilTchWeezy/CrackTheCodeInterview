using CrackTheCodeInterview.ArrayAndStrings;
using CrackTheCodeInterview.DataStructures;
using CrackTheCodeInterview.LinkedLists;
using CrackTheCodeInterview.StacksAndQueue;
using CrackTheCodeInterview.TreesAndGraphs;
using System;

namespace CrackTheCodeInterview
{
    public class Program
    {
        static void Main()
        {
            MyTree myTree = new MyTree();
            TreeNode node = new TreeNode("0");
            TreeNode nod1 = new TreeNode("1");
            TreeNode nod2 = new TreeNode("2");
            TreeNode nod3 = new TreeNode("3");
            TreeNode nod4 = new TreeNode("4");
            node.Children.Add(nod1);
            node.Children.Add(nod2);
            nod1.Children.Add(nod3);
            nod1.Children.Add(nod4);
            myTree.Root = node;
            myTree.DeepFirstSearch(myTree.Root);


            GraphNode node1 = new GraphNode("1");
            GraphNode node2 = new GraphNode("2");
            GraphNode node3 = new GraphNode("3");
            GraphNode node4 = new GraphNode("4");
            GraphNode node5 = new GraphNode("5");
            GraphNode node6 = new GraphNode("6");
            GraphNode node7 = new GraphNode("7");
            GraphNode node8 = new GraphNode("8");

            node1.Childrens.Add(node2);
            node5.Childrens.Add(node2);
            node2.Childrens.Add(node7);
            node2.Childrens.Add(node3);
            node3.Childrens.Add(node4);
            node4.Childrens.Add(node7);
            node5.Childrens.Add(node3);
            node6.Childrens.Add(node5);
            node6.Childrens.Add(node7);
            node8.Childrens.Add(node1);
            node7.Childrens.Add(node8);

            FourPointOne fourPointOne = new FourPointOne();

            Console.WriteLine(fourPointOne.FindAPathBetweenNodes(node1, node8));

            MyGraph graph = new MyGraph();

            graph.Nodes.Add(node1);
            graph.Nodes.Add(node2);
            graph.Nodes.Add(node3);
            graph.Nodes.Add(node4);


            Console.WriteLine("*********");
            int[] elements = new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12 };

            MyBinaryTree myBinaryTree = new MyBinaryTree();
            myBinaryTree = myBinaryTree.CreateFromElements(elements);
            myBinaryTree.inOrder(myBinaryTree.Root);

            Console.ReadKey();
        }
    }
}
