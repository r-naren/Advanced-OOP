
using System;
using System.Collections.Generic;

namespace ListDS
{
    public partial class CustomList<Type>
    {
        private int _capacity;
        private int _count;
        //2 fields as private for preventing access outside
        public int Capacity { get { return _capacity; } }
        public int Count { get { return _count; } }
        private Type[] _array; // declaring values for array and Type[] is used for generic class
        //indexer, this represents this object
        public Type this[int index]
        {
            get
            {
                return _array[index];
            }
            set
            {
                _array[index] = value;
            }
        }
        public CustomList()
        {
            _capacity = 5;
            _count = 0;
            _array = new Type[_capacity];
        }
        public CustomList(int size)
        {
            _capacity = size;
            _count = 0;
            _array = new Type[_capacity];
        }
        public void Add(Type element)
        {
            if (_count == _capacity)
            {
                GrowSize();
            }
            _array[_count++] = element;
        }
        void GrowSize()
        {
            _capacity *= 2;
            Type[] temp = new Type[_capacity];
            for (int i = 0; i < _count; i++)
            {
                temp[i] = _array[i];
            }
            _array = temp;
        }
        public void AddRange(CustomList<Type> elements)
        {
            _capacity = _count + elements.Count + 5;
            Type[] temp = new Type[_capacity];
            for (int i = 0; i < _count; i++)
            {
                temp[i] = _array[i];
            }
            int k = 0;

            for (int i = _count; i < _count + elements.Count; i++)
            {
                //use indexer because this objects needs to be considered as array to print
                temp[i] = elements[k++]; // Cannot apply indexing[] to an object expression so using indexer for this
            }
            _array = temp;
            _count += elements.Count;

        }
        public bool Contains(Type element)
        {
            bool temp = false;
            foreach (Type data in _array)
            {
                if (data.Equals(element))
                {
                    temp = true;
                    break;
                }
            }
            return temp;
        }
        public int IndexOf(Type element)
        {
            int index = -1;
            for (int i = 0; i < _count; i++)
            {
                if (_array[i].Equals(element))
                {
                    index = i;
                    break;
                }
            }
            return index;
        }
        public void Insert(int position, Type element)
        {
            _capacity = _capacity + 5;
            Type[] temp = new Type[_capacity];

            for (int i = 0; i <= _count; i++)
            {
                if (i < position)
                {
                    temp[i] = _array[i];
                }
                else if (i == position)
                {
                    temp[i] = element;
                }
                else
                {
                    temp[i] = _array[i - 1];
                }
            }
            _count++;
            _array = temp;
        }
        public void RemoveAt(int position)
        {   // void return type used
            for (int i = 0; i < _count - 1; i++)
            {
                if (i >= position)
                {
                    _array[i] = _array[i + 1];
                }
            }
            _count--;
        }
        public bool Remove(Type element)
        {
            int position = IndexOf(element);
            if (position >= 0)
            {
                RemoveAt(position);
                return true;
            }
            return false;

        }
        public void Reverse()
        {
            Type[] temp = new Type[_capacity];
            int j = 0;
            for (int i = _count - 1; i >= 0; i--)
            {
                temp[i] = _array[j++];
            }
            _array = temp;
        }
        public void InsertRange(int position, CustomList<Type> elements)
        {
            _capacity = _count + elements.Count + 5;
            int i;
            Type[] temp = new Type[_capacity];
            for (i = 0; i < position; i++)
            {
                temp[i] = _array[i];
            }
            int j = 0;
            for (; i < position + elements.Count; i++)
            {
                temp[i] = elements[j++];
            }
            j = position;
            for (; i < _count + elements.Capacity; i++)
            {
                temp[i] = _array[j++];
            }
            _array = temp;
            _count += elements.Count;
        }
        public void Sort()
        {
            for (int i = 0; i < _count - 1; i++)
            {
                for (int j = 0; j < _count-i-1; j++)
                {
                    if (IsGreater(_array[j],_array[j+1]))
                    {
                        Type temp = _array[j];
                        _array[j] = _array[j+1];
                        _array[j+1] = temp;
                    }
                }
            }
        }
        public bool IsGreater(Type value1, Type value2){
            int result = Comparer<Type>.Default.Compare(value1,value2); // comparer<Type> is used for comparing object
            //value1 is greater =1, value1 is less = -1
            if(result>=0){
                return true;
            }
            return false;
        }

    }
}