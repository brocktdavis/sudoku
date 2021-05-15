using System;

namespace lib
{
    public class Pair<T>
    {
        private T _f;
        private T _s;

        public Pair(T first, T second) {
            _f = first;
            _s = second;
        }

        public T first { get { return _f; } }
        public T second { get { return _s; } }

    }
}
