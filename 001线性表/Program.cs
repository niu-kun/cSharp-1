using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;

namespace _001线性表
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
            
            int[] arr = new int[10];
            for (int i = 0; i < 10; i++)
            {
                arr[i] = i;
                Console.Write(arr[i]+" ");
            }
            Console.WriteLine();

            ArrayList arrayList = new ArrayList();
            for (int i = 0; i < 20; i++)
            {
                arrayList.Add(i);
                Console.Write(arrayList[i] + " ");
            }
            Console.WriteLine();

            List<int> list = new List<int>();
            for (int i = 0; i < 10; i++)
            {
                list.Add(i);
                Console.Write(list[i]+" ");
            }
            */


            var array1 = new Array1<int>(10);
            for (int i = 0; i < 10; i++)
            {
                array1.AddLast(i);
            }

            Console.WriteLine(array1);

            array1.AddFirst(88);
            Console.WriteLine(array1);

            array1.AddLast(99);
            Console.WriteLine(array1);

            array1.Add(2, 77);
            Console.WriteLine(array1);

            array1.RemoveLast();
            array1.RemoveLast();
            array1.RemoveLast();
            array1.RemoveLast();
            array1.RemoveLast();
            array1.RemoveLast();
            array1.RemoveLast();
            array1.RemoveLast();
            Console.WriteLine(array1);

            LinkList<int> linkList = new LinkList<int>();

            Stopwatch st = new Stopwatch();

            List<int> list = new List<int>();
            ArrayList arrayList = new ArrayList();

            st.Start();
            for (int i = 0; i < 100000000; i++)
            {
                list.Add(i);
                int x = list[i];
            }
            st.Stop();
            Console.WriteLine("List值类型测试: {0}ms", st.ElapsedMilliseconds);

            st.Restart();
            for (int i = 0; i < 100000000; i++)
            {
                arrayList.Add(i);// 装箱
                int x = (int)arrayList[i]; // 拆箱
            }
            st.Stop();
            Console.WriteLine("ArrayList值类型测试: {0}ms", st.ElapsedMilliseconds);







            Console.Read();
        }
    }
}
