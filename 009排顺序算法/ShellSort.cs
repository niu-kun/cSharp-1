
using System;
using System.Collections.Generic;
using System.Text;

namespace _009排顺序算法
{
    // 时间复杂度 O(N^2) 最好情况 O(N)
    // 空间复杂度 O(1)
    // 可优化 ?
    // 希尔排序 不稳定
    class ShellSort
    {
        //public static void Sort(int[] arr)
        //{
        //    int i, j, gap, temp;
        //    for (gap = arr.Length / 2; gap >= 1; gap /= 2)
        //    {
        //        // 每一趟采用插入排序
        //        for (i = gap; i < arr.Length; i++)
        //        {
        //            temp = arr[i];
        //            // 对距离为 gap 的元素组进行排序
        //            for (j = i; j >= gap && temp < arr[j - gap]; j -= gap)
        //                arr[j] = arr[j - gap];
        //            arr[j] = temp;
        //        }
        //    }
        //}




        public static void Sort(int[] arr)
        {
            int gap, i, j, temp;
            // 控制总分块次数
            for (gap = arr.Length / 2; gap >= 1; gap /= 2)
            {
                // 插入排序
                for (i = gap; i < arr.Length; i++)
                {
                    temp = arr[i];
                    for (j = i; j >= gap && temp < arr[j - gap]; j -= gap)
                        arr[j] = arr[j - gap];
                    arr[j] = temp;
                }
            }
        }
    }
}
