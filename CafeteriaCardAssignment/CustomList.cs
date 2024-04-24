
using System;
using System.Collections.Generic;

namespace CafeteriaCardAssignment;
/// <summary>
/// CustomList class is used to create and list of instance of <see cref="CustomList<typeparamref name="Type"/>>
/// </summary>
/// <typeparam name="Type"></typeparam> 
public partial class CustomList<Type>
{
    /// <summary>
    /// _capacity files is used to store size of the list 
    /// </summary>
    private int _capacity;
    /// <summary>
    /// _count is used to store the count of the elements in the list
    /// </summary> 
    private int _count;
    //2 fields as private for preventing access outside
    /// <summary>
    /// Capacity property is read only property of instance of <see cref="CustomList<typeparamref name="Type"/>>
    /// </summary> 
    /// <value></value>
    public int Capacity { get { return _capacity; } }
    /// <summary>
    /// Count property is read only property of instance of <see cref="CustomList<typeparamref name="Type"/>>
    /// </summary> 
    /// <value></value>
    public int Count { get { return _count; } }
    /// <summary>
    /// _array is used to store the elements
    /// </summary>
    private Type[] _array; // declaring values for array and Type[] is used for generic class
                           //indexer, this represents this object
    /// <summary>
    /// value of the object is property of instance of <see cref="CustomList<typeparamref name="Type"/>>
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
    /// CustomList contructor used to create the _array 
    /// </summary>
    public CustomList()
    {
        _capacity = 5;
        _count = 0;
        _array = new Type[_capacity];
    }
    /// <summary>
    /// CustomeList constructor used to create _array of specific size
    /// </summary>
    /// <param name="size">Size of the list needs to be created</param>
    public CustomList(int size)
    {
        _capacity = size;
        _count = 0;
        _array = new Type[_capacity];
    }
    /// <summary>
    /// Add the element in the _array
    /// </summary>
    /// <param name="element">Element which is to be added in list</param>
    public void Add(Type element)
    {
        if (_count == _capacity)
        {
            GrowSize();
        }
        _array[_count++] = element;
    }
    /// <summary>
    /// Grow the array size if necessary
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
    /// AddRange method is used to add list of elements
    /// </summary>
    /// <param name="elements">Contains list of elements which is to be added</param>
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
    /// Contains method checks if the element is present or not
    /// </summary>
    /// <param name="element"></param>
    /// <returns>Return true if element present else false</returns>
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
    /// <summary>
    /// IndexOf method used to find the index of given element
    /// </summary>
    /// <param name="element">Find the index of this element</param>
    /// <returns>Returns the element position </returns>
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
    /// Insert method inserts the element at praticular position
    /// </summary>
    /// <param name="position">position at which element needs to be inserted</param>
    /// <param name="element">element which is to be inserted</param>
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
    /// RemoveAt method is used to remove the element from particular position
    /// </summary>
    /// <param name="position">position to remove the element</param> 
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
    /// Remove method used to remove the element if present
    /// </summary>
    /// <param name="element">The elment which is to be inserted</param>
    /// <returns>Rtuen true if element is removed</returns>
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
    /// <summary>
    /// Reverse method is used to reverse the list
    /// </summary> 
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
    /// <summary>
    /// InsertRange method inserts range of elements at particular position
    /// </summary>
    /// <param name="position">postion at which needs to be inserted</param>
    /// <param name="elements">elements that needs to be inserted</param>
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
    /// <summary>
    /// sort method is used to sort the array
    /// </summary>
    public void Sort()
    {
        for (int i = 0; i < _count - 1; i++)
        {
            for (int j = 0; j < _count - i - 1; j++)
            {
                
                if (IsGreater(_array[j], _array[j + 1]))
                {
                    Type temp = _array[j];
                    _array[j] = _array[j + 1];
                    _array[j + 1] = temp;
                }
            }
        }
    }
    /// <summary>
    /// IsGreater compare the values of 2 values and say which is greater
    /// </summary>
    /// <param name="value1"></param>
    /// <param name="value2"></param>
    /// <returns></returns>
    public bool IsGreater(Type value1, Type value2)
    {
        int result = Comparer<Type>.Default.Compare(value1, value2); // comparer<Type> is used for comparing object
                                                                     //value1 is greater =1, value1 is less = -1
        if (result >= 0)
        {
            return true;
        }
        return false;
    }


}