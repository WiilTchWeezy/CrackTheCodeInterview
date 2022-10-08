using CrackTheCodeInterview.ArrayAndStrings;
using CrackTheCodeInterview.BitManipulation;
using CrackTheCodeInterview.DataStructures;
using CrackTheCodeInterview.LinkedLists;
using CrackTheCodeInterview.StacksAndQueue;
using CrackTheCodeInterview.TreesAndGraphs;
using System;
using System.Collections.Generic;

namespace CrackTheCodeInterview
{
    public class Program
    {
        static void Main()
        {
            TwoPointEight twoPointEight = new TwoPointEight();
            Node<int> node1 = new Node<int>(1);
            Node<int> node2 = new Node<int>(2);
            Node<int> node3 = new Node<int>(3);
            Node<int> node4 = new Node<int>(4);
            Node<int> node5 = new Node<int>(5);
            Node<int> node6 = new Node<int>(6);
            Node<int> node7 = new Node<int>(7);
            Node<int> node8 = new Node<int>(8);
            Node<int> node9 = new Node<int>(9);
            Node<int> node10 = new Node<int>(10);
            node1.Next = node2;
            node2.Next = node3;
            node3.Next = node4;
            node4.Next = node5;
            node5.Next = node6;
            node6.Next = node7;
            node7.Next = node8;
            node8.Next = node9;
            node9.Next = node10;
            node10.Next = node3;

            twoPointEight.FindBeginning(node1);
            Console.ReadKey();
        }
    }
}
