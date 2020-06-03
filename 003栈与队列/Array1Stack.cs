
using System;
using System.Collections.Generic;
using System.Text;
using _001线性表;

namespace _003栈与队列
{
    class Array1Stack<E> : IStack<E>
    {
        private Array1<E> arr; // 此处实现栈的底层是动态数组

        public Array1Stack() => arr = new Array1<E>();

        public Array1Stack(int capacity) => arr = new Array1<E>(capacity);


        public int Count => this.arr.Count;

        public bool IsEmpty => this.arr.IsEmpty;

        public void Push(E e) => this.arr.AddLast(e);

        public E Pop() => this.arr.RemoveLast();

        public E GetPeek() => this.arr.GetLast();

        public override string ToString()
        {
            return "Statck: "+arr.ToString() + " top";
        }
    }
}
