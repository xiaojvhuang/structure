using System;

namespace 数据结构
{
    public class Bubbling
    {
        static int[] sortArray = { 2, 501, 403, 708, 900, 1 };
        public static void Main(string[] args)
        {
            Console.WriteLine("排序之前");
            foreach (var m in sortArray)
            {
                Console.Write(m + " ");
            }
            Bubble(sortArray);
            Console.WriteLine();
            Console.WriteLine("排序之后");
            foreach (var m in sortArray)
            {
                Console.Write(m + " ");
            }
        }

        //冒泡
        public static void Bubble(int[] array)
        {
            //临时变量
            int temp;
            bool flag=false;
            for (int i = 0; i < sortArray.Length - 1; i++)
            {
                for (int j = 0; j < sortArray.Length - 1 - i; j++)
                {
                    if (sortArray[j] > sortArray[j + 1])
                    {
                        flag = true;
                        //交换值
                        temp = sortArray[j];
                        sortArray[j] = sortArray[j + 1];
                        sortArray[j + 1] = temp;
                    }
                }
                //优化排序，本轮如果没发生位置交换，退出
                if (flag == false)
                {
                    break;
                }
                else
                {
                    flag= false;
                }
            }
        }
    }
}
