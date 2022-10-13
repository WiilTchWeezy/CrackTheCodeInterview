using CrackTheCodeInterview.DataStructures;
using System;
using System.Collections.Generic;
using System.Text;

namespace CrackTheCodeInterview.StacksAndQueue
{
    public class ThreePointFive
    {
        public MyStack<int> OrderStack(MyStack<int> stack)
        {
            var auxStack = new MyStack<int>(stack.Size);
            int minValue = stack.Min();
            while (stack.IsEmpty == false)
            {
                if (stack.Peek() != stack.Min())
                {
                    auxStack.Push(stack.Pop());
                }
                else
                {
                    stack.Pop();
                }
            }
            if(auxStack.IsEmpty == false)
                auxStack = OrderStack(auxStack);
            auxStack.Push(minValue);
            return auxStack;
        }


    }
}
