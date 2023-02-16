using System;

namespace Lesson5_值类型和引用类型
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("值类型和引用类型");

            #region 知识点一 变量类型的复习
            //无符号整形
            //byte b = 1;
            //ushort us = 1;
            //uint ui = 1;
            //ulong ul = 1;
            ////有符号整形
            //sbyte sb = 1;
            //short s = 1;
            //int i = 1;
            //long l = 1;
            ////浮点数
            //float f = 1f;
            //double d = 1.1;
            //decimal de = 1.1m;
            ////特殊类型
            //bool bo = true;
            //char c = 'A';
            //string str = "strs";
            //复杂数据类型
            // enum 枚举 
            // 数组 (一维，二维，交错)

            //把以上 学过的 变量类型 分成 值类型和引用类型
            //引用类型: string, 数组, 类（未学习）
            //值类型: 其它、结构体（未学习）
            #endregion

            #region 知识点二 值类型和引用类型的区别

            //1.使用上的区别
            
            //值类型
            int a = 10;
            //引用类型
            int[] arr = new int[] { 1, 2, 3, 4 };

            //申明了一个b让其等于之前的a
            int b = a;
            //申明了一个arr2让其等于之前的arr
            int[] arr2 = arr;
            Console.WriteLine("a={0}, b={1}", a, b);
            Console.WriteLine("arr[0]={0}, arr2[0]={1}", arr[0], arr2[0]);

            b = 20;
            arr2[0] = 5;
            Console.WriteLine("修改了b和arr2[0]之后");
            Console.WriteLine("a={0}, b={1}", a, b);
            Console.WriteLine("arr[0]={0}, arr2[0]={1}", arr[0], arr2[0]);

            //值类型 在相互赋值时 把内容拷贝给了对方  它变我不变
            //引用类型的相互赋值 是 让两者指向同一个值  它变我也变

            //2.为什么有以上区别
            //值类型 和 引用类型 存储在的 内存区域 是不同的 存储方式是不同的
            //所以就造成了 他们在使用上的区别

            // 值类型存储在 栈空间  —— 系统分配，自动回收，小而快
            // 引用类型 存储在 堆空间 —— 手动申请和释放，大而慢

            //new 了 就是开了新房间 和之前的 没有什么关系了 所以 arr不会有任何变化
            arr2 = new int[] { 99,3,2,1};
            Console.WriteLine("arr[0]={0}, arr2[0]={1}", arr[0], arr2[0]);

            #endregion
        }
    }
}
