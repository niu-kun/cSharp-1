using System;
using System.Collections.Generic;
using System.Text;

namespace _003栈与队列
{
    class LinkedList2Queue<E> : IQueue<E>
    {
        private LinkedList2<E> list;

        public LinkedList2Queue()
        {
            this.list = new LinkedList2<E>();
        }


        public int Count => this.list.Count;

        public bool IsEmpty => this.list.IsEmpty;

        public E Dequeue() => this.list.RemoveFirst();

        public void Enqueue(E e) => this.list.AddLast(e);

        public E Peek() => this.list.GetFirst();

        public override string ToString() => 
            "Queue'front: " + this.list.ToString() + " tail";
    }
}
