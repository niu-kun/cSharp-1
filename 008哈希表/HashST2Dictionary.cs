
using System;
using System.Collections.Generic;
using System.Text;

namespace _008哈希表
{
    class HashST2Dictionary<Key, Value> : IDictionary<Key, Value>
    {
        private readonly HashST2<Key, Value> hashtable;

        public HashST2Dictionary(int M) => this.hashtable = new HashST2<Key, Value>(M);

        public HashST2Dictionary() => this.hashtable = new HashST2<Key, Value>();


        public int Count => this.hashtable.Count;

        public bool IsEmpty => this.hashtable.IsEmpty;

        public void Add(Key key, Value value) => this.hashtable.Add(key, value);

        public void Remove(Key key) => this.hashtable.Remove(key);

        public void Set(Key key, Value newValue) => this.hashtable.Set(key, newValue);

        public Value Get(Key key) => this.hashtable.Get(key);

        public bool ContainsKey(Key key) => this.hashtable.Contains(key);
    }
}
