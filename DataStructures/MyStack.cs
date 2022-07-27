using System;
using System.Text;

namespace CrackTheCodeInterview.DataStructures
{
    public class MyStack<T> where T : IComparable
    {
        private T[] _elements;
        private T _min;
        private int _top;
        private int _max;

        public MyStack(int size)
        {
            _elements = new T[size];
            _top = -1;
            _max = size;
            _min = GetMaxValue();
        }

        public int Size { get { return _max; } }

        public bool IsFull
        {
            get
            {
                return _top == _elements.Length - 1;
            }
        }

        public bool IsEmpty
        {
            get
            {
                return _top == -1;
            }
        }

        public T GetMaxValue()
        {
            try
            {
                return (T)typeof(T).GetField("MaxValue").GetValue(null);
            }
            catch
            {
                return default(T);
            }
        }

        public void Push(T item)
        {
            if (_top == _max - 1)
            {
                throw new StackOverflowException();
            }
            else
            {
                if (_min != null)
                {
                    if (_min.CompareTo(item) >= 0)
                        _min = item;
                }
                else
                    _min = item;
                _elements[++_top] = item;
            }
        }

        public T Min()
        {
            return _min;
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

    public class MyStack2OneArray<T>
    {
        private T[] _elements;
        private int _topLeft;
        private int _topRight;
        private int _size;

        public MyStack2OneArray(int size)
        {
            _size = size;
            _elements = new T[size];
            _topLeft = -1;
            _topRight = size;
        }

        public void Push(T element, int stack = 1)
        {
            if (stack == 1)
            {
                if (_topLeft < _topRight - 1)
                {
                    _topLeft++;
                    _elements[_topLeft] = element;
                }
                else
                    throw new StackOverflowException();
            }
            else
            {
                if (_topLeft < _topRight - 1)
                {
                    _topRight--;
                    _elements[_topRight] = element;
                }
                else
                    throw new StackOverflowException();
            }
        }

        public T Pop(int stack)
        {
            if (stack == 1)
            {
                if (_topLeft >= 0)
                {
                    var element = _elements[_topLeft];
                    _topLeft--;
                    return element;
                }
                else
                {
                    throw new Exception("Stack is Empty");
                }
            }
            else
            {
                if (_topRight < _size)
                {
                    var element = _elements[_topRight];
                    _topRight++;
                    return element;
                }
                else
                {
                    throw new Exception("Stack is Empty");
                }
            }
        }
    }

    public class MyStackNOneArray<T>
    {
        private T[] _elements;
        private int[] _tops;
        private int[] _next;

        private int _size;
        private int _totalStacks;
        private int _free;


        public MyStackNOneArray(int totalStacks, int arraySize)
        {
            _totalStacks = totalStacks;
            _size = arraySize;
            _elements = new T[_size];
            _tops = new int[_totalStacks];
            _next = new int[_size];
            for (int i = 0; i < _totalStacks; i++)
            {
                _tops[i] = -1;
            }

            _free = 0;
            for (int i = 0; i < _size - 1; i++)
            {
                _next[i] = i + 1;
            }
            _next[_size - 1] = -1;
        }

        public virtual bool Full
        {
            get
            {
                return (_free == -1);
            }
        }

        public void Push(T item, int sn)
        {
            if (Full)
                throw new StackOverflowException();

            int i = _free;

            _free = _next[i];

            _next[i] = _tops[sn];
            _tops[sn] = i;

            _elements[i] = item;
        }

        public T Pop(int sn)
        {
            if (isEmpty(sn))
                throw new Exception("Stack is Empty");

            int i = _tops[sn];

            _tops[sn] = _next[i];

            _next[i] = _free;
            _free = i;

            return _elements[i];
        }

        private bool isEmpty(int sn)
        {
            return (_tops[sn] == -1);
        }
    }

    public class StackOfStacks<T> where T : IComparable
    {

        MyStack<T>[] _stacks;
        int _currentStack = 0;
        int _stackSize;
        public StackOfStacks(int stacksSize)
        {
            _stackSize = stacksSize;
            _stacks = new MyStack<T>[stacksSize];
        }

        public void Push(T element)
        {
            if (_currentStack > _stacks.Length - 1)
            {
                var stacksOut = new MyStack<T>[_stacks.Length * 2];
                Array.Copy(_stacks, stacksOut, _stacks.Length);
                _stacks = stacksOut;
                Push(element);
            }
            if (_stacks[_currentStack] == null)
            {
                _stacks[_currentStack] = new MyStack<T>(_stackSize);
                _stacks[_currentStack].Push(element);
            }
            else
            {
                if (_stacks[_currentStack].IsFull)
                {
                    _currentStack++;
                    Push(element);
                }
                else
                {
                    _stacks[_currentStack].Push(element);
                }
            }
        }

        public T Pop()
        {
            if (_stacks[_currentStack] == null)
                throw new Exception("Stack is Empty");

            if (_stacks[_currentStack].IsEmpty)
            {
                _currentStack--;
                Pop();
            }
            return _stacks[_currentStack].Pop();
        }


        public T Pop(int index)
        {
            if (_stacks[index] == null || _stacks[index].IsEmpty)
                throw new Exception("Stack is Empty");

            return _stacks[index].Pop();
        }


    }
}
