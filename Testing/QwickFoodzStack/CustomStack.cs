using System;
using System.Collections;
using System.Linq;
using System.Threading.Tasks;

namespace QwickFoodzStack
{
    public class CustomStack<Type> : IEnumerable, IEnumerator
    {
        private int _capacity;
        private int _top;
        private Type[] _array;
        public int Capacity { get { return _capacity; } }
        public int Count { get { return _top + 1; } }
        public Type this[int index]{
            get{
                return _array[index];
            }
        }
        public CustomStack()
        {
            _top = -1;
            _capacity = 4;
            _array = new Type[_capacity];
        }
        public CustomStack(int size)
        {
            _top = -1;
            _capacity = size;
            _array = new Type[_capacity];
        }
        public void Add(Type element)
        {
            if (_top + 1 == _capacity)
            {
                GrowSize();
            }
            _array[++_top] = element;
        }
        void GrowSize()
        {
            _capacity *= 2;
            Type[] temp = new Type[_capacity];
            for (int i = 0; i <= _top; i++)
            {
                temp[i] = _array[i];
            }
            _array = temp;
        }
        public Type Pop()
        {
            return _array[_top--];
        }
        public void PushRange(CustomStack<Type> elements)
        {
            _capacity = _top + elements.Count + 5;
            Type[] temp = new Type[_capacity];
            int i;
            for (i = 0; i <= _top; i++)
            {
                temp[i] = _array[i];
            }
            for (; elements.Count > 0; i++)
            {
                temp[i] = elements.Pop();
            }
            _top = i-1;
            _array = temp;

        }
        int position;
        public IEnumerator GetEnumerator()
        {
            position = _top + 1;
            return (IEnumerator)this;
        }
        public bool MoveNext()
        {
            if (position > 0)
            {
                position--;
                return true;
            }
            Reset();
            return false;
        }
        public void Reset()
        {
            position = _top + 1;
        }
        public object Current
        {
            get
            {
                return _array[position];
            }
        }
    }
}