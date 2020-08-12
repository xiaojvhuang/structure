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
    }

    //哈希表
    public class HaseTab
    { 
    }
}
