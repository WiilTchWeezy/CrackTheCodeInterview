using System;
using System.Collections.Generic;
using System.Text;

namespace CrackTheCodeInterview.DataStructures
{
    public class QueueUsingStacks<T> where T : IComparable
    {
        private MyStack<T> _stack1;
        private MyStack<T> _stack2;

        public QueueUsingStacks(int size)
        {
            _stack1 = new MyStack<T>(size);
            _stack2 = new MyStack<T>(size);
        }

        public void EnQueue(T item)
        {
            while(_stack1.IsEmpty == false)
            {
                _stack2.Push(_stack1.Pop());
            }

            _stack1.Push(item);

            while(_stack2.IsEmpty == false)
            {
                _stack1.Push(_stack2.Pop());
            }
        }

        public T DeQueue()
        {
            return _stack1.Pop();
        }
    }
}
