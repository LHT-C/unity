using System;

namespace Lesson13_练习题
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("冒泡排序练习题");

            #region 练习题一
            //定义一个数组，长度为20，每个元素值随机0~100的数
            //使用冒泡排序进行升序排序并打印
            //使用冒泡排序进行降序排序并打印

            int[] arr = new int[20];
            Random r = new Random();
            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] = r.Next(0, 101);
                Console.Write(arr[i] + " ");
            }
            Console.WriteLine();

            //套路写法
            //两层循环
            //外层轮数
            bool isSort = false;
            for (int i = 0; i < arr.Length; i++)
            {
                isSort = false;
                //内层比较
                for (int j = 0; j < arr.Length - 1 - i; j++)
                {
                    //两值比较
                    //满足交换
                    // 降序还是升序 改这的比较条件就行了
                    if ( arr[j] < arr[j + 1] )
                    {
                        isSort = true;
                        int temp = arr[j];
                        arr[j] = arr[j + 1];
                        arr[j + 1] = temp;
                    }
                }
                if(!isSort)
                {
                    break;
                }
            }

            for (int i = 0; i < arr.Length; i++)
            {
                Console.Write(arr[i] + " ");
            }

            #endregion

            #region 练习题二
            //写一个函数，实现一个数组的排序，并返回结果。可以根据参数决定是升序还是降序
            Console.WriteLine();
            int[] arr2 = { 3, 7, 2, 1, 9, 8, 6, 5, 4 };

            Sort(arr2, false);

            for (int i = 0; i < arr2.Length; i++)
            {
                Console.Write(arr2[i] + " ");
            }
            #endregion
        }

        static int[] Sort( int[] array, bool isAscendingOrder )
        {
            //小优化 在循环外申明变量 可以提高一些性能
            bool order;
            int temp;
            for (int i = 0; i < array.Length; i++)
            {
                for (int j = 0; j < array.Length - 1 - i; j++)
                {
                    //根据传入的 升序降序类型 决定使用什么规则 然后返回给一个bool值
                    order = isAscendingOrder ? array[j] > array[j + 1] : array[j] < array[j + 1];
                    if ( order )
                    {
                        temp = array[j];
                        array[j] = array[j + 1];
                        array[j + 1] = temp;
                    }
                }
            }
            return array;
        }
    }
}
