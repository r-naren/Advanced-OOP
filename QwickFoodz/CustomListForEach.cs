using System;
using System.Collections;
using System.Linq;
using System.Threading.Tasks;

namespace QwickFoodz
{
    public partial class CustomList<Type> : IEnumerable,IEnumerator
    {
        int position;
        public IEnumerator GetEnumerator()
        {
            position = -1;
            return (IEnumerator)this; // returns the current object
        } 
        public bool MoveNext()
        {
            if (position < _count - 1)
            {
                position++; // moves next element if present
                return true;
            }
            Reset();
            return false;
        } // moves next ends
        public void Reset()
        {
            position = -1;
        } // reset ends
        public object Current
        {
            get
            {
                return _array[position];
            }
        } // current property returns value of the object
    }
}