using System;

namespace 数据结构
{
    //归并排序
    public class MergeSort
    {
        public static void Main(string[] args)
        {
        }

        /// <param name="array">排序数组</param>
        /// <param name="left">左边索引</param>
        /// <param name="mid">中间值</param>
        /// <param name="right">右边最大索引</param>
        /// <param name="temp">临时数组</param>
        public static void Merge(int[] array, int left, int mid, int right, int[] temp)
        {
            int i = left;
            //右边起始索引
            int j = mid + 1;
            //临时数组索引
            int t = 0;
            //左右两边向临时数组复制数据
            while (i <= mid && j <= right)
            {
                if (array[i] <= array[j])
                {
                    temp[t] = array[i];
                    i++;
                    t++;
                }
                else
                {
                    temp[t] = array[j];
                    j++;
                    t++;
                }
            }
            //当左边还剩余数据复制到临时数组
            while (i <= mid)
            {
                temp[t] = array[i];
                i++;
                t++;
            }
            //当右边还剩余数据复制到临时数组
            while (j <= right)
            {
                temp[t] = array[j];
                j++;
                t++;
            }
        }
    }
}
