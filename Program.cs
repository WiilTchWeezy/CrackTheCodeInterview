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
            FivePointOne fivePointOne = new FivePointOne();
            Console.WriteLine(fivePointOne.BitInsertion("10000000000", "10011", 2, 6));
            Console.ReadKey();
        }
    }
}
