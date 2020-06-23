using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _009排顺序算法
{
    class QuickSort2
    {
        private static Random rd = new Random();

        public static void Sort(int[] arr)
        {
            int n = arr.Length;
            Sort(arr, 0, n - 1);
        }

        private static void Sort(int[] arr, int l, int r)
        {
            //对小规模的数组使用插入排序，避免频繁的递归调用
            if (r - l + 1 <= 15)
            {
                InsertSort.Sort1(arr, l, r);
                return;
            }

            int p = l + rd.Next(r - l + 1);

            Swap(arr, l, p);

            int v = arr[l]; //标定元素v
            
            int j = l; // arr[l+1...j] < v  arr[j+1...i-1] > v

            //往对应区间填充元素
            for (int i = l + 1; i <= r; i++)
            {
                if (arr[i] < v)
                {
                    j++;
                    Swap(arr, i, j);
                }
            }

            //将标定元素放到合适的位置
            Swap(arr, l, j);

            Sort(arr, l, j - 1);  //将左半边arr[l...j-1]排序
            Sort(arr, j + 1, r);  //将右半边arr[j+1...r]排序
        }

        private static void Swap(int[] arr, int i, int j)
        {
            int e = arr[i];
            arr[i] = arr[j];
            arr[j] = e;
        }
    }
}
