using System;

namespace 数据结构
{
    public class QuickSort
    {
        public static void Main(string[] args)
        {
            int[] arraySort = { 23, 19, 18, 46, 8, 11 };
            Console.WriteLine("排序之前");
            foreach (var m in arraySort)
            {
                Console.Write(m + " ");
            }
            Quick(arraySort, 0, arraySort.Length - 1);
            Console.WriteLine();
            Console.WriteLine("排序之后");
            foreach (var m in arraySort)
            {
                Console.Write(m + " ");
            }
        }

        public static void Quick(int[] array, int left, int right)
        {
            if (left < right)
            {

                //低位索引
                int low = left;
                //高位索引
                int high = right;

                //取中间值为基准数,同array[low]交换
                int pivot = array[(left + high) / 2];
                array[(left + high) / 2] = array[low];

                while (low < high)
                {
                    //高位向左查找比基准小项
                    while (low < high && pivot <= array[high])
                    {
                        high--;
                    }
                    //小值移到左边
                    array[low] = array[high];

                    //低位向右查找比基准数小项
                    while (low < high && pivot >= array[low])
                    {
                        low++;
                    }
                    //大值移到右边
                    array[high] = array[low];
                }

                //高位低位重合，找到基准值位置
                array[low] = pivot;

                //基准数左边递归
                Quick(array, left, low - 1);
                //基准数右边边递归
                Quick(array, low + 1, right);
            }
        }
    }
}
