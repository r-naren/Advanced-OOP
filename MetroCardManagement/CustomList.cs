using System;
using System.Collections;
using System.Linq;
using System.Reflection.Metadata;
using System.Runtime.CompilerServices;
using System.Threading.Tasks;

namespace MetroCardManagement
{
    // class
    /// <summary>
    /// This class is used to create the instance of <see cref="CustomList"/>
    /// </summary>
    /// <typeparam name="Type">Dynamic Type</typeparam> 
    public class CustomList<Type> : IEnumerable, IEnumerator
    {
        // declaring private fields
        /// <summary>
        /// _count variable is used to count the number of elements of instance of <see cref="CustomList"/>
        /// </summary>
        private int _count;
        /// <summary>
        /// _capacity is used to mention the size of the List of instance of <see cref="CustomList"/>
        /// </summary>
        private int _capacity;
        /// <summary>
        /// _array is of any type since its Generinc class and used to hold the elements of instance of <see cref="CustomList"/>
        /// </summary>
        private Type[] _array;
        //properties
        /// <summary>
        /// Capacity property returns the value of _capacity of instance of <see cref="CustomList"/>
        /// </summary>
        /// <value>Capacity of the list</value>
        public int Capacity { get { return _capacity; } }
        /// <summary>
        /// Count property returns the value of _count of instance of <see cref="CustomList"/>
        /// </summary>
        /// <value>Count of the list</value>
        public int Count { get { return _count; } }

        // indexer

        /// <summary>
        /// This returns the values from the object of instance of <see cref="CustomList"/>
        /// </summary>
        /// <param name="index">contains the index value</param>
        /// <returns>Returns the value at the index postion</returns>
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
        // constructor
        /// <summary>
        /// Constructor used to create the instance of <see cref="CustomList"/>
        /// </summary>
        public CustomList()
        {
            _count = 0;
            _capacity = 4;
            _array = new Type[_capacity];
        }

        // parameterized constructor
        /// <summary>
        /// This parametrized constructor creates instance of size of <see cref="CustomList"/>
        /// </summary>
        /// <param name="size">Constaines the size of the list</param>
        public CustomList(int size)
        {
            _count = 0;
            _capacity = size;
            _array = new Type[_capacity];
        }
        /// <summary>
        /// Add method used to add elements in the list <see cref="CustomList"/>
        /// </summary>
        /// <param name="element">Contains the element which we need to add</param>
        public void Add(Type element)
        {
            if (_count == _capacity)
            {
                GrowSize();
            }
            _array[_count++] = element;
        } // add method ends
        /// <summary>
        /// GrowSize method is used to grow the size of the list <see cref="CustomList"/>
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
        /// AddRange method is used the add a list of elements. <see cref="CustomList"/>
        /// </summary>
        /// <param name="elements">Contains the list of elements</param>
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
            _count += elements.Count;
            _array = temp;
        } // add range method ends
        int position;
        /// <summary>
        /// GetEnumerator method used to return the object of the list <see cref="CustomList"/>
        /// </summary>
        /// <returns>Returns the Enumerator object</returns> 
        public IEnumerator GetEnumerator()
        {
            position = -1;
            return (IEnumerator)this;
        }
        /// <summary>
        /// MoveNext Method used to check if next element is present and increment the position <see cref="CustomList"/>
        /// </summary>
        /// <returns>Returns true if next element present</returns>
        public bool MoveNext()
        {
            // checks if next element is present or not
            if (position < _count - 1)
            {
                position++;
                return true;
            }
            Reset();
            return false;
        }
        /// <summary>
        /// Reset method resets the position to -1.
        /// </summary> 
        public void Reset()
        {
            // reseting position to -1 
            position = -1;
        }
        /// <summary>
        /// Current Property has get method which return the current object value <see cref="CustomList"/>
        /// </summary>
        /// <value>return the values of the current object</value>
        public object Current
        {
            get
            {
                return _array[position]; // returning current object
            }
        }
        /// <summary>
        /// InsertAt method is used the add a element at respective position. <see cref="CustomList"/>
        /// </summary>
        /// <param name="position">Contains postion where we need to insert the element</param>
        /// <param name="element">Contains element to insert</param>
        /// <returns>Returns true if element is added else returns false</returns>
        public bool InsertAt(int position, Type element)
        {
            _capacity = _count + 4;
            Type[] temp = new Type[_capacity];
            if (position < _count)
            {
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
                    else{
                        temp[i] = _array[i-1];
                    }
                }
                _array = temp;
                _count++;
                return true;
            }
            return false;
        }
        /// <summary>
        /// RemoveAt method is used to remove element from the respective position.  <see cref="CustomList"/>
        /// </summary>
        /// <param name="position">Contains the position where we need to remove the element</param>
        /// <returns>Returns true if removed else returns false.</returns> 
        public bool RemoveAt(int position)
        {
            if (position < _count)
            {
                for (int i = 0; i < _count-1; i++)
                {
                    if (i >= position)
                    {
                        _array[i] = _array[i+1];
                    }
                }
                _count--;
                return true;
            }
            return false;
        }
        /// <summary>
        /// IndexOf method used to find index of a given element
        /// </summary>
        /// <param name="key">Containes the element that needs to be searched</param>
        /// <returns>Returns the first index of the key element. If not present returns -1</returns>
        public int IndexOf(Type key){
            int position = -1;
            for(int i=0;i<_count;i++){
                if(_array[i].Equals(key)){
                    position = i;
                    break;
                }
            }
            return position;
        }
        /// <summary>
        /// Reverse method is used to reverse the _array
        /// </summary> 
        public void Reverse(){
            Type[] temp = new Type[_capacity];
            int k = _count-1;
            for(int i=0;i<_count;i++){
                temp[i] = _array[k--];
            }
            _array = temp;
        }
        
    }
}