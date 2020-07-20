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
            //map[1, 4] = 1;

            //打印地图
            Console.WriteLine("迷宫地图");
            for (int i = 0; i < 8; i++)
            {
                for (int j = 0; j < 8; j++)
                {
                    Console.Write(map[i,j]);
                }
                Console.WriteLine();
            }

            SetWay(map, 1, 1);

            //打印地图
            Console.WriteLine("");
            Console.WriteLine("迷宫走过路径地图");
            for (int i = 0; i < 8; i++)
            {
                for (int j = 0; j < 8; j++)
                {
                    Console.Write(map[i, j]);
                }
                Console.WriteLine();
            }
        }

        //递归回溯找出路
        //map[1,1]入口，开始位置
        //map[6,6]出口，结束位置
        //约定：1表示墙，2表示走得通，3表示探测过走不通
        public static bool SetWay(int[,] map, int i, int j)
        {
            //已经找到出口
            if (map[6, 6] == 2)
            {
                return true;
            }
            if (map[i, j] == 0)
            {
                //假设map[i, j]，走得通
                map[i, j] = 2;
                if (SetWay(map, i + 1, j))//向下找
                {
                    return true;
                }
                else if (SetWay(map, i, j + 1))//向右找
                {
                    return true;
                }
                else if (SetWay(map, i - 1, j))//向上向找
                {
                    return true;
                }
                else if (SetWay(map, i, j - 1))//向左找
                {
                    return true;
                }
                else
                {
                    //走不通，回溯
                    map[i, j] = 3;
                    return false;
                }
            }
            else
            {
                //1,2,3情况
                return false;
            }
        }
    }
}
