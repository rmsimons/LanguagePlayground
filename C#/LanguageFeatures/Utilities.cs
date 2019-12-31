using System;

namespace LanguageFeatures
{
    class Utilities<T> where T : IComparable, new()
    {
        public Utilities()
        {
            var obj = new T();
        }
        public T Max(T a, T b)
        {
            return a.CompareTo(b) > 0 ? a : b;
        }
    }
}
