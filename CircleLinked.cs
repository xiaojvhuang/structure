using System;
using System.Collections.Generic;
using System.Text;

namespace 数据结构
{
    public class CircleLinked
    {
        //创建头指针
        private Node First { get; set; }
        //创建环形链表
        public void Add(int nums)
        {
            if (nums < 1)
            {
                Console.WriteLine("至少需要一个节点");
                return;
            }
            //创建辅助指针
            Node curNode = null;
            for (int n = 1; n <= nums; n++)
            {
                Node node = new Node(n);
                if (n == 1)
                {
                    //First和curNode指针指向第一节点
                    First = node;
                    curNode = First;
                    //指向自己形成环路
                    curNode.Next = First;
                    continue;
                }
                //上一节点断开环路，Next指向下一节点
                curNode.Next = node;
                //curNode指针移指向下一节点
                curNode = node;
                //指向第一个节点，形成环路
                curNode.Next = First;
            }
        }

        //打印环形链表
        public void Scan()
        {
            if (First == null)
            {
                Console.WriteLine("空链表");
            }
            //创建辅助指针
            var curNode = First;
            while (true)
            {
                Console.Write($"{curNode.No}\t");
                //如果Next地址三First说明已经到最后一个
                if (curNode.Next == First)
                {
                    break;
                }
                curNode = curNode.Next;
            }
        }

        /// <summary>
        /// 约瑟夫斯(Josephus)问题
        /// </summary>
        /// <param name="startNo">开始位置</param>
        /// <param name="countNums">数多少次</param>
        /// <param name="nums">节点数</param>
        public void Josephus(int startNo, int countNums, int nums)
        {
            if (First == null || startNo < 1 || startNo > nums)
            {
                Console.WriteLine("参数错误");
                return;
            }
            //只有一个节点，直接输出
            if (First.Next == First)
            {
                Console.WriteLine($"{First.No}");
                return;
            }
            //辅助指针
            Node helpPointer = First;
            //First移到开始位置
            while (true)
            {
                if (First.No == startNo)
                {
                    break;
                }
                First = First.Next;
            }
            //辅助helpPointer指针移动到链表末尾
            while (true)
            {
                if (helpPointer.Next == First)
                {
                    break;
                }
                helpPointer = helpPointer.Next;
            }
            //出列
            bool flag = true;
            while (flag)
            {
                //只剩下一个节点
                if (First.Next == First)
                {
                    flag = false;
                }
                else
                {
                    //数数
                    for (int n = 1; n < countNums; n++)
                    {
                        First = First.Next;
                        helpPointer = helpPointer.Next;
                    }
                }
                //First指向的节点出列
                Console.Write($"{First.No}\t");
                if (flag)
                {
                    First = First.Next;
                    helpPointer.Next = First;
                }
            }
        }

        public class Node
        {
            public int No { get; set; }
            public Node Next { get; set; }
            public Node(int no)
            {
                this.No = no;
            }
        }
    }

    public class Josephus
    {
        public static void Main(string[] args)
        {
            var circle = new CircleLinked();
            Console.WriteLine("加入41个人");
            circle.Add(41);
            circle.Scan();
            Console.WriteLine("\n自杀顺序，最后两个个幸存");
            circle.Josephus(1, 3, 41);
        }
    }
}
