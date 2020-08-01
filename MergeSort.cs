using System;

namespace 数据结构
{
    //归并排序
    public class MergeSort
    {
        public static void Main(string[] args)
        {
            int[] sortArray = { 5, 2, 3, 4 ,0,6};
            Console.WriteLine("排序前");
            foreach (var i in sortArray)
            {
                Console.Write(i + " ");
            }
            Console.WriteLine("");

            int length = sortArray.Length;
            int[] temp = new int[length];
            SortMerge(sortArray, 0, length - 1, temp);

            Console.WriteLine("排序后");
            foreach (var i in sortArray)
            {
                Console.Write(i + " ");
            }
        }

        //分+合
        public static void SortMerge(int[] array,int left,int right,int[] temp)
        {
            //两个项以上都可以继续分
            if (left < right)
            {
                //中间索引
                int mid = (left + right) / 2;
                //左递归分解
                SortMerge(array, left, mid, temp);
                //右递归分解
                SortMerge(array, mid+1, right, temp);
                //合并
                Merge(array,left,mid,right,temp);
            }  
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

            //把临时数组复制到原数组
            t = 0;
            int tempLeft = left;
            while (t <= right)
            {
                array[tempLeft] = temp[t];
                t++;
                tempLeft++;
            }
        }
    }
}
