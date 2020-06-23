using System;
using System.Collections.Generic;
using System.Text;

namespace _003栈与队列
{
    class MaxPQ<E> : IQueue<E> where E : IComparable<E>
    {
        private MaxHeap<E> maxHeap;

        public MaxPQ(int capacity) => this.maxHeap = new MaxHeap<E>(capacity);

        public MaxPQ() => this.maxHeap = new MaxHeap<E>();
        

        public int Count => this.maxHeap.Count;

        public bool IsEmpty => this.maxHeap.IsEmpty;

        public E Dequeue() => this.maxHeap.RemoveMax();

        public void Enqueue(E e) => this.maxHeap.Insert(e);

        public E Peek() => this.maxHeap.Max();

        public override string ToString() => this.maxHeap.ToString();
    }
}
