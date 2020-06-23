using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _010优先队列和堆排序
{
    //时间复杂度O(nlogn)
    //空间复杂度O（n）需要借助一个同样长度的辅助数组进行排序
    class MergeSort2
    {
        //用户调用的排序方法传进数组即可排序
        public static void Sort(int[] arr)
        {
            int n = arr.Length;
            int[] temp = new int[n];
            Sort(arr, temp, 0, n - 1);
        }

        //递归使用归并排序，对arr[l...r]的范围进行排序
        private static void Sort(int[] arr, int[] temp, int l, int r)
        {
            //优化一：对于小规模的子数组使用插入排序
            //主要是避免频繁的递归调用，不一定只能是使用插入排序，还可以使用选择排序和冒泡排序。
            //但相对于选择和冒泡而言，插入排序速度更快，所以使用插入排序更为合适。
            //那么如何定义小数组呢？这个并没有严格的要求，在这里我选择小于等于15个元素就为小数组。
            //对于这个优化呢？大约能缩短10%-15%的运行时间。
            //但它并不能本质的改变归并排序的时间复杂度，它还是O(nlogn)级别的。
            if (r - l + 1 <= 15)
            {
                InsertSort.Sort1(arr, l, r);
                return;
            }

            int mid = l + (r - l) / 2;
            Sort(arr, temp, l, mid);        //将左半边排序
            Sort(arr, temp, mid + 1, r);    //将右半边排序

            //优化二：判断数组是否有序
            //这一步的优化主要是针对于有序性很强的数组，减少不必要的merge操作，缩短运行时间。
            //换句话说，如果对于随机性很强的数组，有优化没优化merge操作次数都是差不多的话。
            //那么增加了这个判断，就相应的增加了耗时。有可能优化后比没优化会更慢一些。
            if (arr[mid] > arr[mid + 1])
                Merge(arr, temp, l, mid, r);    //归并结果
        }

        // 将arr[l...mid]和arr[mid+1...r]两部分有序排列进行归并
        private static void Merge(int[] arr, int[] temp, int l, int mid, int r)
        {
            int i = l;
            int j = mid + 1;
            int k = l;

            //左右半边都有元素(将小的放到temp数组中)
            while (i <= mid && j <= r)
            {
                if (arr[i] < arr[j])
                    temp[k++] = arr[i++];
                else //arr[i] >= arr[j]
                    temp[k++] = arr[j++];
            }

            //左半边还有元素，右半边用尽（取左半边的元素）
            while (i <= mid)
                temp[k++] = arr[i++];

            //右半边还有元素，左半边用尽（取右半边的元素）
            while (j <= r)
                temp[k++] = arr[j++];

            //将temp数组拷贝回给arr数组，完成arr排序
            for (int z = l; z <= r; z++)
                arr[z] = temp[z];
        }
    }
}
