using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _DataStructure.HashTable
{
    internal class _00_HashTable<TKey, TValue>
    {
        private List<KeyValuePair<TKey, TValue>> _storedPairs = new();

        public void Push(TKey key, TValue value)
        {
            _storedPairs.Add(new KeyValuePair<TKey, TValue>(key, value));
        }

        public TValue Get(TKey key)
        {
            foreach(var pair in _storedPairs)
            {
                if(EqualityComparer<TKey>.Default.Equals(pair.Key, key))
                    return pair.Value;
            }

            return default;
        }
    }
}
