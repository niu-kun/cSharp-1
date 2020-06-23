
using System;
using System.Collections.Generic;
using System.Text;

namespace _008哈希表
{
    class HashST1Set<Key> : ISet1<Key>
    {
        private readonly HashST1<Key> hashST1;

        public HashST1Set(int M) => this.hashST1 = new HashST1<Key>(M);

        public HashST1Set() => this.hashST1 = new HashST1<Key>();

        public int Count => this.hashST1.Count;

        public bool IsEmpty => this.hashST1.IsEmpty;

        public void Add(Key key) => this.hashST1.Add(key);

        public bool Contains(Key key) => this.hashST1.Contains(key);

        public void Remove(Key key) => this.hashST1.Remove(key);
    }
}
