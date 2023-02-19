using System;

namespace Lesson3_练习题
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("二维数组练习题");

            #region 练习题一
            //将1到10000赋值给一个二维数组（100行100列）
            //int[,] array = new int[100, 100];
            //int index = 1;
            //for (int i = 0; i < array.GetLength(0); i++)
            //{
            //    for (int j = 0; j < array.GetLength(1); j++)
            //    {
            //        array[i, j] = index;
            //        ++index;
            //        Console.Write(array[i, j] + " ");
            //    }
            //    Console.WriteLine();
            //}
            #endregion

            #region 练习题二
            //将二维数组（4行4列）的右上半部分置零（元素随机1~100）
            //int[,] array = new int[4, 4];
            //Random r = new Random();
            //for (int i = 0; i < array.GetLength(0); i++)
            //{
            //    for (int j = 0; j < array.GetLength(1); j++)
            //    {
            //        if( i <= 1 && j > 1 )
            //        {
            //            array[i, j] = 0;
            //        }
            //        else
            //        {
            //            array[i, j] = r.Next(1, 101);
            //        }
            //        Console.Write(array[i, j] + " ");
            //    }
            //    Console.WriteLine();
            //}
            #endregion

            #region 练习题三
            //求二维数组（3行3列）的对角线元素的和（元素随机1~10）
            //int[,] array = new int[3, 3];
            //Random r = new Random();
            //int sum = 0;
            //for (int i = 0; i < array.GetLength(0); i++)
            //{
            //    for (int j = 0; j < array.GetLength(1); j++)
            //    {
            //        array[i, j] = r.Next(1, 11);
            //        //对角线 元素 满足的条件
            //        if( i == j || i + j == 2 )
            //        {
            //            sum += array[i, j];
            //        }
            //        Console.Write(array[i, j] + " ");
            //    }
            //    Console.WriteLine();
            //}
            //Console.WriteLine(sum);
            #endregion

            #region 练习题四
            //求二维数组（5行5列）中最大元素值及其行列号（元素随机1~500）
            //int[,] array = new int[5, 5];
            //Random r = new Random();
            ////就是记录 最大值的 行列号
            //int maxI = 0;
            //int maxJ = 0;
            //for (int i = 0; i < array.GetLength(0); i++)
            //{
            //    for (int j = 0; j < array.GetLength(1); j++)
            //    {
            //        array[i, j] = r.Next(1, 501);
            //        Console.Write(array[i, j] + " ");
            //        //找最大值
            //        if( array[maxI, maxJ] < array[i,j] )
            //        {
            //            maxI = i;
            //            maxJ = j;
            //        }
            //    }
            //    Console.WriteLine();
            //}

            //Console.WriteLine("最大值为{0}，行{1}列{2}", array[maxI, maxJ], maxI, maxJ);
            #endregion

            #region 练习题五
            //给一个M*N的二维数组，数组元素的值为0或者1，
            //要求转换数组，将含有1的行和列全部置1
            int[,] array = new int[5, 5] { { 0,0,0,0,0},
                                           { 0,0,0,0,0},
                                           { 0,0,1,1,0},
                                           { 0,0,0,0,0},
                                           { 0,0,0,0,0}};
            Random r = new Random();
            bool[] hang = new bool[5];
            bool[] lie = new bool[5];

            for (int i = 0; i < array.GetLength(0); i++)
            {
                for (int j = 0; j < array.GetLength(1); j++)
                {
                    //array[i, j] = r.Next(0, 2);
                    if( array[i,j] == 1 )
                    {
                        //记录了 当前 行列 是否要变1的标识 
                        //要变一 就置true
                        hang[i] = true;
                        lie[j] = true;
                    }
                    Console.Write(array[i, j] + " ");
                }
                Console.WriteLine();
            }
            Console.WriteLine("**************");
            for (int i = 0; i < array.GetLength(0); i++)
            {
                for (int j = 0; j < array.GetLength(1); j++)
                {
                    //满足行和列的标识 是ture 就变一
                    if( hang[i] || lie[j] )
                    {
                        array[i, j] = 1;
                    }
                    Console.Write(array[i, j] + " ");
                }
                Console.WriteLine();
            }

            #endregion
        }
    }
}
