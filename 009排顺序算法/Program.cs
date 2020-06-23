using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _009排顺序算法
{
    class Program
    {


        static void Main(string[] args)
        {

            //int N = 1000000;

            //Console.WriteLine("测试随机数组： ");
            //int[] a = TestHelper.RandomArray(N, N);
            //int[] b = TestHelper.CopyArray(a);
            //int[] c = TestHelper.CopyArray(a);
            //int[] d = TestHelper.CopyArray(a);
            ////TestHelper.TestSort("QuickSort1", a);
            ////TestHelper.TestSort("QuickSort2", b);
            //TestHelper.TestSort("QuickSort3", c);
            //TestHelper.TestSort("MergeSort2", d);
            //Console.WriteLine();

            //Console.WriteLine("测试近乎有序数组： ");
            //a = TestHelper.NearlyOrderedArray(N, 100);
            //b = TestHelper.CopyArray(a);
            //c = TestHelper.CopyArray(a);
            ////TestHelper.TestSort("QuickSort2", a);
            //TestHelper.TestSort("QuickSort3", b);
            //TestHelper.TestSort("MergeSort2", c);
            //Console.WriteLine();

            //Console.WriteLine("测试大量重复元素数组： ");
            //a = TestHelper.RandomArray(N, 10);
            //b = TestHelper.CopyArray(a);
            //TestHelper.TestSort("QuickSort3", a);
            //TestHelper.TestSort("MergeSort2", b);

            //int N = 100000;
            //int[] arr1 = TestHelper.RandomArray(N, N);
            //int[] arr2 = TestHelper.CopyArray(arr1);
            //int[] arr3 = TestHelper.CopyArray(arr1);

            //Console.WriteLine();
            //Stopwatch st = new Stopwatch();


            //st.Start();
            //ShellSort.Sort(arr1);
            //st.Stop();
            //Console.WriteLine("ShellSort: " + st.ElapsedMilliseconds + "ms");

            //st.Restart();
            //InsertSort.Sort(arr2);
            //st.Stop();
            //Console.WriteLine("InsertSort: " + st.ElapsedMilliseconds + "ms");

            //st.Restart();
            //InsertSort.Sort1(arr3, 0, arr3.Length);
            //st.Stop();
            //Console.WriteLine("InsertSort1: " + st.ElapsedMilliseconds + "ms");

            int[] arr = { 5, 4, 3, 2, 1 };
            MergeSort1.Sort(arr);

            Console.ReadKey();
        }
    }
}
