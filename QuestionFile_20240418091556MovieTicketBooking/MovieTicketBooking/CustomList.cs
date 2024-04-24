using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MovieTicketBooking
{
    public partial class CustomList<Type>
    {
        //fields
        private int _capacity;
        private int _count;
        private Type[] _array;
        public int Capacity { get { return _capacity; } }
        public int Count { get { return _count; } }
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
        //constructor
        public CustomList()
        {
            _capacity = 4;
            _count = 0;
            _array = new Type[_capacity];
        }
        public CustomList(int size)
        {
            _capacity = size;
            _count = 0;
            _array = new Type[_capacity];
        }
        //methods
        public void Add(Type element)
        {
            if (_count == _capacity)
            {
                GrowSize();
            }
            for (int i = _count - 1; i >= 0; i--)
            {
                _array[i + 1] = _array[i];
            }
            _array[0] = element;
            _count++;
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
            _capacity = _count + elements.Count + 4;
            Type[] temp = new Type[_capacity];
            int i; 
            for (i = 0; i <= elements.Count; i++)
            {
                temp[i] = elements[i];
            } 
            _count += elements.Count; // increasing count by adding the insertedd element count
            int k = 0;
            for (; i < _count; i++)
            {
                temp[i] = _array[k++];
            }
            _array = temp;
        }
    }
}