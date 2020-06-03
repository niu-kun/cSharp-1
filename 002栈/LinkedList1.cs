using System;
using System.Collections.Generic;
using System.Text;

namespace _002_栈
{
    class LinkedList1<E>
    {
        class Node
        {
            public E e; // 节点存储的元素
            public Node next; //下一个节点的引用（指针）

            public Node(E e, Node next)
            {
                this.e = e;
                this.next = next;
            }

            public Node(E e)
            {
                this.e = e;
                this.next = null;
            }
            public override string ToString()
            {
                return e.ToString();
            }
        }
        private Node head;

        private int N;

        public LinkedList1()
        {
            head = null;
            N = 0;
        }

        public int count
        {
            get { return N; }
        }

        public bool IsEmpty
        {
            get { return N == 0;  }
        }

        public void Add(int index, E e)
        {
            if (index < 0 || index > N)
            {
                throw new ArgumentException("非法索引");
            }

            
            if (index == 0)
            {
                //Node node = new Node(e);
                //node.next = head;
                //head = node;
                new Node(e, head);
            }
            else
            {
                Node pre = head;
                for (int i = 0; i < index - 1; i++)
                {
                    pre = pre.next;
                }

                //Node node = new Node(e);
                //node.next = pre.next;
                //pre.next = node;
                pre.next = new Node(e, pre.next);
            }

            N++;
        }

        public void AddFirst(E e)
        {
            Add(0, e);
        }

        public void AddLast(E e)
        {
            Add(N, e);
        }

        public E RemoveAt(int index)
        {
            if (index < 0 || index > N)
            {
                throw new ArgumentException("非法索引");
            }
            if(index == 0)
            {
                Node delNode = head;
                head = head.next;
                N--;
                return delNode.e;
            }
            else
            {
                Node pre = head;
                for (int i = 0; i < index - 1; i++)
                {
                    pre = pre.next;
                }
                var delNode = pre.next;
                pre.next = delNode.next;
                N--;
                return delNode.e;
            }
        }

        public void RemoveFirst()
        {
            RemoveAt(0);
        }

        public void RemoveLast()
        {
            RemoveAt(N - 1);
        }

        public void Remove(E e)
        {
            if (head == null)
                return;
            if (head.Equals(e))
            {
                head = head.next;
                N--;
            }
            else
            {
                Node cur = head;
                Node pre = null;

                while (cur != null)
                {
                    if (cur.e.Equals(e))
                    {
                        break;
                    }
                    pre = cur;
                    cur = cur.next;
                }
                while (cur != null)
                {
                    pre.next = pre.next.next;
                    N--;
                }
            }
           
        }

    }
}
