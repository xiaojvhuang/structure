using System;

namespace 数据结构
{
    public class Queen
    {
        //皇后数
        const int queenMax = 8;
        //统计共有多少种摆法
        static int count;
        //定义数组存放皇后位置结果，如｛0，4，7，5，2，6，1，3｝
        int[] arrayQueen = new int[queenMax];
        public static void Main(string[] args)
        {
            Queen queen = new Queen();
            queen.Check(0);
            Console.WriteLine($"共有{count}种摆法");
        }

        //打印皇后位置
        private void Print()
        {
            count++;
            foreach (var q in arrayQueen)
            {
                Console.Write(q+" ");
            }
            Console.WriteLine();
        }

        //n表示第几个皇后
        private void Check(int n)
        {
            if (n == queenMax)
            {
                Print();
                return;
            }
            //每一行都摆8次
            for (int j = 0; j < queenMax; j++)
            {
                //皇后摆放位置，回溯
                arrayQueen[n] = j;
                //如果没冲突摆放下个皇后
                if (judge(n))
                {
                    Check(n + 1);
                }
                //如果冲突继续摆放下一个皇后位置arrayQueen[n] = j++
            }
        }

        //n表示第几个皇后
        private bool judge(int n)
        {
            for (int i = 0; i < n; i++)
            {
                //ArrayQueen[i] == ArrayQueen[n]皇后是否在同一列
                //Math.Abs(n - i) == Math.Abs(ArrayQueen[n] - ArrayQueen[i])皇后是否在同一斜线上
                if (arrayQueen[i] == arrayQueen[n] || Math.Abs(n - i) == Math.Abs(arrayQueen[n] - arrayQueen[i]))
                {
                    return false;
                }
            }
            return true;
        }
    }
}