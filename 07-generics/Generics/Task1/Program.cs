using System;

namespace Task1
{
    class Program
    {
        static void Main(string[] args)
        {
            DynamicArray<int> array = new DynamicArray<int>();
            array.Add(5);
            array.Add(7);
            array.Add(2);
            array.Add(1);
            array.Add(3);
            array.Add(2);
            array.Add(1);
            array.Add(3);
            array.Add(7);
            array.Add(8);
            array.Remove(5);
            Console.WriteLine(array.Length);
            Console.WriteLine(array.Capacity);
            array.Insert(0, 5);
            int[] control = { 1, 2, 3 };
            array.AddRange(control);
            array.Remove(8);
        }
    }
}
