using System;

namespace Lesson7_类型转换_隐式转换_
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("类型转换——隐式转换");
            // 什么是类型转换

            // 类型转换 就是不同变量类型之间的相互转换

            // 隐式转换的基本规则——>不同类型之间自动转换
            // 大范围装小范围

            #region 知识点一 相同大类型之间的转换

            //有符号  long——>int——>short——>sbyte
            long l = 1;
            int i = 1;
            short s = 1;
            sbyte sb = 1;
            //隐式转换 int隐式转换成了long
            //可以用大范围 装小范围的 类型 （隐式转换）
            l = i;
            //不能够用小范围的类型去装在大范围的类型
            //i = l;
            l = i;
            l = s;
            l = sb;
            i = s;
            s = sb;

            //无符号 ulong——>uint——>ushort——>byte
            ulong ul = 1;
            uint ui = 1;
            ushort us = 1;
            byte b = 1;

            ul = ui;
            ul = us;
            ul = b;
            ui = us;
            ui = b;
            us = b;

            //浮点数  decimal    double——>float
            decimal de = 1.1m;
            double d = 1.1;
            float f = 1.1f;
            //decimal这个类型 没有办法用隐式转换的形式 去存储 double和float
            //de = d;
            //de = f;
            //float 是可以隐式转换成 double
            d = f;

            //特殊类型  bool char string
            // 他们之间 不存在隐式转换
            bool bo = true;
            char c = 'A';
            string str = "123123";

            #endregion

            #region 知识点二 不同大类型之间的转换

            #region 无符号和有符号之间
            //无符号 不能装负数的
            byte b2 = 1; //0~255
            ushort us2 = 1;
            uint ui2 = 1;
            ulong ul2 = 1;
            //有符号
            sbyte sb2 = 1;
            short s2 = 1;
            int i2 = 1;
            long l2 = 1;

            //无符号装有符号 
            // 有符号的变量 是不能够 隐式转换成 无符号的
            //b2 = sb2;
            //us2 = sb2;
            //ul2 = sb2;

            //有符号装无符号 
            // 有符号变量 是可以 装 无符号变量的 前提是 范围一定要是涵盖的 存在隐式转换
            //i2 = ui2;//因为 有符号的变量 可能会超过 这个无符号变量的范围
            i2 = b2;// 因为 有符号的变量 不管是多少 都在 无符号变量的范围内

            #endregion

            #region 浮点数和整数（有、无符号）之间
            //浮点数装整数 整形转为浮点数 是存在隐式转换的
            float f2 = 1.1f;
            double d2 = 1.1;
            decimal de2 = 1.1m;

            //浮点数 是可以装载任何类型的 整数的
            f2 = l2;
            f2 = i2;
            f2 = s2;
            f2 = sb2;

            f2 = ul2;
            f2 = ui2;
            f2 = us2;
            f2 = b2;

            f2 = 10000000000000000000;
            Console.WriteLine(f2);

            //decimal 不能隐式存储 float和double
            //但是它可以隐式的存储整形
            de = l2;
            de = ul2;

            // double ——> float ——> 所有整形（无符号、有符号）
            // decimal ——> 所有整形（无符号、有符号）

            //整数装浮点数 整数是不能隐式存储 浮点数  因为 整数 不能存小数
            //i2 = f2;

            #endregion

            #region 特殊类型和其它类型之间

            //bool bool没有办法和其它类型 相互隐式转换
            bool bo2 = true;
            char c2 = 'A';
            string str2 = "1231";
            //bo2 = i2;
            //bo2 = ui2;
            //bo2 = f2;

            //i2 = bo2;
            //ui2 = bo2;
            //f2 = bo2;

            //bo2 = c2;
            //c2 = bo2;
            //bo2 = str2;
            //str2 = bo2;

            //char char 没有办法隐式的存储 其它类型的变量
            //c2 = i2;
            //c2 = f2;
            //c2 = ui2;
            //c2 = str2;

            //char类型 可以隐式的转换成 整形和浮点型
            //char隐式转换成 数值类型是 
            //对应的数字 其实是一个 ASCII码 
            // 计算机里面存储 2进制
            // 字符 中文 英文 标点符号 在计算机中都是一个数字
            // 一个字符 对应一个数字 ASCII码就是一种对应关系
            i2 = c2;
            Console.WriteLine(i2);
            f2 = c2;
            Console.WriteLine(f2);
            ui2 = c2;
            Console.WriteLine(ui2);

            //str2 = c2;

            //string 类型 无法和其它类型进行隐式转换
            //i2 = str2;
            //ui2 = str2;
            //f2 = str2;

            #endregion

            #endregion


            // 总结 隐式转换 规则
            // 高精度（大范围）装低精度（小范围）
            // double ——> float ——> 整数（无符号、有符号）——>char
            // decimal ——> 整数（无符号、有符号）——>char
            // string 和 bool 不参与隐式转换规则的
        }
    }
}
