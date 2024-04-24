using System;
using System.Linq.Expressions;


namespace CustomStack
{
    public class Stack<Type>
    {
        private int _capacity;
        private int _top;
        public int Capacity { get { return _capacity; } }
        public int Count { get { return _top + 1; } }
        private Type[] _array;
        public Stack()
        {
            _top = -1;
            _capacity = 5;
            _array = new Type[_capacity];
        }
        public Stack(int size)
        {
            _top = -1;
            _capacity = size;
            _array = new Type[_capacity];
        }
        public void Push(Type element)
        {
            if (_top + 1 == _capacity)
            {
                GrowSize();
            }
            _array[++_top] = element;
        }
        void GrowSize()
        {
            _capacity *= 2;
            Type[] temp = new Type[_capacity];
            for (int i = 0; i < _top + 1; i++)
            {
                temp[i] = _array[i];
            }
            _array = temp;
        }
        public Type Pop()
        {
            if(_top==-1){
                return default(Type);
            }
            return _array[_top--];
        }
        public Type Peek()
        {
            if(_top==-1){
                return default(Type);
            }
            return _array[_top];
        }
        public bool Contains(Type element){
            if(_top==-1){
                return false;
            }
            for(int i=0;i<=_top;i++){
                if(_array[_top].Equals(element)){
                    return true;
                }
            }
            return false;
        }
        public void Clear(){
            _top = -1;
        }

    }
}