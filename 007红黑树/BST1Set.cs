
using System;
using System.Collections.Generic;
using System.Text;

namespace _007红黑树
{
    public class BST1Set<E> : ISet1<E> where E : IComparable<E>
    {
        private readonly BST1<E> bst;
        public BST1Set()
        {
            bst = new BST1<E>();
        }



        public int Count => this.bst.Count;

        public bool IsEmpty => this.bst.IsEmpty;

        public void Add(E e) => this.bst.Add(e);

        public bool Contains(E e) => this.bst.Contains(e);

        public void Remove(E e) => this.bst.Remove(e);

        public int MaxHeight() => this.bst.MaxHeight();
    }
}
