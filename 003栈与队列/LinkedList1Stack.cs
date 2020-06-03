using System;
using System.Collections.Generic;
using System.Text;
using _002链表;

namespace _003栈与队列
{
    class LinkedList1Stack<E> : IStack<E>
    {
        private LinkedList1<E> list; // 此处实现栈的底层是链表

        public LinkedList1Stack() => list = new LinkedList1<E>();

        public int Count => list.Count;

        public bool IsEmpty => list.IsEmpty;

        public void Push(E e) => this.list.AddFirst(e);

        public E Pop() => this.list.RemoveFirst();

        public E GetPeek() => this.list.GetFirst();

        public override string ToString()
        {
            return "Stack: "+list.ToString()+" Top";
        }
    }
}
