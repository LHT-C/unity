using System;

namespace Lesson9_练习题
{
    class Program
    {
        #region 练习题一
        //使用param参数，求多个数字的和以及平均数
        static void CalcSumAvg( params int[] arr )
        {
            if( arr.Length == 0 )
            {
                Console.WriteLine("没有参数");
                return;
            }

            int sum = 0;
            int avg = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                //求总合
                sum += arr[i];
            }
            avg = sum / arr.Length;

            Console.WriteLine("总合{0}平均数{1}", sum, avg);
        }
        #endregion

        #region 练习题二
        //使用param参数，求多个数字的偶数和奇数和
        static void Calc( params int[] arr)
        {
            if( arr.Length == 0 )
            {
                Console.WriteLine("没有传参数");
                return;
            }
            //奇数和
            int sum1 = 0;
            //偶合和
            int sum2 = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                if( arr[i] % 2 == 0 )
                {
                    sum2 += arr[i];
                }
                else
                {
                    sum1 += arr[i];
                }
            }
            Console.WriteLine("奇数和{0}偶数和{1}", sum1, sum2);
        }
        #endregion

        static void Main(string[] args)
        {
            Console.WriteLine("变长参数练习题");

            CalcSumAvg();
            CalcSumAvg(1, 2, 3, 4, 5, 6, 7);

            Calc();
            Calc(1, 2, 3, 4, 5, 6, 7);
        }
    }
}
