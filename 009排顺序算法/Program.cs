using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _009排顺序算法
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
            //TestHelper.TestSort("QuickSort1", a);
            //TestHelper.TestSort("QuickSort2", b);
            TestHelper.TestSort("QuickSort3", c);
            TestHelper.TestSort("MergeSort2", d);
            Console.WriteLine();

            Console.WriteLine("测试近乎有序数组： ");
            a = TestHelper.NearlyOrderedArray(N, 100);
            b = TestHelper.CopyArray(a);
            c = TestHelper.CopyArray(a);
            //TestHelper.TestSort("QuickSort2", a);
            TestHelper.TestSort("QuickSort3", b);
            TestHelper.TestSort("MergeSort2", c);
            Console.WriteLine();

            Console.WriteLine("测试大量重复元素数组： ");
            a = TestHelper.RandomArray(N, 10);
            b = TestHelper.CopyArray(a);
            TestHelper.TestSort("QuickSort3", a);
            TestHelper.TestSort("MergeSort2", b);


            Console.Read();
        }
    }
}
