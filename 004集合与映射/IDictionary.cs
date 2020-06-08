
using System;
using System.Collections.Generic;
using System.Text;

namespace _004集合与映射
{
    public interface IDictionary<Key, Value>
    {
        void Add(Key key, Value value);

        void Remove(Key key);

        void Set(Key key, Value newValue);

        Value Get(Key key);

        bool ContainsKey(Key key);

        int Count { get; }

        bool IsEmpty { get; }
    }
}
