using System;

namespace 数据结构
{
    public class ArrayQueue
    {
        private int maxSize;//队列最大值        
        private int front;//队列头
        private int rear;//队列尾
        private int[] arrayQueue;//模拟队列数组
        //初始化队列
        public ArrayQueue(int maxSize = 1)
        {
            this.maxSize = maxSize;
            this.arrayQueue = new int[maxSize];
            this.front = -1;//指向队列头前一个位置
            this.rear = -1;//指向队列尾，队列最后一个位置
        }

        //判断队列是否已满
        public bool IsFull()
        {
            return rear == maxSize - 1;
        }
        public bool IsEmpty()
        {
            return front == rear;
        }

        //入队
        public bool AddQueue(int item)
        {
            //队列已满
            if (IsFull())
            {
                Console.WriteLine("队列已满...");
                return false;
            }
            rear++;
            arrayQueue[rear] = item;
            return true;
        }

        //出队
        public int GetQueue()
        {
            //队列为空
            if (IsEmpty())
            {
                throw new IndexOutOfRangeException("队列为空...");
            }
            front++;
            return arrayQueue[front];
        }
    }

    public class ArrayQueueDemo
    {
        static void Main(string[] args)
        {
            //初始化队列
            var queue = new ArrayQueue(1);
            try
            {
                queue.GetQueue();
            }
            catch
            {
                Console.WriteLine("队列还是空的呢...\n");
            }
            Console.WriteLine("开始入队...\n");
            for (int i = 1; i <= 6; i++)
            {
                queue.AddQueue(i);
            }
            Console.WriteLine("\n开始出队...\n");
            for (int i = 1; i < 6; i++)
            {
                Console.WriteLine(queue.GetQueue());
            }
            try
            {
                queue.GetQueue();
            }
            catch
            {
                Console.WriteLine("全部出队了哦...");
            }
        }
    }
}