using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _010优先队列和堆排序
{
    class Program
    {


        static void Main(string[] args)
        {
            int N = 1000000;

            Console.WriteLine("测试随机数组： ");
            int[] a = TestHelper.RandomArray(N, N);
            int[] b = TestHelper.CopyArray(a);
            int[] c = TestHelper.CopyArray(a);
            int[] d = TestHelper.CopyArray(a);
            TestHelper.TestSort("QuickSort3", a);
            TestHelper.TestSort("MergeSort2", b);
            TestHelper.TestSort("HeapSort1", c);
            TestHelper.TestSort("HeapSort2", d);

            Console.WriteLine();

            Console.WriteLine("测试近乎有序数组： ");
            a = TestHelper.NearlyOrderedArray(N, 100);
            b = TestHelper.CopyArray(a);
            c = TestHelper.CopyArray(a);
            d = TestHelper.CopyArray(a);
            TestHelper.TestSort("QuickSort3", a);
            TestHelper.TestSort("MergeSort2", b);
            TestHelper.TestSort("HeapSort1", c);
            TestHelper.TestSort("HeapSort2", d);
            Console.WriteLine();

            Console.WriteLine("测试大量重复元素数组： ");
            a = TestHelper.RandomArray(N, 10);
            b = TestHelper.CopyArray(a);
            c = TestHelper.CopyArray(a);
            d = TestHelper.CopyArray(a);
            TestHelper.TestSort("QuickSort3", a);
            TestHelper.TestSort("MergeSort2", b);
            TestHelper.TestSort("HeapSort1", c);
            TestHelper.TestSort("HeapSort2", d);

            Console.Read();
        }
    }
}
