using System;

namespace 数据结构
{
    public class ShellSort
    {
        public static void Main(string[] args)
        {
            int[] sortArray = {8,9,6,7,2,3,5,4,1};
            Console.WriteLine("排序前");
            foreach (var i in sortArray)
            {
                Console.Write(i + " ");
            }
            Console.WriteLine("");

            Shell(sortArray);
        }

        public static void Shell(int[] array)
        {
            int count = 0;
            int j = 0;
            int temp = 0;
            //按缩小增量分组
            for (int gap = array.Length / 2; gap > 0; gap /= 2)
            {
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
                }
                count++;
                Console.WriteLine($"第{count}轮:");
                foreach (var i in array)
                {
                    Console.Write(i + " ");
                }
                Console.WriteLine("");
            }
        }
    }
}
