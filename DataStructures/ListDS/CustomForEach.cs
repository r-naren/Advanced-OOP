using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ListDS
{
    public partial class CustomList<Type> : IEnumerable, IEnumerator
    {
        int postion;
        public IEnumerator GetEnumerator()
        {  // for accesing list object
            postion = -1;
            return (IEnumerator)this;  // return number list object
        }
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
        public void Reset()
        {
            postion = -1;
        }
        public object Current { get { return _array[postion]; } } // accessing current project

    }
}