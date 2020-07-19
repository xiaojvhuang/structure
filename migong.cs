using System;

namespace 数据结构
{
    //迷宫
    public class MiGong
    {
       static void Main(string[] args)
        {
            //地图
            int[,] map = new int[8, 8];
            for (int j = 0; j < 8; j++)
            {
                map[0, j] = 1;
                map[7, j] = 1;
            }
            for (int i = 1; i < 7; i++)
            {
                map[i, 0] = 1;
                map[i, 7] = 1;
            }
            //设置挡板
            map[2, 1] = 1;
            map[2, 2] = 1;
            map[2, 3] = 1;

            //打印地图
            for (int i = 0; i < 8; i++)
            {
                for (int j = 0; j < 8; j++)
                {
                    Console.Write(map[i,j]);
                }
                Console.WriteLine();
            }
        }

        //递归回溯找出路
        public bool SetWay(int[,] map, int i, int j)
        {

            return false;
        }
    }
}
