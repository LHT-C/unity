using System;

namespace Lesson10_练习题
{
    class Program
    {
        #region 练习题一
        //请重载一个函数
        //让其可以比较两个int或两个float或两个double的大小
        //并返回较大的那个值

        static int GetMax(int a, int b)
        {
            return a > b ? a : b;
        }

        static float GetMax(float a, float b)
        {
            return a > b ? a : b;
        }

        static double GetMax(double a, double b)
        {
            return a > b ? a : b;
        }

        #endregion

        #region 练习题二
        //请重载一个函数
        //让其可以比较n个int或n个float或n个double的大小
        //并返回最大的那个值。（用params可变参数来完成）

        static int GetMax(params int[] arr)
        {
            if( arr.Length == 0 )
            {
                Console.WriteLine("没有传入任何参数");
                return -1;
            }
            //因为默认认为第一个数就是最大值了 所以没有必要和第一个数比较
            int max = arr[0];
            //所以直接从i=1开始遍历
            for (int i = 1; i < arr.Length; i++)
            {
                if( max < arr[i] )
                {
                    max = arr[i];
                }
            }
            return max;
        }

        static float GetMax(params float[] arr)
        {
            if (arr.Length == 0)
            {
                Console.WriteLine("没有传入任何参数");
                return -1;
            }
            //因为默认认为第一个数就是最大值了 所以没有必要和第一个数比较
            float max = arr[0];
            //所以直接从i=1开始遍历
            for (int i = 1; i < arr.Length; i++)
            {
                if (max < arr[i])
                {
                    max = arr[i];
                }
            }
            return max;
        }

        static double GetMax(params double[] arr)
        {
            if (arr.Length == 0)
            {
                Console.WriteLine("没有传入任何参数");
                return -1;
            }
            //因为默认认为第一个数就是最大值了 所以没有必要和第一个数比较
            double max = arr[0];
            //所以直接从i=1开始遍历
            for (int i = 1; i < arr.Length; i++)
            {
                if (max < arr[i])
                {
                    max = arr[i];
                }
            }
            return max;
        }

        #endregion

        static void Main(string[] args)
        {
            Console.WriteLine("函数重载练习题");

            Console.WriteLine(GetMax(1, 2));
            Console.WriteLine(GetMax(1.1f, 2.2f));
            Console.WriteLine(GetMax(10.2, 20.3));

            Console.WriteLine(GetMax(1, 2, 3, 4, 5, 6));
            Console.WriteLine(GetMax(1.1f, 2.2f, 3, 4, 5, 6));
            Console.WriteLine(GetMax(1.1, 2, 3, 4, 5, 6));
        }
    }
}
