
using System;
using System.Collections.Generic;
using System.Text;

namespace _007红黑树
{
    class RBT2Dictionary<Key, Value> : IDictionary<Key, Value> where Key : IComparable<Key>
    {
        private RBT2<Key, Value> rbt;

        public RBT2Dictionary() => this.rbt = new RBT2<Key, Value>();


        public int Count => this.rbt.Count;

        public bool IsEmpty => this.rbt.IsEmpty;

        public void Add(Key key, Value value) => this.rbt.Add(key, value);

        public bool ContainsKey(Key key) => this.rbt.Contains(key);

        public Value Get(Key key) => this.rbt.Get(key);

        public void Remove(Key key) => throw new NotImplementedException("待实现");

        public void Set(Key key, Value newValue) => this.rbt.Set(key, newValue);
    }
}
