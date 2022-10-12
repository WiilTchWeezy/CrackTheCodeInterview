using System.Collections.Generic;

namespace CrackTheCodeInterview.StacksAndQueue
{
    public class ThreePointFour
    {
    }

    public class QueueUsingStack
    {
        private Stack<int> _stackNewest;
        private Stack<int> _stackOldest;

        public QueueUsingStack()
        {
            _stackNewest = new Stack<int>();
            _stackOldest = new Stack<int>();
        }

        public int Size { get { return _stackNewest.Count + _stackOldest.Count; } }

        public void Enqueue (int value)
        {
            _stackNewest.Push(value);
        }

        private void ShiftStacks()
        {
            if(_stackOldest.Count == 0)
            {
                while(_stackNewest.Count != 0)
                {
                    _stackOldest.Push(_stackNewest.Pop());
                }
            }
        }

        public int Peek()
        {
            ShiftStacks();
            return _stackOldest.Peek();
        }

        public int DeQueue()
        {
            ShiftStacks();
            return _stackOldest.Pop();
        }
    }
}
