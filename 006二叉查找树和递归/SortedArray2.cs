
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace _006二叉查找树和递归
{

    //有序数组
    //存储的元素必须是可比较的。这样才能进行排序。
    //数据类型Key必须是实现了可比较的接口IComparable<Key>，才能进行元素的存储。
    //where Key:IComparable<Key> 对Key进行泛型约束，限定Key类型，不能是任意类型
    class SortedArray2<Key, Value> where Key : IComparable<Key>
    {
        private Key[] keys;
        private Value[] values;
        private int N;

        public SortedArray2(int capacity)
        {
            this.keys = new Key[capacity];
            this.values = new Value[capacity];
        }

        public SortedArray2() : this(10) { }

        public int Count => this.N;

        public bool IsEmpty => this.N == 0;

        // 判是否存在Key
        public int Rank(Key key)
        {
            int l = 0;
            int r = N - 1;

            while (l <= r)
            {
                // int mid = (l + r) / 2; 有可能溢出
                int mid = l + (r - l) / 2;

                if (key.CompareTo(keys[mid]) < 0)
                    r = mid - 1;
                else if (key.CompareTo(keys[mid]) > 0)
                    l = mid + 1;
                else
                    return mid;
            }
            return l;
        }

        public Value Get(Key key)
        {
            if (IsEmpty)
                throw new ArgumentException("数组为空");

            int i = Rank(key);

            if (i < N && keys[i].CompareTo(key) == 0)
                return values[i];

            else
                throw new ArgumentException("键" + key + "不存在");
        }


        public void Add(Key key, Value value)
        {
            int i = Rank(key);

            if (N == keys.Length)
                ResetCapacity(2 * N);

            // 去重
            if (i < N && keys[i].CompareTo(key) == 0)
            {
                values[i] = value;
                return;
            }
                

            for (int j = N - 1; j >= i; j--)
            {
                keys[j + 1] = keys[j];
                values[j + 1] = values[j];
            }

            keys[i] = key;
            values[i] = value;
            N++;
        }

        public void Remove(Key key)
        {
            if (IsEmpty)
                return;
            int i = Rank(key);
            if (i == N || keys[i].CompareTo(key) != 0)
                return;
            for (int j = i + 1; j < N; j++)
            {
                keys[j - 1] = keys[j];
                values[j - 1] = values[j];
            }

            N--;
            keys[N] = default;
            values[N] = default;

            if (N == keys.Length / 4)
                ResetCapacity(keys.Length / 2);
        }


        private void ResetCapacity(int newCapacity)
        {
            Key[] newKeys = new Key[newCapacity];
            Value[] newValues = new Value[newCapacity];
            for (int i = 0; i < N; i++)
            {
                newKeys[i] = keys[i];
                newValues[i] = values[i];
            }

            keys = newKeys;
            values = newValues;
        }

        public override string ToString()
        {
            StringBuilder res = new StringBuilder();
            res.Append("[");
            for (int i = 0; i < N; i++)
            {
                res.Append("{" + keys[i] + "," + values[i] + "}");
                if (i != N - 1)
                    res.Append(", ");
            }
            res.Append("]");

            return res.ToString();
        }

        public Key Min()
        {
            if (IsEmpty)
                throw new ArgumentException("数组为空");
            return keys[0];
        }

        public Key Max()
        {
            if (IsEmpty)
                throw new ArgumentException("数组为空");
            return keys[N - 1];
        }

        public Key Select(int k)
        {
            if (k < 0 || k > N)
                throw new ArgumentException("索引越界");
            return keys[k];
        }

        public bool Contains(Key key)
        {
            int i = Rank(key);

            if (i < N && keys[i].CompareTo(key) == 0)
                return true;
            return false;
        }

        // 找出小于或等于key的最大键
        public Key Floor(Key key)
        {
            int i = Rank(key);
            if (i < N && keys[i].CompareTo(key) == 0)
            {
                return keys[i];
            }
            if (i == 0)
                throw new ArgumentException("没有找到小于或等于" + key + "的最大键");
            else
                return keys[i - 1];
        }


        // 找出大于或等于key的最小键
        public Key Celling(Key key)
        {
            int i = Rank(key);
            if (i < N && keys[i].CompareTo(key) == 0)
            {
                return keys[i];
            }
            if (i == N)
                throw new ArgumentException("没有找到大于或等于" + key + "的最小键");
            else
                return keys[i];

        }
    }
}
