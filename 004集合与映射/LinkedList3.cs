
using System;
using System.Collections.Generic;
using System.Text;

namespace _004集合与映射
{
    class LinkedList3<Key, Value>
    {
        class Node
        {
            public Key key; // 节点存储的元素
            public Value value;
            public Node next; // 下一个节点的引用（引用）

            public Node()
            {
                this.next = null;
                this.key = default;
                this.value = default;
            }

            public Node(Key key, Value value, Node next)
            {
                this.key = key;
                this.value = value;
                this.next = next;
            }

            public override string ToString()
            {
                return key.ToString() + ": " + value.ToString();
            }
        }
        private Node head;
        private Node tail;
        private int N;

        public LinkedList3()
        {
            this.head = null;
            N = 0;
        }

        public int Count => N;

        public bool IsEmpty => N == 0;

        private Node GetNode(Key key)
        {
            Node cur = head;
            while (cur != null)
            {
                if (cur.key.Equals(key))
                    return cur;
                cur = cur.next;
            }
            return null;
        }

        public void Add(Key key, Value value)
        {
            Node node = GetNode(key);

            if (node == null)
            {
                this.head = new Node(key, value, head);
                N++;
            }
            else
            {
                node.value = value;
            }
        }

        public bool Contains(Key key)
        {
            return GetNode(key) != null;
        }

        public Value Get(Key key)
        {
            Node node = GetNode(key);
            if (node == null)
                throw new ArgumentException("键" + key + "不存在");
            else
                return node.value;
        }

        public void Set(Key key, Value value)
        {
            Node node = GetNode(key);
            if (node == null)
                throw new ArgumentException("键" + key + "不存在");
            else
                node.value = value;
        }

        public void Remove(Key key)
        {
            if(head == null)
            return;

            if (head.key.Equals(key))
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
                    if (cur.key.Equals(key))
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
