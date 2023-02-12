//第一种注释 两杠注释
//第二种注释 星号注释
//第三种注释 三杠注释

//引用命名空间（工具包）
using System;

/// <summary>
/// 命名空间  —— 工具包
/// </summary>
namespace Lesson1_第一个应用程序
{
    //命名空间 代码块
    //面向对象相关知识点内容 会在这里来写代码

    /// <summary>
    /// 类 —— 工具
    /// </summary>
    class Program
    {
        //类 代码块
        //面向对象相关知识点内容 会在这里来写代码

        /// <summary>
        /// 函数 —— 工具能做的事情
        /// 主函数 一个程序的主入口
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {
            //函数代码块 我们目前学习基础知识时
            //所有的代码 都会写在 该 代码块中

            //在控制台 打印出 你好世界这个内容
            //在控制台 打印一行信息 打印信息结束后 自动空一行
            Console.WriteLine("你好世界!");

            Console.WriteLine("唐老狮");
            //如果是双引号之间的内容 对于符号没有特别要求
            //在控制台打印信息  但是打印完成后 不会自动空行
            Console.Write("你好，我喜欢你");
            Console.Write("我要好好学习，天天向上");
            
            Console.WriteLine("请玩家输入");

            //检测玩家输入的代码
            //等待玩家输入完毕后（按回车键）才会继续执行后面的代码
            //玩家可以输入 很多信息  知道回车结束
            Console.ReadLine();

            Console.WriteLine("玩家输入完毕");

            //检测玩家是否按键 只要按了键盘上的任意键 就会认为输入结束
            Console.ReadKey();


            Console.WriteLine("玩家输入完毕");

            //输入 向控制台输入内容
            //Console.ReadLine();
            //Console.ReadKey();

            //输出 在控制台打印信息
            //Console.WriteLine("123123");
            //Console.Write("123123123");
        }
    }
}
