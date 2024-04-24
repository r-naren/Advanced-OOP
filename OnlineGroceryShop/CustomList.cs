using System;
using System.Collections;
using System.Linq;
using System.Threading.Tasks;

namespace OnlineGroceryShop
{
    /// <summary>
    /// customList used to create a custome list
    /// </summary>
    /// <typeparam name="Type"></typeparam>
    public class CustomList<Type> : IEnumerable, IEnumerator
    {
        /// <summary>
        /// _capacity holds the size of array
        /// </summary>
        private int _capacity;
        /// <summary>
        /// _count holds count of elements in array
        /// </summary>
        private int _count;
        //2 fields as private for preventing access outside
        /// <summary>
        /// Read only property Capacity holds size of array
        /// </summary>
        /// <value>Returns capacity</value>
        public int Capacity { get { return _capacity; } }
        /// <summary>
        /// Read only property count holds number of elements in count
        /// </summary>
        /// <value>Returns count</value>
        public int Count { get { return _count; } }
        /// <summary>
        /// _array is declared which used to hold values
        /// </summary>
        private Type[] _array; // declaring values for array and Type[] is used for generic class
                               //indexer, this represents this object
        /// <summary>
        /// Thiss property used to return the values of the current object index
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
        /// CustomList constructor used to create a array of size 5
        /// </summary>
        public CustomList()
        {
            _capacity = 5;
            _count = 0;
            _array = new Type[_capacity];
        }
        /// <summary>
        /// This constructor creates array of specific size
        /// </summary>
        /// <param name="size">size of the array</param>
        public CustomList(int size)
        {
            _capacity = size;
            _count = 0;
            _array = new Type[_capacity];
        }
        /// <summary>
        /// Add method used to add a elemnt in array
        /// </summary>
        /// <param name="element">element to be added</param>
        public void Add(Type element)
        {
            if (_count == _capacity)
            {
                GrowSize();
            }
            _array[_count++] = element;
        }
        /// <summary>
        /// Growsize method used to increase size of array when array is full
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
        /// AddRange method used to add list of elements
        /// </summary>
        /// <param name="elements">list of elements which is to be added</param>
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
        /// <summary>
        /// position of the array for traversing
        /// </summary>
        int postion;
        /// <summary>
        /// this method used to return current object
        /// </summary>
        /// <returns></returns>
        public IEnumerator GetEnumerator()
        {  // for accesing list object
            postion = -1;
            return (IEnumerator)this;  // return number list object
        }
        /// <summary>
        /// this method checks whether next element is present or not
        /// </summary>
        /// <returns>Returns true if present else false</returns>
        public bool MoveNext()
        {  // in calls MoveNext
            if (postion < _count - 1)
            {
                postion++;
                return true;
            }
            Reset();
            return false;
        }
        /// <summary>
        /// Reset method is used to reset the position
        /// </summary>
        public void Reset()
        {
            postion = -1;
        }
        /// <summary>
        /// Returns the value from the current object
        /// </summary>
        /// <value></value>
        public object Current { get { return _array[postion]; } } // accessing current project


    }
}