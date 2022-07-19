using System;
using System.Text;

namespace CrackTheCodeInterview.DataStructures
{
    public class MyStack<T>
    {
        private T[] _elements;
        private int _top;
        private int _max;

        public MyStack(int size)
        {
            _elements = new T[size];
            _top = -1;
            _max = size;
        }

        public void Push(T item)
        {
            if(_top == _max - 1)
            {
                throw new StackOverflowException();
            }
            else
            {
                _elements[++_top] = item;
            }
        }

        public T Pop()
        {
            if (_top == -1)
            {
                throw new Exception("Stack is Empty");
            }
            else
            {
                return _elements[_top--];
            }
        }

        public T Peek()
        {
            if (_top == -1)
            {
                throw new Exception("Stack is Empty");
            }
            else
            {
                return _elements[_top];
            }
        }

        public override string ToString()
        {
            var sb = new StringBuilder();
            foreach (var item in _elements)
            {
                sb.AppendLine(item.ToString());
            }
            return sb.ToString();
        }
    }
}
