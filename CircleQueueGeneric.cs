using System;
using System.Collections.Generic;
using System.Text;

namespace 数据结构
{
    public class CircleQueue<T>
    {
        //队列最大容量
        private int maxSize;
        //队列头
        private int front;
        //队列尾
        private int rear;
        //队列数组
        private T[] arrayQueue;
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
            arrayQueue = new T[this.maxSize];
            //指向队列头
            this.front = 0;
            //指向队列尾的下一个位置，也就三队列头部
            this.rear = 0;
        }
        //入队
        public bool AddQueue(T item)
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
        public T GetQueue()
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
    public class CircleQueueGenericDemo
    {
        static void Main(string[] args)
        {
            //初始化队列
            var queue = new CircleQueue<string>(9);
            Console.WriteLine($"泛型当前队列长度为{queue.Size}");
            Console.WriteLine("向长度为9的入队10个字符串\n");
            for (int i = 1; i <= 10; i++)
            {

                if (queue.IsFull)
                {
                    Console.Write("队列已满“10string”入队失败，");
                    break;
                }
                if (queue.AddQueue($"string{i}"))
                {
                    Console.Write($"string{i}\t");
                }

            }
            Console.WriteLine($"当前队列长度为{queue.Size}\t");


            Console.WriteLine("出队5个字符串...\n");
            for (int i = 1; i <= 5; i++)
            {

                Console.Write($"{queue.GetQueue()}\t");

            }
            Console.WriteLine($"当前队列长度为{queue.Size}\n");
        }
    }
}
