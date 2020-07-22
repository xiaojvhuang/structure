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
            Bubble();
            Console.WriteLine();
            Console.WriteLine("排序之后");
            foreach (var m in sortArray)
            {
                Console.Write(m + " ");
            }
        }

        //冒泡
        public static void Bubble()
        {
            //临时变量
            int temp;
            for (int i = 0; i <sortArray.Length-1; i++)
            {
                for (int j = 0; j < sortArray.Length-i-1; j++)
                {
                    if (sortArray[j] > sortArray[j + 1])
                    {
                        temp = sortArray[j];
                        sortArray[j] = sortArray[j + 1];
                        sortArray[j + 1]= temp;
                    }
                }
            }
        }
    }
}
