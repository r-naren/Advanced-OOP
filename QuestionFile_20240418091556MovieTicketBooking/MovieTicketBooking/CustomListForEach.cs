using System;
using System.Collections;
using System.Linq;
using System.Threading.Tasks;

namespace MovieTicketBooking
{
    public partial class CustomList<Type> : IEnumerable, IEnumerator
    {
        int position; 
        public IEnumerator GetEnumerator()
        {
            return (IEnumerator)this; // returns current object
        }
        public bool MoveNext()
        {
            if (position < _count - 1)
            {
                position++; // increments if next element present
                return true;
            }
            Reset();
            return false;
        }
        public void Reset()
        {
            position = -1; // resets position 
        }
        public object Current { get { return _array[position]; } }
    }
}