using System;
using System.Collections.Generic;
using System.Text;

namespace _006二叉查找树和递归
{
    class BST1<E> where E:IComparable<E>
    {
        private class Node
        {
            public E e;
            public Node left;
            public Node right;

            public Node(E e)
            {
                this.e = e;
                this.left = null;
                this.right = null;
            }
        }

        private Node root;
        private int N;

        public BST1()
        {
            root = null;
            N = 0;
        }

        public int Count { get => N; }
        public bool IsEmpty { get => N == 0; }

        // 非递归添加
        public void add(E e)
        {
            // 根节点没有父节点需要单独添加
            if (root == null)
            {
                root = new Node(e);
                N++;
                return;
            }

            Node pre = null;
            Node cur = root;

            // 循环里面移动cur指针
            while (cur!=null)
            {
                // 树中不允许添加重复元素
                if (e.CompareTo(cur.e) == 0) 
                {
                    return;
                }

                // 记录cur的位置
                pre = cur;

                // 移动cur指向
                if (e.CompareTo(cur.e) < 0)
                {
                    cur = cur.left; // 向左移动 在左子树中查找
                }
                else
                    cur = cur.right;
            }

            // while循环结束cur==null， 通过元素e创建新节点放到cur中
            cur = new Node(e);

            // 判断cur是pre的左孩子还是有孩子
            if (e.CompareTo(pre.e) < 0)
                pre.left = cur;
            else
                pre.right = cur;

            N++;
        }


    }
}
