using System;

namespace 数据结构
{
    public class InsertSort
    {
        public static void Main(string[] args)
        {
            int[] sortArray = { 2, 501, 403, 708, 900, 1 };
            Console.WriteLine("排序前");
            foreach (var i in sortArray)
            {
                Console.Write(i + " ");
            }

            Insert(sortArray);

            Console.WriteLine();
            Console.WriteLine("排序后");
            foreach (var i in sortArray)
            {
                Console.Write(i + " ");
            }
        }

        public static void Insert(int[] array)
        {
            int insertVal = 0;
            int insertIndex = 0;
            for (int i = 1; i < array.Length; i++)
            {
                //无序列表第一个元素值
                insertVal = array[i];
                //无序列表第一个元素前一个位置
                insertIndex = i - 1;
                //insertIndex >= 0 无序列表前一个位置，确保不超出索引范围
                //insertVal < array[insertIndex]表示还没找到出入位置，array[insertIndex]要后移
                while (insertIndex >= 0 && insertVal < array[insertIndex])
                {
                    //有序列表元素向后移一位
                    array[insertIndex + 1] = array[insertIndex];
                    //继续向前搜索有序列表
                    insertIndex--;
                }
                //完成一轮搜索后，找到插入位置
                //前面向前搜索了一个位置所以+1
                array[insertIndex + 1] = insertVal;
            }
        }
    }
}

