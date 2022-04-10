using System;
using System.Collections.Generic;
using System.Text;
using System.Collections;

namespace Task2
{
    public class DynamicArray<T> : IEnumerable<T>
    {
        IEnumerator IEnumerable.GetEnumerator()
        {
            return _ints1.GetEnumerator();
        }
        IEnumerator<T> IEnumerable<T>.GetEnumerator()
        {
            return (IEnumerator<T>)_ints1.GetEnumerator();
        }
        T[] _ints1 = Array.Empty<T>();
        public DynamicArray(Num<T> realisation)
        {
            T[] ints = new T[realisation.Length()];
            _ints1 = ints;
            realisation.CopyTo(_ints1, 0);
        }
        public DynamicArray()
        {
            T[] array = new T[8];
            _array = array;
        }
        public DynamicArray(int capacity)
        {
            T[] array = new T[capacity];
            _array = array;
        }
        public DynamicArray(T[] array)
        {

        }
        private T[] _array = Array.Empty<T>();
        public T this[int index]
        {
            get
            {
                if (index <= _array.Length)
                {
                    return _array[index];
                }
                else
                {
                    throw new ArgumentException("Error");
                }
            }
        }
        public void Add(T value)
        {
            for (int i = 0; i < _array.Length; i++)
            {
                if (_array[i].Equals(0))
                {
                    _array[i] = value;
                    return;
                }
            }
            var newArray = new T[_array.Length * 2];
            Array.Copy(_array, newArray, _array.Length);
            newArray[_array.Length] = value;
            _array = newArray;
        }
        public void AddRange(T[] value)
        {
            for (int i = 0; i < _array.Length; i++)
            {
                if (_array[i].Equals(0))
                {
                    var newArray = new T[i + value.Length];
                    Array.Copy(_array, newArray, i);
                    value.CopyTo(newArray, i);
                    _array = newArray;
                    break;
                }
            }
        }
        public void Insert(int indexnum, T element)
        {
            try
            {
                for (int i = 0; i < _array.Length; i++)
                {
                    if (i == indexnum)
                    {
                        var newArray = new T[_array.Length + 1];
                        Array.Copy(_array, newArray, i);
                        newArray[i] = element;
                        Array.Copy(_array, i, newArray, i + 1, _array.Length);
                        _array = newArray;
                        break;
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
            }
        }
        public bool Remove(T element)
        {
            int commin = 0;
            for (int i = 0; i < _array.Length; i++)
            {
                if (_array[i].Equals(element))
                {
                    Array.Clear(_array, i, i);
                    commin = 1;
                }
                if (commin == 1)
                {
                    _array[i] = _array[i + 1];
                }
                if (_array[i].Equals(0)) { break; }
            }
            if (commin == 1)

                return true;
            else
                return false;

        }
        public int Length
        {
            get
            {
                for (int i = 0; i < _array.Length; i++)
                {
                    if (_array[i].Equals(0))
                    {
                        return i - 1;
                    }
                }
                return _array.Length;
            }
        }
        public int Capacity
        {
            get
            {
                return _array.Length;
            }
        }
    }
}
