using System;

namespace 数据结构
{
    public class SparseArray
    {
        static void Main(string[] args)
        {
            #region 创建原始二维数组
            //0表示没有棋子，1表示白棋，2表示黑棋
            int row = 11;
            int col = 11;
            int[,] chessAarry1 = new int[row, col];
            chessAarry1[1, 2] = 1;
            chessAarry1[2, 3] = 2;
            chessAarry1[5, 6] = 1;
            chessAarry1[3, 5] = 2;

            //打印二维数组
            Console.WriteLine("打印原始二维数组：");
            for (int r = 0; r < chessAarry1.GetLength(0); r++)
            {
                for (int i = 0; i < chessAarry1.GetLength(1); i++)
                {
                    Console.Write($"{chessAarry1[r, i]}\t");
                }
                Console.WriteLine("");
            }
            #endregion

            #region 创建稀疏数组
            //（1）统计原始二维数组有效数据
            int sum = 0;
            foreach (var item in chessAarry1)
            {
                if (item > 0) sum++;
            }
            int[,] sparseArray = new int[sum + 1, 3];
            sparseArray[0, 0] = row;
            sparseArray[0, 1] = col;
            sparseArray[0, 2] = sum;

            //（2）从原始二维数组读取有效数据到稀疏数组
            int insert = 0;
            for (int r = 0; r < chessAarry1.GetLength(0); r++)
            {
                for (int i = 0; i < chessAarry1.GetLength(1); i++)
                {
                    var val = chessAarry1[r, i];
                    if (val > 0)
                    {
                        insert++;
                        sparseArray[insert, 0] = r;
                        sparseArray[insert, 1] = i;
                        sparseArray[insert, 2] = val;
                    }
                    if (sum == insert) break;
                }
                if (sum == insert) break;
            }

            //打印稀疏数组
            Console.WriteLine("打印稀疏数组:");
            for (int r = 0; r < sparseArray.GetLength(0); r++)
            {
                Console.WriteLine($"{sparseArray[r, 0]}\t{sparseArray[r, 1]}\t{sparseArray[r, 2]}");
            }
            #endregion

            #region 恢复原始二维数组
            //（1）创建所有元素都为0的二维数组
            int row2 = sparseArray[0, 0];
            int col2 = sparseArray[0, 1];
            int val2 = sparseArray[0, 2];
            int[,] chessAarry2 = new int[row2, col2];
            //（2）从稀疏数组读取有效数据到原始二维数组
            for (int r = 1; r < sparseArray.GetLength(0); r++)
            {
                row2 = sparseArray[r, 0];
                col2 = sparseArray[r, 1];
                val2 = sparseArray[r, 2];
                chessAarry2[row2, col2] = val2;
            }

            //打印二维数组
            Console.WriteLine("打印原始二维数组：");
            for (int r = 0; r < chessAarry2.GetLength(0); r++)
            {
                for (int i = 0; i < chessAarry2.GetLength(1); i++)
                {
                    Console.Write($"{chessAarry2[r, i]}\t");
                }
                Console.WriteLine();
            }
            #endregion
        }
    }
}


