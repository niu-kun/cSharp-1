using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading;
using Microsoft.VisualBasic;

namespace _003栈与队列
{
    class Array2<E>
    {
        private E[] data;
        private int first;
        private int last;
        private int N;

        public Array2(int capacity)
        {
            this.data = new E[capacity];
            this.N = capacity;

            first = 0;
            last = 0;
            N = 0;
        }

        public Array2() : this(10) { }

        public int Count => this.N;

        public bool IsEmpty => this.N == 0;

        public void AddLast(E e)
        {
            if (N==data.Length)
                ResetCapacity(2*N);

            data[last] = e;
            last = (last + 1) % data.Length;
            N++;
        }

        public E RemoveFirst()
        {
            if (IsEmpty)
            {
                throw new ArgumentException("数组为空");
            }
            E ret = data[first];
            data[first] = default;
            first = (first + 1) % data.Length;
            N--;
            if (N==data.Length/4)
                ResetCapacity(data.Length / 2);

            return ret;
        }

        public E GetFirst()
        {
            if (IsEmpty)
            {
                throw new ArgumentException("数组为空");
            }
            return data[first];
        }

        public void Set(int index, E e)
        {
            if (index < 0 || index >= N)
            {
                throw new ArgumentException("非法索引");
            }
            data[index] = e;
        }

        private void ResetCapacity(int capacity)
        {
            E[] newData = new E[capacity];
            
            for (int i = 0; i < N; i++)
                newData[i] = data[(first+1)%data.Length];
            data = newData;
            first = 0;
            last = N;
        }

        public override string ToString()
        {
            StringBuilder res = new StringBuilder();
            res.Append("[");
            for (int i = 0; i < N; i++)
            {
                res.Append(data[(first + i) % data.Length]);
                if ((first + i + 1) != last)
                    res.Append(", ");
            }
            res.Append("]");
            return res.ToString();
        }
    }
}
