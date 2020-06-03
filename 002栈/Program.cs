using System;
using System.Collections.Generic;

namespace _002_栈
{
    class Program
    {
        static void Main(string[] args)
        {
            Stack<Char> stack = new Stack<char>();

            stack.Push('n');
            stack.Push('k');
            var s = stack.ToArray();
            for (int i = 0; i < s.Length; i++)
            {
                Console.WriteLine("push is {0}.", s[i]);
            }
            int[] dd = new int[6];
            int[] ddd = new int[dd.Length];

            Console.WriteLine(stack.Pop());
            Console.WriteLine(stack.Peek());
            Console.WriteLine(stack.Peek());


        }
    }
}
