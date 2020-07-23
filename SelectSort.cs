using System;

namespace 数据结构
{
    public class SelectSort
    {
        static int[] sortArray = { 2, 501, 403, 708, 900, 1 };
        public static void Main(string[] args)
        {
            Console.WriteLine("排序之前");
            foreach (var m in sortArray)
            {
                Console.Write(m+" ");
            }
            Select(sortArray);
            Console.WriteLine();
            Console.WriteLine("排序之后");
            foreach (var m in sortArray)
            {
                Console.Write(m+" ");
            }
        }

        //选择排序，从小到大
        public static void Select(int[] array)
        {
            for (int i = 0; i < array.Length - 1; i++)
            {
                //最小值下标
                int minIndex = i;
                //最小值
                int min = array[minIndex];
                for (int j = i + 1; j < array.Length; j++)
                {
                    if (min > array[j])
                    {
                        minIndex = j;
                        min = array[j];
                    }
                }
                //交换
                if (min < array[i])
                {
                    array[minIndex] = array[i];
                    array[i] = min;
                }
            }
        }
    }
}
