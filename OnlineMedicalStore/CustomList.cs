using System;
using System.Collections;
using System.Linq;
using System.Threading.Tasks;

namespace onlineMedicalStore
{
    /// <summary>
    /// Customelist used to store the elements of array <see cref="CustomList<typeparamref name="Type"/>"/>
    /// </summary>
    /// <typeparam name="Type"></typeparam>
    public class CustomList<Type> : IEnumerable, IEnumerator
    {
        /// <summary>
        /// this field holds  the count of elements in array
        /// </summary>
        private int _count;
        /// <summary>
        /// thids field holds the size of the array
        /// </summary>
        private int _capacity;
        /// <summary>
        /// this property returns the elements count of instance of <see cref="CustomList<typeparamref name="Type"/>"/>
        /// </summary>
        /// <value></value>
        public int Count { get { return _count; } }
        /// <summary>
        /// this property return the size of array of instance of <see cref="CustomList<typeparamref name="Type"/>"/>
        /// </summary>
        /// <value></value>
        public int Capacity { get { return _capacity; } }
        /// <summary>
        /// array is defined which used to store values
        /// </summary>
        private Type[] _array;
        /// <summary>
        /// holds values of object at current index
        /// </summary>
        /// <value></value>
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
        /// <summary>
        /// CustomerList constructor used to create empty array with size 4 of <see cref="CustomList<typeparamref name="Type"/>"/>
        /// </summary>
        public CustomList()
        {
            _capacity = 4;
            _count = 0;
            _array = new Type[_capacity];
        }
        /// <summary>
        /// CustomerLis constructor used to create empty array with custom size of <see cref="CustomList<typeparamref name="Type"/>"/>
        /// </summary>
        /// <param name="size">size of array which needs to be created</param>
        public CustomList(int size)
        {
            _capacity = size;
            _count = 0;
            _array = new Type[_capacity];
        }
        /// <summary>
        /// Add method used to add the element in array
        /// </summary>
        /// <param name="element">elemen which is to be added</param>
        public void Add(Type element)
        {
            if (_count == _capacity)
            {
                GrowSize();
            }
            _array[_count++] = element;
        }
        /// <summary>
        /// Growsize method used to add array size if array is full
        /// </summary>
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
        /// <summary>
        /// AddRange method used to add array of elements at last
        /// </summary>
        /// <param name="elements">contains array of elements which need to added</param>
        public void AddRange(CustomList<Type> elements)
        {
            _capacity = _count + elements.Count + 4;
            Type[] temp = new Type[_capacity];
            for (int i = 0; i < _count; i++)
            {
                temp[i] = _array[i];
            }
            int k = 0;
            for (int i = _count; i < _count + elements.Count; i++)
            {
                temp[i] = elements[k++];
            }
            _array = temp;
            _count += elements.Count;
        }
        /// <summary>
        /// this field holds the position for traversing
        /// </summary>
        int position;
        /// <summary>
        /// GetEnumerator method used to return the object
        /// </summary>
        /// <returns></returns>
        public IEnumerator GetEnumerator()
        {
            position = -1;
            return (IEnumerator)this;
        }
        /// <summary>
        /// this method checks whether nextt element present or not
        /// </summary>
        /// <returns>Returns true if present else false</returns>
        public bool MoveNext()
        {
            if (position < _count - 1)
            {
                position++;
                return true;
            }
            Reset();
            return false;
        }
        /// <summary>
        /// Reset position to -1
        /// </summary>
        public void Reset()
        {
            position = -1;
        }
        /// <summary>
        /// Returns the values of the current objec index
        /// </summary>
        /// <value></value>
        public object Current
        {
            get
            {
                return _array[position];
            }
        }
        /// <summary>
        /// this method finds the index of the element
        /// </summary>
        /// <param name="element">the index of element which needs to be found</param>
        /// <returns>Returns index of the element</returns>
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
        /// <summary>
        /// This method inserts element at particular position
        /// </summary>
        /// <param name="position">position at which needs to be inserted</param>
        /// <param name="element">element that needs to be inserted</param>
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
        /// <summary>
        /// this method removes element at particular position
        /// </summary>
        /// <param name="position">position of the element needs to be removed</param>
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
        /// <summary>
        /// this method removes the element
        /// </summary>
        /// <param name="element">the element which needs to be removed</param>
        /// <returns></returns>
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
    }
}