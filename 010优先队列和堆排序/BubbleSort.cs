
using System;
using System.Collections.Generic;
using System.Text;

namespace _010优先队列和堆排序
{
    // 时间复杂度 O(N^2)
    // 空间复杂度 O(1)
    // 可优化 考虑不用排序的情况
    class BubbleSort
    {
        public static void Sort(int[] arr)
        {
            int n = arr.Length;
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n - 1 - i; j++)
                {
                    // 减去 i 不需要对已经排好序的元素，再次比较
                    if (arr[j] > arr[j + 1])
                        Swap(arr, j, j + 1);
                }
            }
        }

        private static void Swap(int[] arr, int i, int j)
        {
            var temp = arr[i];
            arr[i] = arr[j];
            arr[j] = temp;
        }
    }
}
