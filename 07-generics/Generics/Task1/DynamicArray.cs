using System;
using System.Collections.Generic;
using System.Text;

namespace Task1
{
    public class DynamicArray<T>
    {
        public DynamicArray()
        {
            T[] array = new T[8];
            _array = array;
        }
        public DynamicArray(int capacity)
        {
            _array = new T[capacity];
        }
        public DynamicArray(T[] array)
        {
            _array = new T[array.Length];
            Array.Copy(array, _array, array.Length);
        }
        private T[] _array = Array.Empty<T>();
        public T this[int index]
        {
            get
            {
                if (index <= _array.Length && index >= 0)
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
                if (!_array[i].Equals(0) && _array[i] != null)
                {
                    continue;
                }
                else
                {
                    _array[i] = value;
                    return;
                }
            }
            if (!_array[_array.Length - 1].Equals(0))
            {
                var newarr = new T[_array.Length * 2];
                Array.Copy(_array, newarr, _array.Length);
                newarr[_array.Length] = value;
                _array = newarr;
            }
        }
        public void AddRange(T[] value)
        {
            int freeelem = 0;
            for (int i = 0; i < _array.Length; i++)
            {
                if (_array[i].Equals(0) && !_array[i - 1].Equals(0))
                {
                    freeelem = 1;
                }
                else if (_array[i].Equals(0) && _array[i - 1].Equals(0))
                {
                    freeelem++;
                }
                else if (freeelem != value.Length && _array.Length - 1 == i)
                {
                    var newArray = new T[i + value.Length];
                    Array.Copy(_array, newArray, i);
                    value.CopyTo(newArray, i);
                    _array = newArray;
                    break;
                }
                if (freeelem == value.Length)
                {
                    Array.Copy(value, 0, _array, i - value.Length + 1, value.Length);
                    return;
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
                    Array.Clear(_array, i, 1);
                    commin = 1;
                }
                if (commin == 1 && i < _array.Length - 1)
                {
                    _array[i] = _array[i + 1];
                }
                if (_array[i + 1].Equals(0)) { break; }
            }
            if (commin == 1) return true;
            else
                return false;

        }
        public int Length
        {
            get
            {

                int length;
                return length = Capacity - (Capacity - (ControlLength() - 1));
            }
        }
        private int ControlLength()
        {
            for (int i = 0; i < _array.Length; i++)
            {
                if (_array[i].Equals(default(T)))
                {
                    return i;
                }
            }
            return _array.Length;
        }

        // [1,2,3,4,-,-] +
        // cap: 6
        // lastIndex: 4
        // length = cap - (cap - lastIndex)
        public int Capacity
        {
            get
            {
                return _array.Length;
            }
        }
    }
}
