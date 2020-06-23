
using System;
using System.Collections.Generic;
using System.Security.Cryptography.X509Certificates;
using System.Text;

namespace _010优先队列和堆排序
{
    // 时间复杂度 O(N^2) 最好情况
    // 空间复杂度 O(1)
    // 可优化 考虑不用排序的情况
    class InsertSort
    {
        public static void Sort(int[] arr)
        {
            int i, j, temp;
            for (i = 1; i < arr.Length; i++)
            {
                temp = arr[i];
                
                for (j = i; j >= 1 && temp < arr[j - 1]; j--)
                        arr[j] = arr[j - 1];
                arr[j] = temp;
            }
        }

        //对arr[l...r]的范围使用插入排序
        public static void Sort1(int[] arr, int l, int r)
        {
            int i, j, temp;
            for (i = l + 1; i <= r; i++)
            {
                temp = arr[i];
                for (j = i; j >= l + 1 && temp < arr[j - 1]; j--)
                        arr[j] = arr[j - 1];
                arr[j] = temp;
            }
        }

    }
}
