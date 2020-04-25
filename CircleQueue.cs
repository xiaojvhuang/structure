using System;

namespace 数据结构
{
    public class CircleQueue
    {
        //队列最大容量
        private int maxSize;
        //队列头
        private int front;
        //队列尾
        private int rear;
        //队列数组
        private int[] arrayQueue;
        //队列尾下一位置，如果和头部重合说明队列已满
        //所以队列尾部会空一个位置,这样判断队列是否为空好处理一些
        public bool IsFull { get => (rear + 1) % maxSize == front; }
        //头尾同时指向同一位置为空
        public bool IsEmpty { get => front == rear; }
        //队列剩余数据
        public int Size { get => (maxSize + rear - front) % maxSize; }

        public CircleQueue(int maxSize = 1)
        {
            //由于队列留空了一格，所以最大值要加一
            this.maxSize = maxSize + 1;
            arrayQueue = new int[this.maxSize];
            //指向队列头
            this.front = 0;
            //指向队列尾的下一个位置，也就三队列头部
            this.rear = 0;
        }
        //入队
        public bool AddQueue(int item)
        {
            if (IsFull)
            {
                Console.WriteLine("队列已满...");
                return false;
            }
            arrayQueue[rear] = item;
            //尾指向下一位置
            rear = (rear + 1) % this.maxSize;
            return true;
        }
        //出队
        public int GetQueue()
        {
            if (IsEmpty)
            {
                throw new IndexOutOfRangeException("队列为空...");

            }
            //头指向下一位置
            var val = arrayQueue[front];
            front = (front + 1) % this.maxSize;
            return val;
        }
    }

    public class CircleQueueDemo
    {
        static void Main(string[] args)
        {
            //初始化队列
            var queue = new CircleQueue(9);
            Console.WriteLine($"当前队列长度为{queue.Size}");
            Console.WriteLine("向长度为9的入队10个数字\n");
            for (int i = 1; i <= 10; i++)
            {

                if (queue.IsFull)
                {
                    Console.Write("队列已满“10”入队失败，");
                    break;
                }
                if (queue.AddQueue(i))
                {
                    Console.Write($"{i}\t");
                }

            }
            Console.WriteLine($"当前队列长度为{queue.Size}\t");

            //-----------------------------------------------------------

            Console.WriteLine("出队5个数字...\n");
            for (int i = 1; i <= 5; i++)
            {

                Console.Write($"{queue.GetQueue()}\t");

            }
            Console.WriteLine($"当前队列长度为{queue.Size}\n");

            //-----------------------------------------------------------

            Console.WriteLine("向队列队列插入10个数字...\n");
            for (int i = 1; i <= 10; i++)
            {
                if (queue.IsFull)
                {
                    Console.Write("队列已满“6 7 8 9 10”入队失败，");
                    break;
                }
                if (queue.AddQueue(i))
                {
                    Console.Write($"{i}\t");
                }

            }
            Console.WriteLine($"当前队列长度为{queue.Size}\n");

            //-----------------------------------------------------------

            Console.WriteLine($"打印当前队列");
            var size = queue.Size;
            for (int i = 0; i < size; i++)
            {
                Console.Write($"{queue.GetQueue()}\t");
            }
            Console.WriteLine($"当前队列长度为{queue.Size}\n");
        }
    }
}
