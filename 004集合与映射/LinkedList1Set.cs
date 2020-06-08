
using System;
using System.Runtime.CompilerServices;
using System.Text;
using _002链表;

namespace _004集合与映射
{
    public class LinkedList3Dictionary<E> : ISet1<E>
    {
        private LinkedList1<E> list;

        public LinkedList3Dictionary()
        {
            this.list = new LinkedList1<E>();
        }

        public int Count => this.list.Count;

        public bool IsEmpty => this.list.IsEmpty;

        public void Add(E e)
        {
            if (!this.list.Contains(e))
                this.list.AddFirst(e);
        }

        public bool Contains(E e) => this.list.Contains(e);

        public void Remove(E e)
        {
            if (!this.list.Contains(e))
                throw new ArgumentException("不存在此元素");
            this.list.Remove(e);
        }
    }
}
