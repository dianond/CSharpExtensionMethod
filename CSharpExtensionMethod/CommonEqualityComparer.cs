using System;
using System.Collections.Generic;

namespace Dianond.CSharpExtensionMethod
{
    public class CommonEqualityComparer<T, V> : IEqualityComparer<T>
    {
        private Func<T, V> keySelector;
        private IEqualityComparer<V> comparer;

        public CommonEqualityComparer(Func<T, V> keySelector, IEqualityComparer<V> comparer = null)
        {
            this.keySelector = keySelector;
            this.comparer = comparer ?? EqualityComparer<V>.Default;
        }

        public bool Equals(T x, T y)
        {
            return comparer.Equals(keySelector(x), keySelector(y));
        }

        public int GetHashCode(T obj)
        {
            return comparer.GetHashCode(keySelector(obj));
        }
    }
}
