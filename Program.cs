using CrackTheCodeInterview.ArrayAndStrings;
using CrackTheCodeInterview.DataStructures;
using System;

namespace CrackTheCodeInterview
{
    public class Program
    {
        static void Main()
        {
            LinkedList<int> linkedList = new LinkedList<int>();
            linkedList.Insert(linkedList, 1);
            linkedList.Insert(linkedList, 2);
            linkedList.Insert(linkedList, 3);
            linkedList.Insert(linkedList, 4);
            linkedList.DeleteAtIndex(linkedList, 2);
            Console.WriteLine(linkedList);
            Console.ReadKey();
        }
    }
}
