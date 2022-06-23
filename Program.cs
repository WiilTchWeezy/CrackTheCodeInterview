using CrackTheCodeInterview.ArrayAndStrings;
using CrackTheCodeInterview.DataStructures;
using System;

namespace CrackTheCodeInterview
{
    public class Program
    {
        static void Main()
        {
            var onePointFive = new OnePointFive();


            Console.WriteLine(onePointFive.OneOrZeroEditsLeft("pale", "ple"));
            Console.WriteLine(onePointFive.OneOrZeroEditsLeft("pales", "pale"));
            Console.WriteLine(onePointFive.OneOrZeroEditsLeft("pale", "bale"));
            Console.WriteLine(onePointFive.OneOrZeroEditsLeft("pale", "bake"));

            Console.ReadKey();
        }
    }
}
