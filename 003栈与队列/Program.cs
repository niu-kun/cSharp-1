using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Security.Cryptography.X509Certificates;
using System.Threading;
using Microsoft.VisualBasic.CompilerServices;

namespace _003栈与队列
{
    class Program
    {
        public static long TestStack(IStack<int> stack, int N)
        {
            Stopwatch t = new Stopwatch();
            t.Start();
            for (int i = 0; i < N; i++)
                stack.Push(i);
            for (int i = 0; i < N; i++)
                stack.Pop();
            t.Stop();
            return t.ElapsedMilliseconds;
        }

        public static long TestStack2(Stack<int> stack, int N)
        {
            Stopwatch t = new Stopwatch();
            t.Start();
            for (int i = 0; i < N; i++)
                stack.Push(i);
            for (int i = 0; i < N; i++)
                stack.Pop();
            t.Stop();
            return t.ElapsedMilliseconds;
        }

        static void Main(string[] args)
        {
            int N = 20000000;

            Array1Stack<int> arr = new Array1Stack<int>(N);
            Console.WriteLine("Array1Stack'time: "+TestStack(arr, N) + "ms");

            LinkedList1Stack<int> list = new LinkedList1Stack<int>();
            Console.WriteLine("LinkedList1Stack'time: "+TestStack(list, N) + "ms");

            Stack<int> stack = new Stack<int>(N);
            Console.WriteLine("Stack'time: " + TestStack2(stack, N) + "ms");

            Console.Read();
        }
    }
}
