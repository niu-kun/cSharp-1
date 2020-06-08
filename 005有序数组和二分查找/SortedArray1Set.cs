
using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;
using _004集合与映射;

namespace _005有序数组和二分查找
{
    class SortedArray2Dictionary<Key> : ISet1<Key> where Key:IComparable<Key>
    {
        private readonly SortedArray1<Key> s;

        public SortedArray2Dictionary(int capacity) => this.s = new SortedArray1<Key>(capacity);

        public SortedArray2Dictionary() : this(10) { }

        public int Count => this.s.Count;

        public bool IsEmpty => this.s.IsEmpty;

        public void Add(Key key) => this.s.Add(key);

        public bool Contains(Key key) => this.s.Contains(key);

        public void Remove(Key key) => this.s.Remove(key);
    }
}
