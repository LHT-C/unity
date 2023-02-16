using System;

namespace Lesson16_条件分支语句_if
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("条件分支语句");

            #region 知识点一 作用
            //让顺序执行的代码 产生分支
            //if语句是第一个 可以让我们的程序 产生逻辑变化的 语句
            #endregion

            #region 知识点二 if语句
            //作用： 满足条件时 多执行一些代码
            //语法：
            // if( bool类型值 )  // bool类型相关：bool变量 条件运算符表达式 逻辑运算符表达式
            // {
            //     满足条件要执行的代码 写在if代码块中;
            // }
            // 注意：
            // 1.if语句的语法部分， 不需要写分号
            // 2.if语句可以嵌套使用

            if( false )
            {
                Console.WriteLine("进入了if语句代码块，执行其中的代码逻辑");
                Console.WriteLine("进入了if语句代码块，执行其中的代码逻辑");
                Console.WriteLine("进入了if语句代码块，执行其中的代码逻辑");
            }
            Console.WriteLine("if语句外的代码");

            int a = 1;
            if( a > 0 && a < 5)
            {
                Console.WriteLine("a在0到5之间");
            }

            string name = "唐老狮";
            string passWord = "666";
            if( name == "唐老狮" && passWord == "666" )
            {
                Console.WriteLine("登录成功");
            }

            //嵌套使用
            if( name == "唐老狮" )
            {
                Console.WriteLine("用户名验证成功");
                if( passWord == "666" )
                {
                    Console.WriteLine("密码验证成功");
                    //可以无限嵌套
                }
                //可以无限嵌套
            }

            #endregion

            #region 知识点三 if...else语句
            // 作用：产生两条分支 十字路 满足条件做什么 不满足条件做什么

            //语法：
            // if( bool类型值 )
            // {
            //      满足条件执行的代码;
            // }
            // else
            // {
            //      不满足条件执行的代码：
            // }
            // 注意：
            // 1.if ...else 语句 语法部分 不需要写分号
            // 2.if ...else 语句 可以嵌套

            if( false )
            {
                Console.WriteLine("满足if条件 做什么");
                if( true )
                {
                    if (true)
                    {

                    }
                    else
                    {

                    }
                }
                else
                {
                    if (true)
                    {

                    }
                    else
                    {

                    }
                }
            }
            else
            {
                Console.WriteLine("不满足if条件 做什么");
                if (true)
                {

                }
                else
                {

                }
            }

            //其它的使用和if的使用时一样
            // 嵌套使用 也是和if语句 一样的

            #endregion

            #region 知识点四 if...else if...else 语句
            //作用：产生n条分支 多条道路选择 最先满足其中的一个条件 就做什么

            // 语法：
            // if( bool类型值 )
            // {
            //      满足条件执行的代码;
            // }
            // else if( bool类型值 )
            // {
            //      满足条件执行的代码;
            // }
            // ...中间可以有n个 else if语句代码块
            // else
            // {
            //      不满足条件执行的代码：
            // }

            // 注意：
            // 1. 和前面两个是一样的 不需要写分号
            // 2. 是可以嵌套的
            // 3. else 是可以省略的
            // 4. 注意 条件判断 从上到下执行 满足了第一个后 之后的都不会执行了

            int a3 = 6;
            if (a3 >= 10)
            {
                Console.WriteLine("a大于等于10");
            }
            else if( a3 > 5 && a3 < 10 )
            {
                Console.WriteLine("a在6和9之间");
            }
            else if( a3 >= 0 && a3 <= 5 )
            {
                Console.WriteLine("a在0和5之间");
            }
            else
            {
                Console.WriteLine("a小于0");
            }

            //if语句相关 if if..else  if...else if...else
            // else if 和 else 是组合套餐 根据实际情况选择使用




            #endregion
        }
    }
}
