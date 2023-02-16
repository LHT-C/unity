using System;

namespace Lesson8_练习题
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("类型转换——显示转换练习题");

            #region 练习题一
            //显示类型转换有几种方式？他们分别是什么，请举例说明？
            // 1.括号强转 数值之间的转换 低精度 装 高精度
            int i = 1;
            long l = 1;
            i = (int)l;

            float f = 1.1f;
            double d = 1.231231231231231231231;
            f = (float)d;
            // 2.Parse法 把字符串 转成 对应的类型 变量类型.Parse(字符串)
            i = int.Parse("123");
            // 3.Convert法
            i = Convert.ToInt32(12.23123);
            i = Convert.ToInt32("123123");

            string str = Convert.ToString(123123);
            // 4.toString法
            str = 1.ToString();
            str = 1.23123f.ToString();
            #endregion

            #region 练习题二
            //请将24069转成字符，并打印

            char c = (char)24069;
            Console.WriteLine(c);

            c = Convert.ToChar(24069);
            Console.WriteLine(c);

            #endregion

            #region 练习题三
            //提示用户输入姓名、语文、数学、英语成绩，并将输入的3门成绩用整形变量存储
            Console.WriteLine("请输入你的姓名");
            //通过字符串变量 把输入内容存起来
            string str2 = Console.ReadLine();

            Console.WriteLine("请输入你的语文成绩");
            str2 = Console.ReadLine();

            //再把字符串转为 想要的类型
            int yuWen = int.Parse(str2);
            //Console.WriteLine("你的语文成绩：" + yuWen);

            Console.WriteLine("请输入你的数学成绩");
            str2 = Console.ReadLine();
            int shuXue = int.Parse(str2);
            //Console.WriteLine("你的数学成绩：" + shuXue);

            Console.WriteLine("请输入你的英语成绩");
            str2 = Console.ReadLine();
            int yingYu = int.Parse(str2);
            //Console.WriteLine("你的英语成绩：" + yingYu);
            #endregion
        }
    }
}
