using System;

namespace Lesson10_函数重载
{
    class Program
    {
        #region 知识点一 基本概念
        //重载概念
        //在同一语句块(class或者struct)中
        //函数（方法）名相同
        //参数的数量不同 
        //或者
        //参数的数量相同，但参数的类型或顺序不同

        //作用：
        //1.命名一组功能相似的函数，减少函数名的数量，避免命名空间的污染
        //2.提升程序可读性
        #endregion

        #region 知识点二 实例
        //注意：
        //1.重载和返回值类型无关，只和参数类型，个数，顺序有关
        //2.调用时 程序会自己根据传入的参数类型判断使用哪一个重载
        static int CalcSum(int a, int b)
        {
            return a + b;
        }

        //参数数量不同
        static int CalcSum(int a, int b, int c)
        {
            return a + b + c;
        }

        //数量相同 类型不同
        static float CalcSum(float a, float b)
        {
            return a + b;
        }

        //数量相同 类型不同
        static float CalcSum(int a, float f)
        {
            return a + f;
        }

        //数量相同 顺序不同
        static float CalcSum(float f, int a)
        {
            return f + a;
        }

        //ref 和 out

        // ref和out 可以理解成 他们也是一种变量类型 所以可以用在重载中 但是 ref和out不能同时修饰
        static float CalcSum(ref float f, int a)
        {
            return f + a;
        }

        static float CalcSum(int a, int b, params int[] arr)
        {
            return 1;
        }


        #endregion


        //总结
        //概念：同一个语句块中，函数名相同，参数数量、类型、顺序不同的函数 就称为我们的重载函数
        //注意：和返回值无关
        //作用：一般用来处理不同参数的同一类型的逻辑处理

        static void Main(string[] args)
        {
            Console.WriteLine("函数重载");

            CalcSum(1, 2);
            CalcSum(1.1f, 2);
            CalcSum(1, 2, 3);
            CalcSum(1, 1.2f);
        }
    }
}
