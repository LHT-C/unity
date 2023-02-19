using System;

namespace Lesson7_练习题
{
    class Program
    {
        #region 练习题一
        //写一个函数，比较两个数字的大小，返回最大值
        // 2个参数  一个返回值

        static int CheckMax(int a, int b)
        {
            //1
            //if (a > b)
            //{
            //    return a;
            //}
            //else
            //{
            //    return b;
            //}
            //2
            //if( a > b )
            //{
            //    return a;
            //}
            //return b;
            //3
            return a > b ? a : b;
        }
        #endregion

        #region 练习题二
        //写一个函数，用于计算一个圆的面积和周长，并返回打印
        // 面积：πr²  周长：2πr   函数肯定有一个半径的参数传入
        // 多返回值 ： 通过数组的形式 自己定义个返回的顺序

        static float[] CalcCirc(float r)
        {
            //1
            //float[] f = new float[2];
            //f[0] = 3.14f * r * r;
            //f[1] = 2 * 3.14f * r;
            //return f;

            //2
            return new float[] { 3.14f * r * r, 2 * 3.14f * r };
        }
        #endregion

        #region 练习题三
        //写一个函数，求一个数组的总合、最大值、最小值、平均值
        // 参数：传一个数组  返回值：可以用数组返回值 把这些都返回回去  你也可以没有返回值 直接在函数内部打印

        static void Calc( int[] arr )
        {
            if( arr.Length == 0 )
            {
                Console.WriteLine("数组不能为空");
                return;
            }

            int sum = 0;
            int avg = 0;
            int max = arr[0];
            int min = arr[0];

            for (int i = 0; i < arr.Length; i++)
            {
                sum += arr[i];
                //当前的元素 比最大数还大 那当前的元素 就是最大值
                if( max < arr[i] )
                {
                    max = arr[i];
                }
                //当前的元素 比最小值还小 那当前的元素 就是最小值
                if( min > arr[i] )
                {
                    min = arr[i];
                }
            }
            avg = sum / arr.Length;

            Console.WriteLine("最大值{0}最小值{1}总合{2}平均数{3}", max, min, sum, avg);
        }
        #endregion

        #region 练习题四
        // 写一个函数，判断你传入的参数是不是质数
        // 质数：一个只能被1和自己整除的数 
        // 是不是：bool类型的返回值 true是是 false是不是
        // 参数：int

        static bool IsPrime(int num)
        {
            //判断质数的逻辑
            for (int i = 2; i < num; i++)
            {
                //得到从2到 num-1之间的数 
                if( num % i == 0 )
                {
                    // 之前和循环配合使用 break continue
                    return false;
                }
            }
            //默认就认为它是质数
            return true;
        }
        #endregion

        #region 练习题五
        //写一个函数，判断你输入的年份是否是闰年
        //闰年判断条件：
        //年份能被400整除（2000）
        //或者
        //年份能被4整除，但是不能被100整除（2008）

        static bool IsLeapYear(int year)
        {
            // year % 400 == 0
            // ||
            // year % 4 == 0 && year % 100 != 0
            //满足闰年条件 那就是闰年
            if( year % 400 == 0 || ( year % 4 == 0 && year % 100 != 0 ) )
            {
                return true;
            }

            //默认不是闰年
            return false;
        }
        #endregion

        static void Main(string[] args)
        {
            Console.WriteLine("函数练习题");

            Console.WriteLine(CheckMax(3, 99));

            float[] f = CalcCirc(3);
            Console.WriteLine("半径{0},面积{1},周长{2}", 2, f[0], f[1]);

            int[] arr = { 1, 2, 3, 4, 5, 6, 7, 8 };
            Calc(arr);

            Calc(new int[] { 1, 2, 3 });

            Console.WriteLine("{0}{1}质数", 6, IsPrime(6) ? "是" : "不是");

            Console.WriteLine("{0}{1}闰年", 2010, IsLeapYear(2010) ? "是" : "不是");
        }
    }
}
