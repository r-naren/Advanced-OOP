using System;

using System.Collections;
using System.Threading.Tasks;

namespace Dictionary
{
    public class CustomDictionary<TKey, TValue> : IEnumerable, IEnumerator
    {
        private int _count;
        private int _capacity;
        public int Count{get{return _count;}}
        public TValue this[TKey key]{
            get {
                TValue value= default(TValue);
                LinearSearch(key, out value);
                return value;
            }
            set{
                int position = LinearSearch(key, out TValue value2);
                if(position>-1){
                    _array[position].Value = value;
                }
            }
        }
        private KeyValue<TKey,TValue>[] _array;
        public CustomDictionary(){
            _count= 0;
            _capacity = 4;
            _array = new KeyValue<TKey, TValue>[_capacity];
        }
        public CustomDictionary(int size){
            _count= 0;
            _capacity = size;
            _array = new KeyValue<TKey, TValue>[_capacity];
        }
        public void Add(TKey key, TValue value){
            if(_capacity == _count){
                GrowSize();
            }
            int position = LinearSearch(key, out TValue value2);
            if(position ==-1){
                KeyValue<TKey, TValue> data = new KeyValue<TKey, TValue>();
                data.Key = key;
                data.Value = value;
                _array[_count++] = data;
            }
            
        }
        void GrowSize(){
            _capacity *=2;
            KeyValue<TKey, TValue>[] temp = new KeyValue<TKey, TValue>[_capacity];
            for(int i=0;i<_count;i++){
                temp[i] = _array[i];
            }
            _array = temp;
        }
        int LinearSearch(TKey key,out TValue value){
            int position =-1;
            value = default(TValue);
            for(int i=0;i<_count;i++){
                if(key.Equals(_array[i].Key)){
                    position = i;
                    value = _array[i].Value;
                    break;
                }
            }
            return position;
        }
        int position;
        public IEnumerator GetEnumerator(){
            position = -1;
            return (IEnumerator) this;
        }
        public bool MoveNext(){
            if(position<_count-1){
                position++;
                return true;
            }
            Reset();
            return false;
        }
        public void Reset(){
            position = -1;
        }
        public object Current{get{return _array[position];}}

    }
}