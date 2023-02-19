using System;
using System.Runtime.CompilerServices;

namespace Lesson16_练习题
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("if语句");

            #region 练习题一
            //请用户输入今日看唐老狮视频花了多少分钟，如果大于60分钟，
            //那么在控制台输出“今天看视频花了XX分钟，看来你离成功又进了一步!”
            // 控制台输入  类型转换  异常捕获  条件运算符  if语句
            //Console.WriteLine("请输入今日看唐老狮视频花了多少时间(分钟)");
            //try
            //{
            //    string input = Console.ReadLine();
            //    int min = int.Parse(input);
            //    if( min > 60 )
            //    {
            //        Console.WriteLine("今天看视频花了{0}分钟，看来你离成功又近了一步", min);
            //    }
            //    else
            //    {
            //        Console.WriteLine("你还需要努力啊！");
            //    }
            //}
            //catch
            //{
            //    Console.WriteLine("请输入正确格式的时间");
            //}

            #endregion

            #region 练习题二
            //请输入你的 语文，数学，英语成绩，满足以下任意条件，则输出“非常棒，继续加油”
            //语文成绩大于70 并且 数学成绩大于80 并且英语成绩大于90
            //语文成绩等于100或者数学成绩等于100或者英语成绩等于100
            //语文成绩大于90 并且 其它两门中有一门成绩大于70
            // 控制台输入 类型转换 异常捕获  条件运算符 逻辑运算符  if语句
            //try
            //{
            //    Console.WriteLine("请输入语文成绩");
            //    int yuWen = int.Parse(Console.ReadLine());
            //    Console.WriteLine("请输入数学成绩");
            //    int shuXue = int.Parse(Console.ReadLine());
            //    Console.WriteLine("请输入英语成绩");
            //    int yingYu = int.Parse(Console.ReadLine());

            //    bool c1 = yuWen > 70 && shuXue > 80 && yingYu > 90;
            //    bool c2 = yuWen == 100 || shuXue == 100 || yingYu == 100;
            //    bool c3 = yuWen > 90 && (shuXue > 70 || yingYu > 70);

            //    if( c1 || c2 || c3 )
            //    {
            //        Console.WriteLine("非常棒，继续加油");
            //    }
            //}
            //catch
            //{
            //    Console.WriteLine("成绩请输入数字");
            //}

            #endregion

            #region 练习题三
            //定义一个变量，存储小赵的考试成绩，如果小赵的考试成绩大于（含）90分，
            //那么爸爸奖励100元钱，否则一个月不能玩游戏
            // if else语句 条件运算符
            //int cj = 90;
            //if( cj >= 90 )
            //{
            //    Console.WriteLine("奖励100元");
            //}   
            //else
            //{
            //    Console.WriteLine("一个月不能玩游戏");
            //}

            #endregion

            #region 练习题四
            //要求用户输入两个数a、b，如果两个数可以整除或者这两个数加起来大于100，
            //则输出a的值，否则输出b的值
            // 控制台输入 类型转换  异常捕获  算数运算符  条件运算符  逻辑运算符
            // if else 语句

            //try
            //{
            //    Console.WriteLine("请输入一个数");
            //    int a = int.Parse(Console.ReadLine());
            //    Console.WriteLine("请再输入一个数");
            //    int b = int.Parse(Console.ReadLine());

            //    bool c1 = a % b == 0 || b % a == 0;
            //    bool c2 = a + b > 100;

            //    if (c1 || c2)
            //    {
            //        Console.WriteLine(a);
            //    }
            //    else
            //    {
            //        Console.WriteLine(b);
            //    }

            //}
            //catch
            //{
            //    Console.WriteLine("请输入数字");
            //}

            #endregion

            #region 练习题五
            //输入一个整数，如果这个数是偶数，则打印“Your input is even”，否则打印“Your input is odd”
            // 控制台输入 类型转换 异常捕获  条件运算符  if语句  算术运算符
            //try
            //{
            //    Console.WriteLine("请输入一个整数");
            //    int num = int.Parse(Console.ReadLine());
            //    //能被2整除的数 叫偶数
            //    if( num % 2 == 0 )
            //    {
            //        Console.WriteLine("Your input is even");
            //    }
            //    else
            //    {
            //        Console.WriteLine("Your input is odd");
            //    }
            //}
            //catch
            //{
            //    Console.WriteLine("请输入数字");
            //}

            #endregion

            #region 练习题六
            //有3个整形变量，分别存储不同的值，编写代码输出其中最大的整数
            // 条件运算符 逻辑运算符 if else if else 语句
            //int a = 98;
            //int b = 5;
            //int c = 11;
            //if( a > b && a > c )
            //{
            //    Console.WriteLine(a);
            //}
            //else if( b > a && b > c )
            //{
            //    Console.WriteLine(b);
            //}
            //else
            //{
            //    Console.WriteLine(c);
            //}
            #endregion

            #region 练习题七
            //写一个程序接受用户输入的字符，如果输入的字符是0~9数字中的一个，
            //则显示“您输入了一个数字”，否则显示这不是一个数字
            // 控制台输入 类型转换 异常捕获 条件运算符 逻辑运算符 if语句

            //Console.WriteLine("请输入一个字符");
            //// char类型可以隐式转换为 数值类型 
            //int askii = Console.ReadKey().KeyChar;
            ////int zeroAsk = '0';
            ////Console.WriteLine(zeroAsk);
            ////int nineAsk = '9';
            ////Console.WriteLine(nineAsk);
            //if( askii >= '0' && askii <= '9')
            //{
            //    Console.WriteLine("您输入了一个数字");
            //}
            //else
            //{
            //    Console.WriteLine("这不是一个数字");
            //}

            //try
            //{
            //    Console.WriteLine("请输入一个字符");
            //    // 通过 ReadKey().KeyChar得到的输入的字符
            //    char c = Console.ReadKey().KeyChar;
            //    int num = int.Parse(c.ToString());
            //    //通过Convert把char转成整形 转过去的是对应的ASKII码的数值
            //    //int num = Convert.ToInt32(c);
            //    Console.WriteLine(num);
            //    if( num >= 0 && num <= 9 )
            //    {
            //        Console.WriteLine("您输入了一个数字");
            //    }
            //    //else
            //    //{
            //    //    Console.WriteLine("这不是一个数字");
            //    //}
            //}
            //catch
            //{
            //    Console.WriteLine("这不是一个数字");
            //}

            #endregion

            #region 练习题八
            //提示用户输入用户名，然后再提示输入密码，如果用户名是“admin”，
            //并且密码是"8888"，则提示正确，否则，
            //如果用户名不是admin还提示用户用户名不存在，如果用户名是admin则提示密码错误
            // if嵌套使用 
            //Console.WriteLine("请输入用户名");
            //string name = Console.ReadLine();
            //Console.WriteLine("请输入密码");
            //string passWord = Console.ReadLine();
            //if( name == "admin" && passWord == "8888" )
            //{
            //    Console.WriteLine("登录成功");
            //}
            //else
            //{
            //    if( name != "admin" )
            //    {
            //        Console.WriteLine("用户名不存在");
            //    }
            //    else
            //    {
            //        Console.WriteLine("密码错误");
            //    }
            //}

            #endregion

            #region 练习题九
            //提示用户输入年龄，如果大于等于18，则告知用户可以查看，
            //如果小于13岁，则告知不允许查看，如果大于等于13并且小于18，
            //则提示用户是否继续查看（yes、no），
            //如果输入的是yes则提示用户请查看，否则提示“退出”。
            // if else if else  嵌套使用 
            try
            {
                //输入年龄 
                Console.WriteLine("请输入你的年龄");
                int age = int.Parse(Console.ReadLine());
                //大于等于18 做什么
                if( age >= 18 )
                {
                    Console.WriteLine("你可以查看");
                }
                //13 18之间 
                // 判断玩家输入 根据输入内容 决定显示什么
                else if( age < 18 && age >= 13 )
                {
                    Console.WriteLine("是否继续查看(yes/no)");
                    string str = Console.ReadLine();
                    if( str == "yes" )
                    {
                        Console.WriteLine("请查看");
                    }
                    else if( str == "no" )
                    {
                        Console.WriteLine("退出");
                    }
                    else
                    {
                        Console.WriteLine("输入内容不正确，退出");
                    }
                }
                //小于13 做什么
                else
                {
                    Console.WriteLine("不允许查看");
                }
            }
            catch
            {
                Console.WriteLine("请输入正确内容");
            }


            #endregion

            #region 练习题十
            //请说明以下代码的打印结果（不要打一遍代码，请直接通过阅读说出结果）

            // 语句块 会影响 变量的 生命周期

            //函数语句块 目前我们学习知识时  是层级最高的语句块

            //int a = 1;
            ////int b = 2;
            //{
            //    int b = 3;
            //    Console.WriteLine(a);
            //    Console.WriteLine(b);
            //}
            //Console.WriteLine(b);

            //int a = 5;
            //if (a > 3)
            //{
            //    int b = 0;
            //    ++b;
            //    b += a;
            //}
            //Console.WriteLine(b);
            #endregion
        }
    }
}
