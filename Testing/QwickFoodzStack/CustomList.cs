using System;
using System.Collections;
using System.Linq;
using System.Threading.Tasks;

namespace QwickFoodzStack
{
    /// <summary>
    /// CustomerList class is used to create a list and store the element instance of <see cref="CustomList<typeparamref name="Type"/>>
    /// </summary>
    /// <typeparam name="Type"></typeparam>
    public partial class CustomList<Type> : IEnumerable, IEnumerator
    {
        //private fields
        /// <summary>
        /// Used for how much elements is there
        /// </summary>
        private int _count;
        /// <summary>
        /// contains thee capacity of the _array
        /// </summary>
        private int _capacity;
        /// <summary>
        /// defines the type of the _array
        /// </summary>
        private Type[] _array;
        // properties
        /// <summary>
        /// Count property is to know number of elements in the _array see cref="CustomList<typeparamref name="Type"/>>
        /// </summary>
        /// <value></value>
        public int Count { get { return _count; } }
        /// <summary>
        /// Capacity property reads the size of the _array see cref="CustomList<typeparamref name="Type"/>>
        /// </summary>
        /// <value></value>
        public int Capacity { get { return _capacity; } }
        /// <summary>
        /// this property refers object
        /// </summary>
        /// <param name="index">contains index at which the element needs to be returned</param>
        /// <returns>returns values at partical index</returns>
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
        //constrcutors
        /// <summary>
        /// CustomList creates an empty list with default size 4 of instance see cref="CustomList<typeparamref name="Type"/>>
        /// </summary>
        public CustomList()
        {
            _capacity = 4;
            _count = 0;
            _array = new Type[_capacity];
        }
        /// <summary>
        /// CustomList creates an empty list with specifed size of instance see cref="CustomList<typeparamref name="Type"/>>
        /// </summary>
        /// <param name="size"></param>
        public CustomList(int size)
        {
            _capacity = size;
            _count = 0;
            _array = new Type[_capacity];
        }
        /// <summary>
        /// Add method adds the element at last in the _array
        /// </summary>
        /// <param name="element">the elements which is to be added at last </param>
        /// // add method
        public void Add(Type element)
        {
            if (_count == _capacity)
            {
                GrowSize();
            }
            _array[_count++] = element;
        } // add method ends
        /// <summary>
        /// GrowSize method is used to grow the size of the array of _count equls _capacity
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
        } // grow size method ends
        /// <summary>
        /// AddRange method is used to append a list of elements at last 
        /// </summary>
        /// <param name="elements">cotains list of elements which need to be appended</param>
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
        } // add range method ends
        /// <summary>
        /// Insert method inserts element at particular position in _array
        /// </summary>
        /// <param name="position">postion at which the element needs to be inserted</param>
        /// <param name="element">The element which is to be inserted</param>
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
        } // insert method ends
        /// <summary>
        /// RemoveAt method removes the method at particular position
        /// </summary>
        /// <param name="position">The position element in _array which is to be removed</param>
        /// <returns>Returns true if the element is removed else false</returns> 
        public bool RemoveAt(int position)
        {
            if (position < _count)
            {

                for (int i = position; i < _count - 1; i++)
                {
                    _array[i] = _array[i + 1];
                }
                _count--;
                return true;
            }
            else
            {
                return false;
            }
        } // removeat ends
    }
}