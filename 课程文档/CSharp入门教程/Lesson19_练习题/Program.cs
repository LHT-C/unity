using System;

namespace Lesson19_练习题
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("do while语句练习题");

            #region 练习题一
            //要求用户输入用户名和密码，
            //只要不是admin和8888就一直提示用户名或密码错误，请重新输入
            // 控制台输入 条件运算符 逻辑运算符
            
            //变量申明 一定要注意申明在哪个语句块中
            //string userName = "";
            //string passWord = "";
            //bool isShow = false;
            //do
            //{
            //    //这句代码 第一次 肯定不能执行
            //    if(isShow)
            //    {
            //        Console.WriteLine("用户名或密码错误，请重新输入");
            //    }
            //    //循环输入
            //    Console.WriteLine("请输入用户名");
            //    userName = Console.ReadLine();
            //    Console.WriteLine("请输入密码");
            //    passWord = Console.ReadLine();
            //    isShow = true;
            //} while (userName != "admin" || passWord != "8888");

            #endregion

            #region 练习题二
            //不断提示请输入你的姓名，直到输入q结束
            string input = "";
            do
            {
                Console.WriteLine("请输入你的姓名");
                input = Console.ReadLine();
            } while (input != "q");
            #endregion
        }
    }
}
