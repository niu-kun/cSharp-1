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
        /*
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
        }*/

        
        public static long TestQueue(IQueue<int> queue, int N)
        {
            Stopwatch t = new Stopwatch();
            t.Start();
            for (int i = 0; i < N; i++)
                queue.Enqueue(i);
            for (int i = 0; i < N; i++)
                queue.Dequeue();
            t.Stop();
            return t.ElapsedMilliseconds;
        }

        
        public static long TestQueue2(Queue<int> queue, int N)
        {
            Stopwatch t = new Stopwatch();
            t.Start();
            for (int i = 0; i < N; i++)
                queue.Enqueue(i);
            for (int i = 0; i < N; i++)
                queue.Dequeue();
            t.Stop();
            return t.ElapsedMilliseconds;
        }
        
        static void Main(string[] args)
        {
            int N = 100000;

            LinkedList1Queue<int> arr1 = new LinkedList1Queue<int>();
            Console.WriteLine("Array1Queue'time: " + TestQueue(arr1, N) + "ms");

            LinkedList2Queue<int> arr2 = new LinkedList2Queue<int>();
            Console.WriteLine("Array2Queue'time: " + TestQueue(arr2, N) + "ms");

            Queue<int> arr3 = new Queue<int>();
            Console.WriteLine("Array3Queue'time: " + TestQueue2(arr3, N) + "ms");

            Console.Read();
        }
    }
}
