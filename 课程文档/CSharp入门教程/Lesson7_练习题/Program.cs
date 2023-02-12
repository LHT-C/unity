using System;

namespace Lesson7_练习题
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("隐式转换练习题");

            #region 练习题一
            //什么情况下会出现数据类型的隐式转换，请举例说明
            // 大范围存小范围
            // double——>float ——> 整形（无符号、有符号）——> char
            // decimal ——> 整形（无符号、有符号）——> char
            // long ——>int ——> short ——> sbyte
            // ulong ——> uint ——> ushort ——> byte
            // 无符号 没法 隐式存储 有符号的
            // 有符号的 可以 隐式存储 无符号（范围大小）

            int i = 1;
            short s = 1;
            i = s;

            #endregion

            #region 练习题二
            //请将自己名字的每一个字符转换成数字并打印出来
            //char t = '唐';
            //ASCII 码
            int tang = '唐';
            Console.WriteLine(tang);
            int lao = '老';
            Console.WriteLine(lao);
            int shi = '狮';
            Console.WriteLine(shi);
            Console.WriteLine(tang + lao + shi);
            Console.WriteLine( "唐老狮对应的数字编号：" +  tang + lao + shi);

            #endregion
        }
    }
}
