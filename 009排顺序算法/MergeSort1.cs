
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Text;

namespace _009排顺序算法
{
    class MergeSort1
    {
        public static void Sort(int[] arr)
        {
            int n = arr.Length;
            int[] temp = new int[n];
            Sort(arr, temp, 0, n - 1);
        }

        private static void Sort(int[] arr, int[] temp, int l, int r)
        {
            //Console.WriteLine("Sort ({0},{1})",l,r);
            if (l >= r) return;
            int mid = l + (r - l) / 2;

            //Console.WriteLine("mid = {0}", mid);
            Sort(arr, temp, l, mid);
            Sort(arr, temp, mid + 1, r);
            Merge(arr, temp, l, mid, r);
        }

        private static void Merge(int[] arr, int[] temp,  int l, int mid, int r)
        {

            //Console.WriteLine("Sort ({0},{1},{2})", l, mid, r);
            int i = l;
            int j = mid + 1;
            int k = l;
            while(i <= mid && j <= r)
            {
                //temp[k++] = arr[i] < arr[j] ? arr[i++] : arr[j++];
                if (arr[i] < arr[j])
                    temp[k++] = arr[i++];
                else
                    temp[k++] = arr[j++];
            }
            while(i <= mid)
            {
                    temp[k++] = arr[i++];
            }
            while(j <= r)
            {
                    temp[k++] = arr[j++];
            }

            // 将temp数组拷贝回给arr数组， 完成arr排序
            for (int z = l; z <= r; z++)
            {
                arr[z] = temp[z];
            }
            //TestHelper.Show(arr);
        }

    }
}
