
using System;
using System.Collections.Generic;
using System.Net.NetworkInformation;
using System.Text;

namespace _003栈与队列
{
    class LinkedList2<E>
    {
        class Node
        {
            public E e; // 节点存储的元素
            public Node next; // 下一个节点的引用（引用）

            public Node(E e)
            {
                this.next = null;
                this.e = e;
            }

            public Node(E e, Node node)
            {
                this.next = node;
                this.e = e;
            }

            public override string ToString()
            {
                return e.ToString(); 
            }
        }
        private Node head;
        private Node tail;
        private int N;

        public LinkedList2()
        {
            this.head = null;
            this.tail = null;
            N = 0;
        }

        public int Count => N;

        public bool IsEmpty => N == 0;

        public void AddLast(E e)
        {
            Node node = new Node(e);

            if (IsEmpty)
            {
                this.head = node;
                this.tail = node;
            }
            else
            {
                tail.next = node;
                tail = node;
            }
            N++;
        }

        public E RemoveFirst()
        {
            if (IsEmpty)
            {
                throw new ArgumentException("链表为空");
            }

            E e = head.e;
            head = head.next;

            N--;

            if (head == null)
            {
                tail = null;
            }
            return e;
        }

        public E GetFirst()
        {
            if (IsEmpty)
            {
                throw new ArgumentException("链表为空");
            }

            return head.e;
        }

        public override string ToString()
        {
            StringBuilder res = new StringBuilder();
            Node cur = head;
            while (cur != null)
            {
                res.Append(cur + "->");
                cur = cur.next;
            }
            res.Append("Null");

            return base.ToString();
        }
    }
}
