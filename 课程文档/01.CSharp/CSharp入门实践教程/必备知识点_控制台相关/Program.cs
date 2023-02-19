using System;

namespace 必备知识点_控制台相关
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("控制台相关");
            #region 知识点一 复习 输入输出
            //输出
            //Console.WriteLine("123123");//光标空行
            //Console.Write("123123123123");//不空行
            //输入
            //string str = Console.ReadLine();
            //如果在ReadKey(true)不会把输入的内容显示在控制台上
            //char c = Console.ReadKey(true).KeyChar;
            //Console.WriteLine(c);
            #endregion

            #region 知识点二 控制台其它方法
            //1.清空
            Console.Clear();

            //2.设置控制台大小
            // 窗口大小 缓冲区大小
            // 注意：
            //1.先设置窗口大小，再设置缓冲区大小
            //2.缓冲区的大小不能小于窗口的大小
            //3.窗口的大小不能大于控制台的最大尺寸
            //窗口大小
            Console.SetWindowSize(100, 50);
            //缓冲区大小 （可打印内容区域的宽高 ）
            Console.SetBufferSize(1000, 1000);

            //3.设置光标的位置
            //控制台左上角为原点0 0 右侧是X轴正方向 下方是Y轴正方向 它是一个平面二维坐标系
            //注意：
            //1.边界问题
            //2.横纵距离单位不同 1y = 2x 视觉上的
            Console.SetCursorPosition(10, 5);
            Console.WriteLine("123123");

            //4.设置颜色相关
            //文字颜色设置
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("123123123");
            Console.ForegroundColor = ConsoleColor.Green;
            //背景颜色设置
            //Console.BackgroundColor = ConsoleColor.White;
            //重置背景颜色过后 需要Clear一次 才能把整个背景颜色改变
            //Console.Clear();

            //5.光标显隐
            Console.CursorVisible = false;

            //6.关闭控制台
            Environment.Exit(0);
            #endregion
        }
    }
}
