using System;
using System.Collections.Generic;
using System.Text;

namespace CrackTheCodeInterview.StacksAndQueue
{
    public class ThreePointOne
    {

    }

    public class FixedMultiStack
    {
        private int numberOfStacks = 3;
        private int stackCapacity;
        private int[] values;
        private int[] sizes;

        public FixedMultiStack(int stackSize)
        {
            stackCapacity = stackSize;
            values = new int[stackSize * numberOfStacks];
            sizes = new int[numberOfStacks];
        }

        public void Push(int stackNum, int value)
        {
            if (IsFull(stackNum))
                throw new StackOverflowException();
            sizes[stackNum]++;
            values[IndexOfTop(stackNum)] = value;
        }

        public int Pop(int stackNum)
        {
            if (IsEmpty(stackNum))
                throw new StackOverflowException();
            int topIndex = IndexOfTop(stackNum);
            int value = values[topIndex];
            values[topIndex] = 0;
            sizes[stackNum]--;
            return value;
        }

        public int Peek(int stackNum)
        {
            if (IsEmpty(stackNum))
                throw new StackOverflowException();

            return values[IndexOfTop(stackNum)];
        }

        public bool IsEmpty(int stackNum)
        {
            return sizes[stackNum] == 0;
        }

        public bool IsFull(int stackNum)
        {
            return sizes[stackNum] == stackCapacity;
        }

        private int IndexOfTop(int stackNum)
        {
            int offset = stackNum * stackCapacity;
            int size = sizes[stackNum];
            return offset + size - 1;
        }
    }
}
