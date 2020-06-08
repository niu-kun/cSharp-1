using System;
using System.Collections.Generic;
using System.Text;
using _002链表;

namespace _003栈与队列
{
    class LinkedList1Queue<E> : IQueue<E>
    {
        private LinkedList1<E> list;

        public LinkedList1Queue()
        {
            this.list = new LinkedList1<E>();
        }


        public int Count => this.list.Count;

        public bool IsEmpty => this.list.IsEmpty;

        public void Enqueue(E e) => this.list.AddLast(e);

        public E Dequeue() => this.list.RemoveFirst();

        public E Peek() => this.list.GetFirst();

        public override string ToString()
        {
            return "Queue: front " + this.list.ToString() + " tail";
        }
    }
}
