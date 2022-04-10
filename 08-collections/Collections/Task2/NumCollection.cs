using System;
using System.Collections.Generic;
using System.Collections;
using System.Text;

namespace Task2
{
    public class Num<T> : IEnumerable<T>
    {
        protected List<T> _ints1 = new List<T>();
        public List<T> inits
        {
            get
            {
                return _ints1;
            }
        }
        public Num(T[] array)
        {

            for (int i = 0; i < array.Length; i++)
            {
                _ints1.Add(array[i]);
            }
        }
        IEnumerator IEnumerable.GetEnumerator()
        {
            return _ints1.GetEnumerator();
        }
        IEnumerator<T> IEnumerable<T>.GetEnumerator()
        {
            return (IEnumerator<T>)_ints1.GetEnumerator();
        }
        T[] _array = Array.Empty<T>();
        int index;
        public void CopyTo(T[] array, int index)
        {
            _array = array;
            this.index = index;
            _ints1.CopyTo(_array, index);
        }
        public int Length()
        {
            return _ints1.Count;

        }
    }
}