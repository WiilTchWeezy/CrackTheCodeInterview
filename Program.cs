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
            MyStack<string> stack = new MyStack<string>(5);
            stack.Push("A");
            stack.Push("B");
            stack.Push("C");
            stack.Push("D");
            stack.Push("E");

            Console.WriteLine(stack);
            
            Console.WriteLine(stack.Pop());

            Console.WriteLine("*************************");



            Console.ReadKey();
        }
    }
}
