using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Security.Cryptography.X509Certificates;
using System.Threading;
using Microsoft.VisualBasic.CompilerServices;


namespace _003栈与队列
{
    class Program
    {

        
        static void Main(string[] args)
        {
            int[] a = TestSeach.ReadFile("测试文件3/TopM.txt");

            QuickSort3.Sort(a);
            for (int i = 0; i < 10; i++)
                Console.Write(a[i]+", ");

            Console.WriteLine();

            MaxPQ<int> pq = new MaxPQ<int>(10);
            FileStream fileStresm = new FileStream("测试文件3/TopM.txt", FileMode.Open);
            StreamReader streamReader = new StreamReader(fileStresm);

            while (!streamReader.EndOfStream)
            {
                int value = int.Parse(streamReader.ReadLine());
                if (pq.Count < 10)
                    pq.Enqueue(value);
                else if (value < pq.Peek())
                {
                    pq.Dequeue();
                    pq.Enqueue(value);
                }
            }

            Console.WriteLine(pq);


            Console.Read();
        }
    }
}
