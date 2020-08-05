using System;

namespace 数据结构
{
    //基数排序(桶排序)
    public class RadixSort
    {
        public static void Main(string[] args)
        {
            int[] arraySort = { 23, 2, 18, 9, 389, 111,0};
            foreach (var m in arraySort)
            {
                Console.Write(m + " ");
            }
            Radix(arraySort);
            Console.WriteLine();
            Console.WriteLine("排序之后");
            foreach (var m in arraySort)
            {
                Console.Write(m + " ");
            }
        }

        public static void Radix(int[] array)
        {
            //找出数组中最大值
            int max = array[0];
            for (int i = 1; i < array.Length; i++)
            {
                if (max < array[i])
                {
                    max = array[i];
                }
            }
            int maxLength = max.ToString().Length;
            //十个数组表示桶
            int arrayLength = array.Length;
            int[,] bucket = new int[10, arrayLength];
            //桶元素统计数组
            int[] bucketElementCount = new int[10];
            for (int i = 0, n = 1; i < maxLength; i++, n *= 10)
            {
                //从低位到高位把数据放入对应桶中
                for (int j = 0; j < arrayLength; j++)
                {
                    int digit = array[j] / n % 10;
                    bucket[digit,bucketElementCount[digit]] = array[j];
                    bucketElementCount[digit] ++;
                }
                //把数组从桶中放回原来数组
                int index = 0;
                for (int k = 0; k < bucketElementCount.Length; k++)
                {
                    //如果该桶有数据
                    if (bucketElementCount[k] > 0)
                    {
                        for (int l = 0; l < bucketElementCount[k]; l++)
                        {
                            array[index++] = bucket[k, l];
                        }
                    }
                    //清空桶元素统计数组
                    bucketElementCount[k] = 0;
                }
            }
        }
    }
}
