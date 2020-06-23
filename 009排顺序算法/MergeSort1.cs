
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Text;

namespace _009排顺序算法
{
    // 时间复杂度 O(NlogN)
    // 空间复杂度 O(N)
    class MergeSort1
    {
        public static void Sort(int[] arr)
        {
            int[] temp = new int[arr.Length];
            Sort(arr, temp, 0, arr.Length - 1);
        }

        private static void Sort(int[] arr, int[] temp, int left, int right)
        {
            Console.WriteLine("Sort ({0},{1})",left,right);
            if (left >= right) return;
            int mid = left + (right - left) / 2;
            Console.WriteLine("mid = {0}", mid);

            Sort(arr, temp, left, mid);
            Sort(arr, temp, mid + 1, right);
            // 合并已经排序的数组
            Merge(arr, temp, left, mid, right);
        }

        private static void Merge(int[] arr, int[] temp,  int left, int mid, int right)
        {

            Console.WriteLine("Merge ({0},{1},{2})", left, mid, right);
            // 标记左半区第一个未排序元素
            int l_pos = left;

            // 标记右半区第一个未排序元素
            int r_pos = mid + 1;

            // 临时数组元素的下标
            int temp_pos = left;

            while(l_pos <= mid && r_pos <= right)
            {
                //temp[k++] = arr[i] < arr[j] ? arr[i++] : arr[j++];
                if (arr[l_pos] < arr[r_pos])        // 左半区第一个剩余元素
                    temp[temp_pos++] = arr[l_pos++];
                else                                // 右半区第一个剩余元素更小
                    temp[temp_pos++] = arr[r_pos++];
            }
            while(l_pos <= mid)
            {
                    temp[temp_pos++] = arr[l_pos++];
            }
            while(r_pos <= right)
            {
                    temp[temp_pos++] = arr[r_pos++];
            }

            // 将temp数组拷贝回给arr数组， 完成arr排序
            for (int i = left; i <= right; i++)
            {
                arr[i] = temp[i];
            }
            TestHelper.Show(arr);
        }

    }
}
