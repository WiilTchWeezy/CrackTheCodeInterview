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
            MyStack2OneArray<string> stack = new MyStack2OneArray<string>(10);
            stack.Push("A");
            stack.Push("B");
            stack.Push("C");
            stack.Push("D");
            stack.Push("E");

            stack.Push("F",2);
            stack.Push("G",2);
            stack.Push("H",2);
            stack.Push("I",2);
            stack.Push("J",2);


            
            Console.WriteLine(String.Format("Top Element from Stack 1 is  : {0}", stack.Pop(1)));
            Console.WriteLine(String.Format("Top Element from Stack 2 is  : {0}", stack.Pop(2)));

            Console.WriteLine("*************************");


            MyStackNOneArray<int> stackNOneArray = new MyStackNOneArray<int>(3, 10);

            stackNOneArray.Push(1,0);
            stackNOneArray.Push(2,0);
            stackNOneArray.Push(3,0);

            stackNOneArray.Push(4, 1);
            stackNOneArray.Push(5, 1);
            stackNOneArray.Push(6, 1);

            stackNOneArray.Push(7, 2);
            stackNOneArray.Push(8, 2);
            stackNOneArray.Push(9, 2);
            stackNOneArray.Push(10, 2);

            Console.WriteLine(String.Format("Top Element from Stack 1 is  : {0}", stackNOneArray.Pop(0)));
            Console.WriteLine(String.Format("Top Element from Stack 2 is  : {0}", stackNOneArray.Pop(1)));
            Console.WriteLine(String.Format("Top Element from Stack 3 is  : {0}", stackNOneArray.Pop(2)));

            Console.ReadKey();
        }
    }
}
