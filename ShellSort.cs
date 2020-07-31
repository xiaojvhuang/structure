using System;

namespace 数据结构
{
    public class ShellSort
    {
        public static void Main(string[] args)
        {
            int[] sortArray = {5,4,3,2,1};
            Console.WriteLine("排序前");
            foreach (var i in sortArray)
            {
                Console.Write(i + " ");
            }
            Console.WriteLine("");

            Shell(sortArray);

            Console.WriteLine("排序后");
            foreach (var i in sortArray)
            {
                Console.Write(i + " ");
            }
        }

        public static void Shell(int[] array)
        {
            int count = 0;
            int j;
            int temp;
            //按缩小增量分组
            for (int gap = array.Length / 2; gap > 0; gap /= 2)
            {
                //------------------------
                count++;
                Console.WriteLine($"第{count}轮:");
                //------------------------

                for (int i = gap; i < array.Length; i++)
                {
                    //插入排序（移位法）
                    j = i;
                    temp = array[i];
                    if (array[j] < array[j - gap])
                    {
                        //temp < array[j - gap]继续比较下一个元素
                        while (j - gap >= 0 && temp < array[j - gap])
                        {
                            //移位
                            array[j] = array[j - gap];
                            j -= gap;
                        }
                        //退出while时，表示已经找到temp要插入位置
                        array[j] = temp;
                    }

                    //------------------------
                    foreach (var m in array)
                    {
                        Console.Write(m + " ");
                    }
                    Console.WriteLine("");
                    //-----------------------
                }
                Console.WriteLine("");
            }
        }
    }
}
