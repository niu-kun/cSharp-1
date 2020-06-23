﻿
using System;
using System.Collections.Generic;
using System.Runtime.ExceptionServices;
using System.Text;

namespace _008哈希表
{
    class HashST2<Key, Value>
    {
        private LinkedList3<Key, Value>[] hashtable;
        private int N;
        private int M;

        public HashST2(int M)
        {
            this.M = M;
            this.N = 0;
            this.hashtable = new LinkedList3<Key, Value>[M];
            for (int i = 0; i < M; i++)
            {
                hashtable[i] = new LinkedList3<Key, Value>();
            }
        }

        public HashST2() : this(97) { }


        public int Count => this.N;

        public bool IsEmpty => this.N == 0;

        private int Hash(Key key)
        {
            return (key.GetHashCode() & 0x7fffffff) % M;
        }

        public void Add(Key key, Value value)
        {
            LinkedList3<Key, Value> list = hashtable[Hash(key)];
            if (list.Contains(key)) list.Set(key, value);
            else
            {
                list.Add(key, value);
                N++;
            }
        }

        public void Remove(Key key)
        {
            LinkedList3<Key, Value> list = hashtable[Hash(key)];
            if (list.Contains(key))
            {
                list.Remove(key);
                N--;
            }
        }

        public bool Contains(Key key)
        {
            LinkedList3<Key, Value> list = hashtable[Hash(key)];
            return list.Contains(key);
        }

        public Value Get(Key key)
        {
            LinkedList3<Key, Value> list = hashtable[Hash(key)];
            return list.Get(key);
        }

        public void Set(Key key, Value value)
        {
            LinkedList3<Key, Value> list = hashtable[Hash(key)];
            list.Set(key, value);
        }


    }
}
