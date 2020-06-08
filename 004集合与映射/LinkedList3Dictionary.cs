
using System;
using System.Collections.Generic;
using System.Text;

namespace _004集合与映射
{
    public class LinkedList3Dictionary<Key, Value> : IDictionary<Key, Value>
    {
        private LinkedList3<Key, Value> list = new LinkedList3<Key, Value>();

        public int Count => this.list.Count;

        public bool IsEmpty => this.list.IsEmpty;

        public void Add(Key key, Value value) => this.list.Add(key, value);

        public bool ContainsKey(Key key) => this.list.Contains(key);

        public Value Get(Key key) => this.list.Get(key);

        public void Remove(Key key) => this.list.Remove(key);

        public void Set(Key key, Value newValue) => this.list.Set(key, newValue);
    }
}
