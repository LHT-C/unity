using System;
using System.Security.Cryptography;

namespace Lesson11_练习题
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("字符串拼接 练习题");

            #region 练习题一
            //定义一个变量存储客户的姓名，然后再屏幕上显示：“你好，XXX”
            //XXX代表客户的姓名

            string name = "唐老狮";
            Console.WriteLine("你好," + name);
            Console.WriteLine("你好,{0}", name);
            string str = string.Format("你好,{0}", name);
            Console.WriteLine(str);
            #endregion

            #region 练习题二
            //定义两个变量，一个存储客户的姓名，另一个存储年龄，
            //然后再屏幕上显示：“xxx + yyy岁了”。xxx代表客户的姓名，yyy代表年龄
            //举例（唐老狮18岁了）
            string name2 = "唐老狮";
            int age = 99;

            Console.WriteLine(name2 + age + "岁了");

            str = string.Format("{0}{1}岁了", name2, age);
            Console.WriteLine(str);

            Console.WriteLine("{0}{1}岁了", name2, age);

            #endregion

            #region 练习题三
            //当我们去面试时，前台会要求我们填一张表格，
            //有姓名，年龄，邮箱，家庭住址，期望工资，
            //请把这些信息在控制台输出。

            string name3 = "唐老狮";
            int age2 = 190;
            string email = "tpandme@163.com";
            string address = "地球深处";
            long money = 999999999999999;

            Console.WriteLine("姓名:{0}\n年龄：{1}\n邮箱：{2}\n家庭住址：{3}\n期望薪资：{4}\n", name3,
                age2, email, address, money);

            #endregion

            #region 练习题四
            //请用户输入用户名、年龄、班级，最后一起用占位符形式打印出来
            Console.WriteLine("请输入你的用户名");
            string adminName = Console.ReadLine();
            Console.WriteLine("请输入你的年龄");
            string ageStr = Console.ReadLine();
            Console.WriteLine("请输入你的班级");
            string classStr = Console.ReadLine();

            Console.WriteLine("{0},{1},{2}", adminName, ageStr, classStr);
            #endregion  
        }
    }
}
