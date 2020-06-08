using System;
using System.Collections.Generic;
using System.Text;
using _004集合与映射;

namespace _005有序数组和二分查找
{
    class SortedArray2Dictionary<Key, Value>: _004集合与映射.IDictionary<Key,Value> where Key : IComparable<Key>
    {

        private SortedArray2<Key, Value> s2;


        public SortedArray2Dictionary(int capacity) => s2 = new SortedArray2<Key, Value>(capacity);

        public SortedArray2Dictionary() : this(10) { }

        public int Count => this.s2.Count;

        public bool IsEmpty => this.s2.IsEmpty;

        public void Add(Key key, Value value) => this.s2.Add(key, value);

        public bool ContainsKey(Key key) => this.s2.Contains(key);

        public Value Get(Key key) => this.s2.Get(key);

        public void Remove(Key key) => this.s2.Remove(key);

        public void Set(Key key, Value newValue) => this.s2.Add(key, newValue);
    }
}
