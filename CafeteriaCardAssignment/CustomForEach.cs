using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CafeteriaCardAssignment;
/// <summary>
/// CustomList class is used to create list
/// </summary>
/// <typeparam name="Type"></typeparam>
public partial class CustomList<Type> : IEnumerable, IEnumerator
{
    /// <summary>
    /// position is used for indexing purpose
    /// </summary>
    int postion;
    /// <summary>
    /// GetEnumerator method is used for getting object
    /// </summary>
    /// <returns>Returns the object</returns>
    public IEnumerator GetEnumerator()
    {  // for accesing list object
        postion = -1;
        return (IEnumerator)this;  // return number list object
    }
    /// <summary>
    /// MoveNext method is to check whether the next element is present or not
    /// </summary>
    /// <returns>Returns true if next element is present else returns false</returns>
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
    /// Current property is readonly property
    /// </summary>
    /// <value>returns the values at position</value>
    public object Current { get { return _array[postion]; } } // accessing current project


}