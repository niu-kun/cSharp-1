
using System;
using System.Collections.Generic;
using System.Text;

namespace _003栈与队列
{
    class Array2Queue<E> : IQueue<E>
    {
        private Array2<E> arr;

        public Array2Queue(int capacity) => this.arr = new Array2<E>(capacity);

        public Array2Queue() => this.arr = new Array2<E>();

        public int Count => this.arr.Count;

        public bool IsEmpty => this.arr.IsEmpty;

        public E Dequeue() => this.arr.RemoveFirst();

        public void Enqueue(E e) => this.arr.AddLast(e);

        public E Peek() => this.arr.GetFirst();

        public override string ToString()
        {
            return "Queue: front" + this.arr.ToString() + " tail";
        }
    }
}
