using System;

namespace 数据结构
{
    public class Linked<T>
    {
        //头部节点
        private Node Header { get; } = new Node(0, default);

        //添加到链表末尾
        public void Append(Node node)
        {
            //临时节点，从指向头部节点开始查找
            Node temp = this.Header;
            //下节点为空才链表结尾
            while (temp.Next != null)
            {
                //指向下一个节点
                temp = temp.Next;
            }
            //加到末尾
            temp.Next = node;
        }

        //插入节点
        public void Insert(Node node)
        {
            //临时节点，从指向头部节点开始查找
            Node temp = this.Header;
            //下节点不为空继续向下查找
            while (temp.Next != null)
            {
                if (node.Index < temp.Next.Index)
                {
                    //如果小于下一个节点就插到下一个节点前面
                    node.Next = temp.Next;
                    temp.Next = node;
                    return;
                }
                else if (node.Index == temp.Next.Index)
                {
                    //如果等于下一个节点，节点以存在返回
                    Console.WriteLine($"节点{node.Index}已经存在");
                    return;
                }
                //继续查找
                temp = temp.Next;
            }
            //插入末尾
            temp.Next = node;
        }

        //移除节点
        public void Remove(int index)
        {
            //临时节点，从指向头部节点开始查找
            Node temp = this.Header;
            //下一节点不为空继续往下找
            while (temp.Next != null)
            {
                if (temp.Next.Index == index)
                {
                    //找到，Next 指向下下个节点
                    temp.Next = temp.Next.Next;
                    return;
                }
                else
                {
                    //继续查找
                    temp = temp.Next;
                }
            }
            Console.WriteLine($"没找节点{index}");
        }

        //反转列表
        public void Rverse()
        {
            //指向当前节点
            Node curNode = this.Header.Next;
            //当断开当前节点时，指向下一节点，避免链表断开
            Node nexNode = null;
            //新表头
            Node rverseHeader = new Node(0, default);
            //只有一个元素不用处理
            if (Header.Next == null || Header.Next.Next == null)
            {
                return;
            }
            while (curNode != null)
            {
                //指向下一节点
                nexNode = curNode.Next;
                //断开当前节点，并指向上一节点地址，当第一次进入上节点地址为空
                curNode.Next = rverseHeader.Next;
                //头节点指向当前节点
                rverseHeader.Next = curNode;
                //指向下节点
                curNode = nexNode;
            }
            //旧节点头重新指向反转后第一个元素
            Header.Next = rverseHeader.Next;
        }

        //打印所有节点
        public void Scan()
        {
            //建立临时节点，从指向头部节点开始查找
            Node temp = this.Header;
            while (temp.Next != null)
            {
                Console.WriteLine(temp.Next.ToString());
                //临时节点指向下一节点
                temp = temp.Next;
            }
        }

        //链表节点
        public class Node
        {
            public int Index { get; set; }
            public T Value { get; set; }
            public Node Next { get; set; }
            public Node(int index, T val)
            {
                this.Index = index;
                this.Value = val;
            }
            //重写Tostring方法方便查看
            public override string ToString()
            {
                return $"index={Index},value={Value}";
            }
        }
    }

    public class LinkedListDemo
    {
        static void Main(string[] agrs)
        {
            Console.WriteLine("向链表添加三位骨架精奇同志");
            var Linked = new Linked<string>();
            Linked.Append(new Linked<string>.Node(2, "张三"));
            Linked.Append(new Linked<string>.Node(5, "李四"));
            Linked.Append(new Linked<string>.Node(4, "王五"));
            Linked.Scan();
            //---------------------------------------------------
            Console.WriteLine("删除王五");
            Linked.Remove(4);
            Linked.Scan();
            //---------------------------------------------------
            Console.WriteLine("插入小明");
            Linked.Insert(new Linked<string>.Node(4, "小明"));
            Linked.Scan();
            Console.WriteLine("插入小李");
            Linked.Insert(new Linked<string>.Node(1, "小李"));
            Linked.Scan();
            //---------------------------------------------------
            Console.WriteLine("反转链表");
            Linked.Rverse();
            Linked.Scan();
        }
    }
}
