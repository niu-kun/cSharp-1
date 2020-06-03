using System;
using System.Collections.Generic;
using System.Text;

namespace _002链表
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

        public int Count => N;

        public bool IsEmpty => N == 0;

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
                head = new Node(e, head);
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

        public E Get(int index)
        {
            if (index < 0 || index > N - 1)
            {
                throw new ArgumentException("非法索引");
            }
            Node cur = head;
            for (int i = 0; i < index; i++)
            {
                cur = cur.next;
            }
            return cur.e;
        }

        public E GetFirst()
        {
            return Get(0);
        }

        public E GetLast()
        {
            return Get(N - 1);
        }

        public void Set(int index, E e)
        {
            if (index < 0 || index > N)
            {
                throw new ArgumentException("非法索引");
            }
            Node cur = head;
            for (int i = 0; i < index; i++)
            {
                cur = cur.next;
            }
            cur.e = e;
        }

        public void SetFirst(E e)
        {
            Set(0, e);
        }

        public void SetLast(E e)
        {
            Set(N - 1, e);
        }

        public bool Contains(E e)
        {
            Node cur = head;
            while(cur != null)
            {
                if (cur.e.Equals(e))
                {
                    return true;
                }
                cur = cur.next;
            }
            return false;
        }

        public override string ToString()
        {
            StringBuilder res = new StringBuilder();
            Node cur = head;
            while(cur != null)
            {
                //res.Append(cur.e + "->"); ???
                res.Append(cur + "->");
                cur = cur.next;
            }
            res.Append("Null");
            return res.ToString();
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

        public E RemoveFirst()
        {
            return RemoveAt(0);
        }

        public E RemoveLast()
        {
            return RemoveAt(N - 1);
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
