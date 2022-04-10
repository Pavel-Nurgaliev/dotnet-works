using System;
using System.Collections.Generic;
using System.Linq;

namespace Task1
{
    // [1,2,3,4]
    // [1,3]
    interface ICol : IList<int>
    {

    }
    class Program
    {
        public static void RemoveEachSecondIte(IList<int> people)
        {
            LinkedList<int> p1 = new LinkedList<int>(people);
            LinkedListNode<int> node = p1.First;

            while (people.Count != 1)
            {
                p1.Remove(node.Next);
                node = node.Next;
                if (node == null || node.Next == null)
                {
                    node = p1.First;
                }
            }
            List<int> newp = new List<int>();
            var enp2 = people.GetEnumerator();
            while (people.Count != 1)
            {
                people = Enum(people);
            }

        }
        public static IList<int> Enum(IList<int> peop)
        {
            var newp = new List<int>();
            var enp = peop.GetEnumerator();
            while (enp.MoveNext() != false)
            {
                enp.MoveNext();
                newp.Add(enp.Current);
                enp.MoveNext();
            }
            return newp;
        }
        static void Main(string[] args)
        {
            int N = 10;
            LinkedList<int> people = new LinkedList<int>();
            List<int> people2 = new List<int>(N);
            for (int i = 1; i < N; i++)
            {
                people2.Add(i);
            }
            for (int i = 1; i < N; i++)
            {
                people.AddLast(i);
            }
            RemoveEachSecondIte(people2);
        }
    }
}
