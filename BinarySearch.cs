using System;
using System.Collections.Generic;

namespace 数据结构
{
    public class BinarySearch
    {
        public static void Main(string[] args)
        {
            int[] arraySearch = { 1, 5, 8, 9, 9, 9, 9, 9, 9, 11, 32 };

            var list = Search(arraySearch, 0, arraySearch.Length - 1, 9);
            if (list.Count > 0)
            {
                Console.WriteLine("找到了位置:");
                foreach (var m in list)
                {
                    Console.Write($"{m} ");
                }
            }
            else
            {
                Console.WriteLine("没找到");
            }
        }

        //二分查找
        public static IList<int> Search(int[] array, int left, int right, int findVal)
        {
            if (left > right)
            {
                return new List<int>();
            }
            int mid = (left + right) / 2;
            int midVal = array[mid];

            if (findVal > midVal)//向右递归查找
            {
                return Search(array, mid + 1, right, findVal);
            }
            else if (findVal < midVal)//向左递归查找
            {
                return Search(array, left, mid - 1, findVal);
            }
            else//找到了
            {
                IList<int> list = new List<int>();
                //可能存在多个相同值，向左查找
                int temp = mid - 1;
                while (true)
                {
                    if (temp < 0 || array[temp] != findVal)
                    {
                        break;
                    }
                    list.Add(temp);
                    temp--;
                }
                list.Add(mid);
                //可能存在多个相同值，向右查找
                temp = mid + 1;
                while (true)
                {
                    if (temp > array.Length - 1 || array[temp] != findVal)
                    {
                        break;
                    }
                    list.Add(temp);
                    temp++;
                }
                return list;
            }
        }
    }
}
