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
            Select();
            Console.WriteLine();
            Console.WriteLine("排序之后");
            foreach (var m in sortArray)
            {
                Console.Write(m+" ");
            }
        }

        //选择排序，从小到大
        public static void Select()
        {
            for (int i = 0; i < sortArray.Length - 1; i++)
            {
                //最小值下标
                int minIndex = i;
                //最小值
                int min = sortArray[minIndex];
                for (int j = i + 1; j < sortArray.Length; j++)
                {
                    if (min > sortArray[j])
                    {
                        minIndex = j;
                        min = sortArray[j];
                    }
                }
                //交换
                if (min < sortArray[i])
                {
                    sortArray[minIndex] = sortArray[i];
                    sortArray[i] = min;
                }
            }
        }
    }
}
