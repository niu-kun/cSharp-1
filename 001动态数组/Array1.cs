
using System;
using System.Text;

namespace _001动态数组
{
    public class Array1<T>
    {
        private T[] data;
        private int N;

        public Array1(int capacity)
        {
            data = new T[capacity];
            N = 0;
        }

        public Array1() : this(10) { }

        public int Capacity => data.Length;

        public int Count => N;

        public bool IsEmpty => N == 0;

        /// <summary>
        /// 添加元素
        /// </summary>
        /// <param name="index"></param>
        /// <param name="e"></param>
        public void Add(int index, T e)
        {
            if (index < 0 || index > N)
                throw new ArgumentException("数组索引越界");

            if (N == data.Length)
            {
                ResetCapacity(data.Length * 2);
            }

            for (int i = N - 1; i >= index; i--)
                data[i + 1] = data[i];

            data[index] = e;
            N++;
        }

        public void AddLast(T e) => Add(N, e);

        public void AddFirst(T e) => Add(0, e);

        /// <summary>
        /// 打印数组
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            StringBuilder res = new StringBuilder();
            //res.Append(string.Format("Array1: count = {0} capacity = {1}\n", N, data.Length));
            res.Append("[");
            for (int i = 0; i < N; i++)
            {
                res.Append(data[i]);
                if (i != N - 1)
                {
                    res.Append(", ");
                }
            }
            res.Append("]");

            return res.ToString();
        }

        /// <summary>
        /// 获取数组元素
        /// </summary>
        /// <param name="index"></param>
        /// <returns></returns>
        public T Get(int index)
        {
            if (index < 0 || index > N - 1)
            {
                throw new ArgumentOutOfRangeException("数组索引越界");
            }
            return data[index];
        }

        public T GetFirst() => Get(0);

        public T GetLast() => Get(N - 1);

        public void Set(int index, T e)
        {
            if (index < 0 || index > N - 1)
            {
                throw new ArgumentOutOfRangeException("数组索引越界");
            }
            data[index] = e;

        }

        public bool Contains(T e)
        {
            for (int i = 0; i < N; i++)
            {
                if (data[i].Equals(e))
                    return true;
            }
            return false;
        }

        public int IndexOf(T e)
        {
            for (int i = 0; i < N; i++)
            {
                if (data[i].Equals(e))
                    return i;
            }
            return -1;
        }

        public T RemoveAt(int index)
        {
            if (index < 0 || index > N - 1)
            {
                throw new ArgumentOutOfRangeException("数组索引越界");
            }

            T del = data[index];

            for (int i = index + 1; i < N; i++)
            {
                data[i - 1] = data[i];
            }
            // 注意维护 N
            N--;

            if (N == data.Length / 4)
            {
                ResetCapacity(data.Length / 2);
            }
            return del;
        }

        public T RemoveFirst()
        {
            return RemoveAt(0);
        }

        public T RemoveLast()
        {
            return RemoveAt(N - 1);
        }

        public void ResetCapacity(int newCapacity)
        {
            T[] newData = new T[newCapacity];
            for (int i = 0; i < N; i++)
            {
                newData[i] = data[i];
            }

            data = newData;
        }


    }
}
