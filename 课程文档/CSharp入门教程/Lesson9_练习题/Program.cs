using System;

namespace Lesson9_练习题
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("异常捕获练习题");

            #region 练习题一
            //请用户输入一个数字
            //如果输入有误，则提示用户输入错误
            try
            {
                string str = Console.ReadLine();
                long l = long.Parse(str);
                Console.WriteLine("你输入的数字为：" + l);
            }
            catch
            {
                Console.WriteLine("您的输入有误");
            }
            #endregion

            #region 练习题二
            //提示用户输入姓名、语文、数学、英语成绩
            //如果输入的成绩有误，则提示用户输入错误
            //否则将输入的字符串转为整形变量存储

            //try
            //{
            //    Console.WriteLine("请输入用户名");
            //    string yourName = Console.ReadLine();
            //    Console.WriteLine("请输入语文成绩");
            //    string yuWenStr = Console.ReadLine();
            //    int yuWen = int.Parse(yuWenStr);
            //    Console.WriteLine("请输入数学成绩");
                
            //    //一步到位的写法
            //    int shuXue = int.Parse(Console.ReadLine());
                
            //    Console.WriteLine("请输入英语成绩");
            //    int yingYu = int.Parse(Console.ReadLine());
            //}
            //catch
            //{
            //    Console.WriteLine("你的输入不合法，成绩请输入数字");
            //}


            try
            {
                Console.WriteLine("请输入用户名");
                string yourName = Console.ReadLine();
                Console.WriteLine("请输入语文成绩");
                string yuWenStr = Console.ReadLine();
                int yuWen = int.Parse(yuWenStr);
            }
            catch
            {
                Console.WriteLine("语文成绩输入格式不正确");
            }

            try
            {
                Console.WriteLine("请输入数学成绩");
                //一步到位的写法
                int shuXue = int.Parse(Console.ReadLine());
            }
            catch
            {
                Console.WriteLine("数学成绩输入格式不正确");
            }


            try
            {
                Console.WriteLine("请输入英语成绩");
                int yingYu = int.Parse(Console.ReadLine());
            }
            catch
            {
                Console.WriteLine("英语成绩输入格式不正确");
            }


            #endregion
        }
    }
}
