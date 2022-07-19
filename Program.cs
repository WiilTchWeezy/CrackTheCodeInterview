using CrackTheCodeInterview.ArrayAndStrings;
using CrackTheCodeInterview.DataStructures;
using CrackTheCodeInterview.LinkedLists;
using System;

namespace CrackTheCodeInterview
{
    public class Program
    {
        static void Main()
        {
            LinkedList<string> linkedList = new LinkedList<string>();
            linkedList.Insert("A");
            linkedList.Insert("B");
            linkedList.Insert("C");
            linkedList.Insert("D");
            linkedList.Insert("E");
            linkedList.Insert("C");

            Console.WriteLine(linkedList);

            TwoPointEight twoPointSix = new TwoPointEight();
            var result = twoPointSix.ReturnCircularNode(linkedList);
            Console.WriteLine("*********");
            Console.WriteLine(result);
            Console.ReadKey();
        }
    }
}
