using System;

namespace 必备知识点_控制台相关练习题
{
    class Program
    {
        //1.如何打断点 F9
        //2.如何一步一步的看代码逻辑 F10
        //3.继续执行 停止一步一步的看 F5

        //4.可以通过监视窗口查看想要得到的变量值

        static void Main(string[] args)
        {
            Console.WriteLine("控制台相关练习题");

            //改背景颜色
            Console.BackgroundColor = ConsoleColor.Red;
            Console.Clear();
            //改变字体颜色
            Console.ForegroundColor = ConsoleColor.Yellow;
            //隐藏光标
            Console.CursorVisible = false;

            //黄色方块感觉像人一样 这个人身上有位置信息
            // x y
            int x = 0;
            int y = 0;

            //不停的输入 wasd键 都可以控制它移动
            //根据不停 就分析 用while循环是最简单的一种方式
            while (true)
            {
                //第一种清空之前信息的方式
                //Console.Clear();
                Console.SetCursorPosition(x, y);
                Console.Write("■");
                //得到玩家的输入信息
                char c = Console.ReadKey(true).KeyChar;
                //第二种方式把之前的方块擦除了
                Console.SetCursorPosition(x, y);
                Console.Write("  ");
                switch (c)
                {
                    //贯穿
                    case 'W':
                    case 'w':
                        y -= 1;
                        //改变位置过后 判断新位置 是否越界
                        if( y < 0 )
                        {
                            y = 0;
                        }
                        break;
                    case 'A':
                    case 'a':
                        //中文符号 在控制台上占2个位置
                        x -= 2;
                        if( x < 0 )
                        {
                            x = 0;
                        }
                        break;
                    case 'S':
                    case 's':
                        y += 1;
                        if( y > Console.BufferHeight - 1 )
                        {
                            y = Console.BufferHeight - 1;
                        }
                        break;
                    case 'D':
                    case 'd':
                        x += 2;
                        if( x > Console.BufferWidth - 2 )
                        {
                            x = Console.BufferWidth - 2;
                        }
                        break;
                }
            }
        }
    }
}
