
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Reflection.Metadata.Ecma335;
using System.Text;

namespace _007红黑树
{
    class RBT1<E> where E : IComparable<E>
    {
        private const bool RED = true;
        private const bool BLACK = false;

        private class Node
        {
            public E e;
            public Node left;
            public Node right;
            public bool color;

            public Node(E e)
            {
                this.e = e;
                left = null;
                right = null;
                color = RED;
            }

        }

        private Node root;
        private int N;

        public RBT1()
        {
            root = null;
            N = 0;
        }


        public int Count => this.N;

        public bool IsEmpty => this.N == 0;

        private bool IsRed(Node node)
        {
            if (node == null)
                return BLACK;
            return node.color;
        }

        //   node                     x
        //  /   \     左旋转         /  \
        // T1   x   --------->   node   T3
        //     / \              /   \
        //    T2 T3            T1   T2

        //返回左旋转后新的二叉查找树的根
        // 左黑右红
        private Node LeftRotate(Node node)
        {
            Node x = node.right;
            node.right = x.left;
            x.left = node;
            x.color = node.color;
            node.color = RED;
            return x;
        }

        // 左右皆红
        private void FlipColors(Node node)
        {
            node.color = RED;
            node.left.color = BLACK;
            node.right.color = BLACK;
        }

        // 连续左子树为红色
        private Node RightRoatate(Node node)
        {
            Node x = node.left;
            node.left = x.right;
            x.right = node;
            x.color = node.color;
            node.color = RED;
            return x;
        }

        // 往红黑树中添加元素，递归实现
        public void Add(E e)
        {
            root = Add(root, e);
            root.color = BLACK;
        }

        //以node为根的树中添加元素e，添加后返回根节点node
        private Node Add(Node node, E e)
        {
            if (node == null)
            {
                N++;
                return new Node(e); // 默认为红节点
            }

            if (e.CompareTo(node.e) < 0)
                node.left = Add(node.left, e);
            else if (e.CompareTo(node.e) > 0)
                node.right = Add(node.right, e);

            // 如果出现右子节点是红色，左子节点是黑色，进行左旋转
            if (IsRed(node.right) && !IsRed(node.left))
                node = LeftRotate(node);

            // 如果出现连续的左子节点都为红色，进行右旋转
            if (IsRed(node.left) && IsRed(node.left.left))
                node = RightRoatate(node);

            // 如果出现左右子节点均为红色，进行颜色反转
            if (IsRed(node.right) && IsRed(node.left))
                FlipColors(node);

            return node;
        }

        public bool Contains(E e)
        {
            return Contains(root, e);
        }

        //以node为根的树是否包含元素e
        private bool Contains(Node node, E e)
        {
            if (node == null)
                return false;

            if (e.CompareTo(node.e) == 0)
                return true;
            else if (e.CompareTo(node.e) < 0)
                return Contains(node.left, e);
            else  //e.CompareTo(node.e) > 0
                return Contains(node.right, e);
        }

        public int MaxHeight()
        {
            return MaxHeight(root);
        }

        private int MaxHeight(Node node)
        {
            if (node == null) return 0;

            int l = MaxHeight(node.left);
            int r = MaxHeight(node.right);
            var rr = Math.Max(l, r) + 1;
            return rr;

            //return Math.Max(MaxHeight(node.left), MaxHeight(node.right)) + 1;
        }


    }
}
