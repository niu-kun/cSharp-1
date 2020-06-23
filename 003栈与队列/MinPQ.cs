using System;
using System.Collections.Generic;
using System.Text;

namespace _003栈与队列
{
    class MinPQ<E> : IQueue<E> where E : IComparable<E>
    {
        private MinHeap<E> minHeap;

        public MinPQ(int capacity) => this.minHeap = new MinHeap<E>(capacity);

        public MinPQ() => this.minHeap = new MinHeap<E>();


        public int Count => this.minHeap.Count;

        public bool IsEmpty => this.minHeap.IsEmpty;

        public E Dequeue() => this.minHeap.RemoveMin();

        public void Enqueue(E e) => this.minHeap.Insert(e);

        public E Peek() => this.minHeap.Min();


        public override string ToString() => this.minHeap.ToString();
    }
}
