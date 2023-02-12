using System;

namespace Lesson6_练习题
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("转义字符练习题");

            #region 练习题一
            //请写出至少5种转义字符
            //  \'   \"   \n   \\
            //  \t   \b   \0   \a
            #endregion

            #region 练习题二
            //请用至少两种方式在控制台打印出：
            //我是小明
            //我今年18
            //我的爱好是制作游戏
            //我要好好学习，天天向上

            Console.WriteLine("我是小明\n我今年18\n我的爱好是制作游戏\n我要好好学习，天天向上");
            Console.WriteLine("***********************");
            Console.WriteLine("我是小明");
            Console.WriteLine("我今年18");
            Console.WriteLine("我的爱好是制作游戏");
            Console.WriteLine("我要好好学习，天天向上");
            Console.WriteLine("***********************");
            Console.Write("我是小明");
            Console.WriteLine();
            Console.Write("我今年18");
            Console.WriteLine();
            Console.Write("我的爱好是制作游戏");
            Console.WriteLine();
            Console.Write("我要好好学习，天天向上");
            #endregion
        }
    }
}
