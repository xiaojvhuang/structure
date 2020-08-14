using System;
using System.Collections.Generic;

namespace 数据结构
{
    public class HaseTabDemo
    {
        public static void Main(string[] args)
        {
            //while (true)
            //{
            var id = Console.Read();
            Console.WriteLine(id);
            //}
        }
    }

    //员工
    public class Emp
    {
        public int id;
        public string name;
        public Emp next;
        public Emp(int id, string name)
        {
            this.id = id;
            this.name = name;
        }
    }

    //链表
    public class LinkedList
    {
        //头指针
        private Emp head;
        //添加
        public void Add(Emp emp)
        {
            if (head == null)
            {
                head = emp;
                return;
            }
            //辅助指针
            Emp helpPointer = head;
            while (helpPointer.next != null)
            {
                //指针移到下一节点
                helpPointer = helpPointer.next;
            }
            helpPointer.next = emp;

        }

        //遍历
        public void List()
        {
            if (head == null)
            {
                Console.WriteLine("当前链表为空");
                return;
            }
            //辅助指针
            Emp helpPointer = head;
            do
            {
                Console.WriteLine($"=> ID={helpPointer.id}name={helpPointer.name}");
                helpPointer = helpPointer.next;

            } while (helpPointer != null);
        }
    }

    //哈希表
    public class HaseTab
    { 
    }
}
