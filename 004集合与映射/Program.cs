using System;
using System.Collections.Generic;
using System.Diagnostics;

namespace _004集合与映射
{
    class Program
    {
        /*
        static void Main(string[] args)
        {
            Stopwatch t = new Stopwatch();
            Console.WriteLine("双城记");

            List<string> words = TestHelper.ReadFile("测试文件1/双城记.txt");

            Console.WriteLine("总单词数: " + words.Count);

            LinkedList1Set<string> set = new LinkedList1Set<string>();

            t.Start();
            foreach (var word in words)
                set.Add(word);
            t.Stop();
            Console.WriteLine("不同单词总数: " + set.Count);
            Console.WriteLine("运行时间: " + t.ElapsedMilliseconds + "ms") ;

            Console.Read();
        }*/

        static void Main(string[] args)
        {
            Stopwatch t = new Stopwatch();
            Console.WriteLine("双城记");

            List<string> words = TestHelper.ReadFile("测试文件1/双城记.txt");

            Console.WriteLine("总单词数: " + words.Count);

            LinkedList3Dictionary<string> set = new LinkedList3Dictionary<string>();

            t.Start();
            foreach (var word in words)
                set.Add(word);
            t.Stop();
            Console.WriteLine("不同单词总数: " + set.Count);
            Console.WriteLine("运行时间: " + t.ElapsedMilliseconds + "ms");
            Console.WriteLine("========================================");


            Stopwatch t2 = new Stopwatch();
            Console.WriteLine("双城记");

            List<string> wordss = TestHelper.ReadFile("测试文件1/双城记.txt");

            Console.WriteLine("总单词数: " + wordss.Count);

            LinkedList3Dictionary<string, int> dic = new LinkedList3Dictionary<string, int>();

            t2.Start();
            foreach (var word in wordss)
            {
                if (!dic.ContainsKey(word))
                    dic.Add(word, 1);
                else
                    dic.Set(word, dic.Get(word) + 1);
            }
            t2.Stop();
            Console.WriteLine("不同单词总数: " + dic.Count);
            Console.WriteLine("city出现的频次： " + dic.Get("city"));
            Console.WriteLine("运行时间: " + t2.ElapsedMilliseconds + "ms");

            Console.Read();
        }
    }
}
