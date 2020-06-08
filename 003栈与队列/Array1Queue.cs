using System;
using System.Collections.Generic;
using System.Text;
using _001动态数组;

namespace _003栈与队列
{
    class Array1Queue<E> : IQueue<E>
    {
        private Array1<E> arr;

        public Array1Queue()
        {
            this.arr = new Array1<E>();
        }

        public Array1Queue(int capacity)
        {
            this.arr = new Array1<E>(capacity);
        }

        public int Count => this.arr.Count;

        public bool IsEmpty => this.arr.IsEmpty;

        public void Enqueue(E e) => this.arr.AddLast(e);

        public E Dequeue() => this.arr.RemoveFirst();

        public E Peek() => this.arr.GetFirst();

        public override string ToString()
        {
            return "Queue: front " + this.arr.ToString() + " tail";
        }
    }
}
