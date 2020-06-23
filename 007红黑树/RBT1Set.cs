
using System;
using System.Collections.Generic;
using System.Text;

namespace _007红黑树
{
    public class RBT1Set<E> : ISet1<E> where E : IComparable<E>
    {
        private readonly RBT1<E> rbt1;

        public RBT1Set() => rbt1 = new RBT1<E>();

        public int Count => this.rbt1.Count;

        public bool IsEmpty => this.rbt1.IsEmpty;

        public void Add(E e) => this.rbt1.Add(e);

        public bool Contains(E e) => this.rbt1.Contains(e);

        public void Remove(E e) => throw new NotImplementedException("待实现");

        public int MaxHeight() => this.rbt1.MaxHeight();
    }
}
