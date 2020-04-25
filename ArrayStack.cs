using System;

namespace 数据结构
{
    public class ArrayStack<T>
    {
        //栈最大值
        private int MaxSize { get; set; }
        private T[] Item { get; set; }
        //指向栈顶，当栈为空是初始化为-1
        private int Top { get; set; } = -1;
        //栈是否为空
        public bool IsEmpt { get => Top == -1; }
        //栈是否满了
        public bool IsFull { get => Top == MaxSize - 1; }
        public ArrayStack(int maxSize)
        {
            this.MaxSize = maxSize;
            this.Item = new T[maxSize];
        }
        
        //入栈
        public void Push(T item)
        {
            if (IsFull)
            {
                Console.WriteLine("栈满了哦");
                return;
            }
            Top++;
            Item[Top] = item;
        }

        //出栈
        public T Pop()
        {
            if (IsEmpt)
            {
                Console.WriteLine("栈空了哦");
                return default;
            }
            var item = Item[Top];
            Top--;
            return item;
        }

        //偷看栈顶
        public T Peek()
        {
            if (IsEmpt)
            {
                Console.WriteLine("栈空了哦");
                return default;
            }
            return Item[Top];
        }
    }
    public class ArrayStackDemo
    {
        public static void Main(string[] args)
        {
            var stack = new ArrayStack<string>(10);
            Console.WriteLine("张三，李四，王五 入栈了");
            stack.Push("张三");
            stack.Push("李四");
            stack.Push("王五");

            Console.WriteLine("王五，李四，张三 出栈了");
            Console.WriteLine($"看谁在栈顶？{stack.Peek()}");
            stack.Pop();
            Console.WriteLine($"看谁在栈顶？{stack.Peek()}");
            stack.Pop();
            Console.WriteLine($"看谁在栈顶？{stack.Peek()}");
            stack.Pop();
            stack.Pop();
        }
    }
}
