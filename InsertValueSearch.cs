using System;

namespace 数据结构
{
    public class InsertValueSearch
    {
        public static void Main(string[] args)
        {
            int[] arraySearch = { 1, 5, 8, 9, 11, 13, 15 };

            var index = InsertSearch(arraySearch, 0, arraySearch.Length - 1, 5);
            if (index >= 0)
            {
                Console.WriteLine($"找到了位置:{index}");
            }
            else
            {
                Console.WriteLine("没找到");
            }
        }

        public static int InsertSearch(int[] array, int low, int high, int findVal)
        {
            Console.WriteLine("我来了。。。。。。。。。。。");
            if (low > high || findVal < array[low] || findVal > array[high])
            {
                return -1;
            }

            //插值公式推导，mid=(low+high)/2=low+1/2(high-low) 
            //=> low+(high-low)*(findVal-arr[low])/(arr[high]-a[low])
            int mid = low + (high - low) * (findVal - array[low]) / (array[high] - array[low]);
            int midVal = array[mid];

            if (findVal > midVal)
            {
                //向右递归
                return InsertSearch(array, mid + 1, high, findVal);
            }
            else if (findVal < midVal)
            {
                //向左递归
                return InsertSearch(array, low, mid - 1, findVal);
            }
            else
            {
                return mid;
            }
        }
    }
}
