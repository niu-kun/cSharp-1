﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _010优先队列和堆排序
{
    class HeapSort2
    {
        public static void Sort(int[] arr)
        {
            int n = arr.Length;

            //先将原数组整理成最大堆
            for (int i = (n - 1 - 1) / 2; i >= 0; i--)
                Sink(arr, i, n - 1);

            //原地的堆排序
            for (int i = n - 1; i >= 0; i--)
            {
                Swap(arr, 0, i);
                Sink(arr, 0, i - 1);
            }
        }

        //元素下沉
        private static void Sink(int[] arr, int k, int N)
        {
            while (2 * k + 1 <= N)
            {
                int j = 2 * k + 1;

                if (j + 1 <= N && arr[j + 1].CompareTo(arr[j]) > 0) j++;

                if (arr[k].CompareTo(arr[j]) >= 0) break;

                Swap(arr, k, j);

                k = j;
            }
        }

        //交换数组中i和j对应位置的元素
        private static void Swap(int[] arr, int i, int j)
        {
            int e = arr[i];
            arr[i] = arr[j];
            arr[j] = e;
        }
    }
}
