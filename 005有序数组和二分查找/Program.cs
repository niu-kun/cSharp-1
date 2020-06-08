using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using _004集合与映射;

namespace _005有序数组和二分查找
{
    class Program
    {

        public static long TestDictionary(_004集合与映射.IDictionary<string, int> dic, List<string> words)
        {
            Stopwatch t = new Stopwatch();
            t.Start();
            foreach (var word in words)
            {
                if (!dic.ContainsKey(word))
                {
                    dic.Add(word, 1);
                }
                else
                {
                    dic.Set(word, dic.Get(word) + 1);
                }

            }
            t.Stop();
            return t.ElapsedMilliseconds;
        }

        static void Main(string[] args)
        {
            Console.WriteLine("双城记");

            List<string> words = TestHelper.ReadFile("测试文件1/双城记.txt").ToList();
            Console.WriteLine("词汇量总数: " + words.Count);

            Console.WriteLine();
            Console.WriteLine("链表字典");
            LinkedList3Dictionary<string, int> dic1 = new LinkedList3Dictionary<string, int>();
            long t1 = TestDictionary(dic1, words);
            Console.WriteLine("不同单词的总数： " + dic1.Count);
            Console.WriteLine("city出现的频次： "+dic1.Get("city"));
            Console.WriteLine("运行时间： " + t1 + "ms");

            Console.WriteLine();
            Console.WriteLine("有序数组字典");
            SortedArray2Dictionary<string, int> dic2 = new SortedArray2Dictionary<string, int>();
            long t2 = TestDictionary(dic2, words);
            Console.WriteLine("不同单词的总数： " + dic2.Count);
            Console.WriteLine("city出现的频次： " + dic2.Get("city"));
            Console.WriteLine("运行时间： " + t2 + "ms");

            Console.WriteLine("C#中的有序数组");

            Console.Read();

















            /*
            string filename1 = "测试文件2/游戏会员表.txt";
            string filename2 = "测试文件2/游戏用户表.txt";

            int[] arr1 = TestSeach.ReadFile(filename1);
            int[] arr2 = TestSeach.ReadFile(filename2);
            Console.WriteLine("超市会员数量 ：" + arr1.Length);
            Console.WriteLine("调查客户数量 ：" + arr2.Length);

            Console.WriteLine();

            Stopwatch t = new Stopwatch();
            Console.WriteLine("顺序查找法");

            t.Start();
            int sum1 = 0;
            for (int i = 0; i < arr2.Length; i++)
            {
                int target = arr2[i];
                if (TestSeach.OrderSearch(arr1, target) == -1)
                {
                    //Console.WriteLine(target);
                    sum1++;
                }
            }
            t.Stop();
            Console.WriteLine("查询到" + sum1 + "个普通客户");
            Console.WriteLine("运行时间" + t.ElapsedMilliseconds + "ms");
            Console.WriteLine();

            Console.WriteLine("二分查找法");
            t.Restart();
            Array.Sort(arr1);
            int sum2 = 0;
            for (int i = 0; i < arr2.Length; i++)
            {
                int target = arr2[i];
                if (TestSeach.BinarySearch(arr1, target) == -1)
                {
                    //Console.WriteLine(target);
                    sum2++;
                }
            }
            t.Stop();
            Console.WriteLine("查询到" + sum2 + "个普通客户");
            Console.WriteLine("运行时间" + t.ElapsedMilliseconds + "ms");*/


            /*
            int[] arr = { 12, 34, 56, 87, 2, 2, 3, 3, 37, 45, 78, 9876, 99, 32, 878, 008, 1, 23, 22, 121, 25, 5677 };

            SortedArray1<int> sortedArray1 = new SortedArray1<int>();
            for (int i = 0; i < arr.Length; i++)
            {
                sortedArray1.Add(arr[i]);
            }
            Console.WriteLine(sortedArray1);
            Console.WriteLine(sortedArray1.Min());
            Console.WriteLine(sortedArray1.Max());
            Console.WriteLine(sortedArray1.Select(5));
            Console.WriteLine(sortedArray1.Floor(15));
            Console.WriteLine(sortedArray1.Celling(15));
            sortedArray1.Remove(9876);
            Console.WriteLine(sortedArray1);
            sortedArray1.Remove(98);
            Console.WriteLine(sortedArray1);

            Student[] stu =
            {
                new Student("张三", 180.1),
                new Student("李四", 179.2),
                new Student("王五", 170),
                new Student("李六", 165),
                new Student("小二", 185),
            };
            SortedArray1<Student> s = new SortedArray1<Student>();

            for (int i = 0; i < stu.Length; i++)
                s.Add(stu[i]);

            Console.WriteLine(s);*/
            Console.Read();
        }
    }
}
