using CrackTheCodeInterview.DataStructures;
using System;
using System.Collections.Generic;
using System.Text;

namespace CrackTheCodeInterview.LinkedLists
{
    public class TwoPointOne
    {
        public DataStructures.LinkedList<T> RemoveDups<T>(DataStructures.LinkedList<T> list)
        {
            Dictionary<T, int> keyValues = new Dictionary<T, int>();
            Node<T> currentNode = list.Head;
            int position = 0;
            while (currentNode != null)
            {
                if (keyValues.ContainsKey(currentNode.Data))
                {
                    list.DeleteAtIndex(position);
                    position--;
                }
                else
                {
                    keyValues.Add(currentNode.Data, position);
                }
                currentNode = currentNode.Next;
                position++;
            }
            return list;
        }


        #region BookSolution
        //BIG O O(N²) - Percorrendo a lista duas vezes por item para achar duplicados. (Sem usar buffer)
        public void DeleteDuplicates(DataStructures.LinkedList<int> list)
        {
            Node<int> currentNode = list.Head;
            while (currentNode != null)
            {
                Node<int> runner = currentNode;
                while (runner.Next != null)
                {
                    if (runner.Next.Data == currentNode.Data)
                    {
                        runner.Next = runner.Next.Next;
                    }
                    else
                    {
                        runner = runner.Next;
                    }
                }
                currentNode = currentNode.Next;
            }
        } 
        #endregion
    }
}
