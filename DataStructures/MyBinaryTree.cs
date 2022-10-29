using System;
using System.Collections.Generic;
using System.Text;

namespace CrackTheCodeInterview.DataStructures
{
    public class MyBinaryTree
    {
        public BinaryNode Root { get; set; }


        public MyBinaryTree CreateFromElements(int[] elements)
        {
            this.Root = this.InsertLevelOrder(elements, 0);
            return this;
        }
        private BinaryNode InsertLevelOrder(int[] elements, int i)
        {
            BinaryNode root = null;
            if(i < elements.Length)
            {
                root = new BinaryNode(elements[i].ToString());
                root.Left = InsertLevelOrder(elements, 2 * i + 1);
                root.Right = InsertLevelOrder(elements, 2 * i + 2);
            }
            return root;
        }

        public void inOrder(BinaryNode root)
        {
            if (root != null)
            {
                inOrder(root.Left);
                Console.WriteLine(root.Data + " ");
                inOrder(root.Right);
            }
        }
    }

    public class BinaryNode
    {
        public String Data { get; set; }
        public BinaryNode Parent { get; set; }
        public BinaryNode Left { get; set; }
        public BinaryNode Right { get; set; }

        public BinaryNode(string value)
        {
            Data = value;
        }
    }
}
