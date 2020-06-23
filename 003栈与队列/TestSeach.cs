using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace _003栈与队列
{
    class TestSeach
    {
        // 读取文件
        public static int[] ReadFile(string filename)
        {
            FileStream fs = new FileStream(filename, FileMode.Open);
            StreamReader sr = new StreamReader(fs);
            List<int> list = new List<int>();

            while (!sr.EndOfStream)
            {
                int num = int.Parse(sr.ReadLine());
                list.Add(num);
            }
            fs.Close();
            sr.Close();

            return list.ToArray();
        }

        // 顺序查找法
        public static int OrderSearch(int[] arr, int target)
        {
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i]==target)
                    return i;
            }
            return -1;
        }




        // 二分查找法
        public static int BinarySearch(int[] arr, int target)
        {
            int l = 0;
            int r = arr.Length - 1;

            while (l <= r)
            {
                // int mid = (l + r) / 2; 有可能溢出
                int mid = l + (r - l) / 2;

                if (target < arr[mid])
                    r = mid - 1;
                else if (target > arr[mid])
                    l = mid + 1;
                else
                    return mid;
            }
            return -1;
        }
    }
}
