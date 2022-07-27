using CrackTheCodeInterview.ArrayAndStrings;
using CrackTheCodeInterview.DataStructures;
using CrackTheCodeInterview.LinkedLists;
using CrackTheCodeInterview.StacksAndQueue;
using System;

namespace CrackTheCodeInterview
{
    public class Program
    {
        static void Main()
        {
            ThreePointSix threePointSix = new ThreePointSix();

            threePointSix.Enqueue(new Dog { Name = "Dog 1" });
            threePointSix.Enqueue(new Dog { Name = "Dog 2" });
            threePointSix.Enqueue(new Dog { Name = "Dog 3" });
            threePointSix.Enqueue(new Dog { Name = "Dog 4" });
            threePointSix.Enqueue(new Cat { Name = "Cat 1" });
            threePointSix.Enqueue(new Cat { Name = "Cat 2" });
            threePointSix.Enqueue(new Cat { Name = "Cat 3" });
            threePointSix.Enqueue(new Cat { Name = "Cat 4" });
            threePointSix.Enqueue(new Cat { Name = "Cat 5" });
            threePointSix.Enqueue(new Cat { Name = "Cat 6" });

            Console.WriteLine(threePointSix.Dequeue());
            Console.WriteLine(threePointSix.Dequeue<Cat>());
            Console.WriteLine(threePointSix.Dequeue());
            Console.ReadKey();
        }
    }
}
