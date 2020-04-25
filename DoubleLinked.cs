using System;
using System.Collections.Generic;
using System.Text;

namespace 数据结构
{
    public class DoubleLinked<T>
    {
        //头部节点
        public Node Header { get;} = new Node(0, default);

        //双链表节点
        public class Node
        {
            public int Index { get; set; }
            public T Value { get; set; }
            public Node Next { get; set; }
            public Node Pre { get; set; }
            public Node(int index, T value)
            {
                this.Index = index;
                this.Value = value;
            }
            //重写Tostring方法方便查看节点
            public override string ToString()
            {
                return $"index={Index},value={Value}";
            }
        }

        //添加到链表末尾
        public void Append(Node node)
        {
            //辅助指针，指向头节点
            Node pointer = this.Header;
            //查找链表末尾
            while (pointer.Next != null)
            {
                //指向下一节点
                pointer = pointer.Next;
            }
            //添加到末尾
            pointer.Next = node;
            //指向上一节点,
            node.Pre = pointer;
        }

        //有序插入
        public void Insert(Node node)
        {
            Node pointer = this.Header;
            while (pointer.Next != null)
            {
                if (node.Index < pointer.Next.Index)
                {
                    //新指向下一节点
                    node.Next = pointer.Next;
                    //上节点指向新节点
                    pointer.Next = node;
                    //下一节点指向新节点
                    pointer.Next.Pre = node;
                    //新节点指向上一节点
                    node.Pre = pointer;
                    return;
                }
                else if (pointer.Next.Index == node.Index)
                {
                    //如果等于下一个节点，节点以存在返回
                    Console.WriteLine($"节点{node.Index}已经存在");
                    return;
                }
                //没有合适插入位置，指向下一节点
                pointer = pointer.Next;
            }
            //没找到插入位置，添加到末尾
            pointer.Next = node;
            node.Pre = pointer;
        }

        //删节点
        public void Remove(int index)
        {
            if (this.Header.Next == null)
            {
                Console.WriteLine($"空链表");
                return;
            }
            //辅助指针，指向头节点
            Node pointer = this.Header.Next;
            //双向链表节点可以自身删除，不用依赖前一节点
            while (pointer != null)
            {
                if (pointer.Index == index)
                {
                    //前一节点指到下一节点
                    pointer.Pre.Next = pointer.Next;
                    //如果不三节点最后，下一个节点要指向前一节点
                    if (pointer.Next != null)
                    {
                        //下一节点指到前一节点
                        pointer.Next.Pre = pointer.Pre;
                    }
                    return;
                }
                else
                {
                    //没找到继续，指针指向下一节点
                    pointer = pointer.Next;
                }
            }
            Console.WriteLine($"没找节点{index}");
        }

        //打印链表
        public void Scan()
        {
            Node pointer = this.Header;
            while (pointer.Next != null)
            {
                Console.WriteLine(pointer.Next.ToString());
                pointer = pointer.Next;
            }
        }
    }

    public class DoubleLinkedDemo
    {
        static void Main(string[] args)
        {
            Console.WriteLine("向链表添加三位骨架精奇同志");
            var doubleLinked = new DoubleLinked<string>();
            doubleLinked.Append(new DoubleLinked<string>.Node(2, "张三"));
            doubleLinked.Append(new DoubleLinked<string>.Node(5, "李四"));
            doubleLinked.Append(new DoubleLinked<string>.Node(4, "王五"));
            doubleLinked.Scan();
            //---------------------------------------------------
            Console.WriteLine("删除李四");
            doubleLinked.Remove(5);
            doubleLinked.Scan();
            Console.WriteLine("删除张三");
            doubleLinked.Remove(2);
            doubleLinked.Scan();
            Console.WriteLine("删除王五");
            doubleLinked.Remove(4);
            doubleLinked.Scan();
            //---------------------------------------------------
            Console.WriteLine("插入小明");
            doubleLinked.Insert(new DoubleLinked<string>.Node(4, "小明"));
            doubleLinked.Scan();
            Console.WriteLine("插入小李");
            doubleLinked.Insert(new DoubleLinked<string>.Node(1, "小李"));
            doubleLinked.Scan();
        }
    }
}
