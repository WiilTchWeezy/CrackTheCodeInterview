using CrackTheCodeInterview.DataStructures;
using System;
using System.Text;

namespace CrackTheCodeInterview.LinkedLists
{
    public class TwoPointSeven
    {
        // BIG O - O(A+B) A nd B are the lenght for the linkedLists
        public Node<int> IsIntersection(Node<int> listOne, Node<int> listTwo)
        {
            if (listOne == null || listTwo == null) return null;

            TailAndSize nodeOneResult = GetTailAndSize(listOne);
            TailAndSize nodeTwoResult = GetTailAndSize(listTwo);

            if (nodeOneResult.Tail != nodeTwoResult.Tail)
                return null;

            Node<int> shorter = nodeOneResult.Size < nodeTwoResult.Size ? listOne : listTwo;
            Node<int> longer = nodeOneResult.Size < nodeTwoResult.Size ? listTwo : listOne;

            longer = GetKthNode(longer, Math.Abs(nodeOneResult.Size - nodeTwoResult.Size));

            while(shorter != longer)
            {
                shorter = shorter.Next;
                longer = longer.Next;
            }
            return longer;
        }

        TailAndSize GetTailAndSize(Node<int> node)
        {
            if (node == null) return null;

            int size = 1;
            Node<int> current = node;
            while(current.Next != null)
            {
                size++;
                current = current.Next;
            }
            return new TailAndSize { Size = size, Tail = current };
        }

        Node<int> GetKthNode(Node<int> head, int k)
        {
            Node<int> current = head;
            while(k>0 && current != null)
            {
                current = current.Next;
                k--;
            }
            return current;
        }
    }

    public class TailAndSize
    {
        public Node<int> Tail { get; set; }
        public int Size { get; set; }
    }
}
