﻿
using System;
using System.Collections.Generic;
using System.Runtime.InteropServices.ComTypes;
using System.Text;

namespace _010优先队列和堆排序
{
    class MaxHeap<E> where E : IComparable<E>
    {
        private E[] heap;
        private int N;

        public MaxHeap(int capacity)
        {
            this.heap = new E[capacity + 1];
            N = 0;
        }

        public MaxHeap() : this(10) { }


        public int Count => this.N;

        public bool IsEmpty => this.N == 0;



        // 往堆中插入元素
        public void Insert(E e)
        {
            if (N == (heap.Length - 1))
                ResetCapacity(2 * heap.Length);

            heap[N + 1] = e;
            N++;
            Swim(N);
        }
        //元素上游
        private void Swim(int k)
        {
            while (k > 1 && heap[k].CompareTo(heap[k / 2]) > 0)
            {
                Swap(k, k / 2);
                k /= 2;
            }
        }

        private void Swap(int i, int j)
        {
                E t = heap[i];
                heap[i] = heap[j];
                heap[j] = t;
        }

        //删除堆顶元素
        public E RemoveMax()
        {
            if (IsEmpty)
                throw new ArgumentException("堆为空！");
            Swap(1, N);
            E max = heap[N];
            heap[N] = default;
            N--;

            Sink(1);

            if (N == (heap.Length - 1) / 4)
                ResetCapacity(heap.Length / 2);

            return max;
        }
        //元素下沉
        private void Sink(int k)
        {
            while (2 * k <= N)
            {
                int j = 2 * k;

                if (j + 1 <= N && heap[j + 1].CompareTo(heap[j]) > 0) j++;

                if (heap[k].CompareTo(heap[j]) >= 0) break;

                Swap(k, j);

                k = j;
            }
        }
        //查看最大值
        public E Max()
        {
            if (IsEmpty)
                throw new ArgumentException("堆为空！");
            return heap[1];
        }
        //调整数组容量的大小
        private void ResetCapacity(int newCapacity)
        {
            E[] newHeap = new E[newCapacity];
            for (int i = 0; i < N; i++)
                newHeap[i] = heap[i];

            heap = newHeap;
        }
        //输出数组类的信息
        public override string ToString()
        {
            StringBuilder sr = new StringBuilder();
            sr.Append("[");
            for (int i = 1; i <= N; i++)
            {
                sr.Append(heap[i]);
                if (i != N)
                    sr.Append(", ");
            }
            sr.Append("]");

            return sr.ToString();
        }

    }
}
