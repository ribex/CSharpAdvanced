using System;

namespace Generics
{
    // where T : IComparable
    // where T : Product
    // where T : struct
    // where T : class
    // where T : new() <---- (default constructor)
    public class Utilities<T> where T : IComparable, new()
    {
        public int Max(int a, int b)
        {
            return a > b ? a : b;
        }

        public void DoSomething(T value)
        {
            var obj = new T();
        }

        // generic method, requires constraint of IComparable
        public T Max(T a, T b)
        {
            return a.CompareTo(b) > 0 ? a : b;
        }
    }
}