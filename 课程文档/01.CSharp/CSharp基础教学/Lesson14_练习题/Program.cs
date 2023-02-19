using System;

namespace Lesson14_练习题
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("选择排序练习题");
            #region 练习题一
            //定义一个数组，长度为20，每个元素值随机0~100的数
            //使用选择排序进行升序排序并打印
            //使用选择排序进行降序排序并打印

            int[] array = new int[20];
            Random r = new Random();
            for (int i = 0; i < array.Length; i++)
            {
                array[i] = r.Next(0, 101);
                Console.Write(array[i] + " ");
            }
            Console.WriteLine();

            //套路写法
            //两层循环

            int index;
            int temp;
            //外层轮数
            for (int i = 0; i < array.Length; i++)
            {
                //初始索引
                index = 0;
                //内层寻找
                for (int j = 1; j < array.Length - i; j++)
                {
                    //记录极值
                    //这里决定了 找到极值的种类 
                    //只需要改这的条件 就可以改变 降序还是升序
                    if ( array[index] > array[j] )
                    {
                        index = j;
                    }
                }

                //内层循环外交换
                if( index != array.Length - 1 - i )
                {
                    temp = array[index];
                    array[index] = array[array.Length - 1 - i];
                    array[array.Length - 1 - i] = temp;
                }
            }

            for (int i = 0; i < array.Length; i++)
            {
                Console.Write(array[i] + " ");
            }
            Console.WriteLine();

            #endregion
        }
    }
}
