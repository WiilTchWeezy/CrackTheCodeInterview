using System;
using System.Text;

namespace CrackTheCodeInterview.DataStructures
{
    public class MyQueue<T>
    {
        private T[] _elements;
        private int _front;
        private int _end;
        private int _max;

        public MyQueue(int size)
        {
            _elements = new T[size];
            _front = 0;
            _end = -1;
            _max = size;
        }

        public void Enqueue(T item)
        {
            if (_end == _max - 1)
                throw new OverflowException();
            else
            {
                _elements[++_end] = item;
            }
        }

        public T Dequeue()
        {
            if (_front == _end + 1)
                throw new Exception("Queue is empty");
            else
            {
                return _elements[_front++];
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
