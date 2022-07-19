using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CrackTheCodeInterview.LinkedLists
{
    public class TwoPointFive
    {
        public DataStructures.LinkedList<int> SumReverseOrder(DataStructures.LinkedList<int> numberOne, DataStructures.LinkedList<int> numberTwo)
        {
            string numberOneStr = ConvertLinkedListToString(numberOne);
            string numberTwoStr = ConvertLinkedListToString(numberTwo);
            numberOneStr = Reverse(numberOneStr);
            numberTwoStr = Reverse(numberTwoStr);
            int numberOneInt = Convert.ToInt32(numberOneStr);
            int numberTwoInt = Convert.ToInt32(numberTwoStr);
            int resultInt = numberOneInt + numberTwoInt;
            return ConvertIntToLinkedList(resultInt);
        }

        public DataStructures.LinkedList<int> ConvertIntToLinkedList(int number)
        {
            DataStructures.LinkedList<int> result = new DataStructures.LinkedList<int>();
            string numberStr = number.ToString();
            for (int i = numberStr.Length - 1; i >= 0; i--)
            {
                result.Insert(Convert.ToInt32(numberStr[i].ToString()));
            }
            return result;
        }

        public string Reverse(string s)
        {
            char[] charArray = s.ToCharArray();
            Array.Reverse(charArray);
            return new string(charArray);
        }

        private string ConvertLinkedListToString(DataStructures.LinkedList<int> linkedList)
        {
            StringBuilder result = new StringBuilder();
            if(linkedList != null && linkedList.Head != null)
            {
                DataStructures.Node<int> currentNode = linkedList.Head;
                while (currentNode != null)
                {
                    result.Append(currentNode);
                    currentNode = currentNode.Next;
                }
            }
            return result.ToString();
        }
    }
}
