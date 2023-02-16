using System;

namespace Lesson2_练习题
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("变量相关练习题");

            #region 练习题1 
            //下面代码的输出结果是？
            double num = 36.6;
            //这是打印一个字符串
            Console.WriteLine("num");
            //打印变量容器中存储的内容
            Console.WriteLine(num);

            #endregion

            #region 练习题2
            //声明float类型变量时，为何要在数字后面加f？
            float f = 1.234F;
            decimal d = 1.2344545M;

            #endregion

            #region 练习题3 
            //请定义一系列变量来存储你的名字、年龄、性别、身高、体重、家庭住址等，并打印出来。
            string name = "唐老狮";
            Console.WriteLine("我的名字是" + name);
            byte age = 18;
            Console.WriteLine("我的年龄是" + age);
            float height = 177.5f;
            Console.WriteLine("我的身高是" + height);
            float weight = 68.5f;
            Console.WriteLine("我的体重是" + weight);
            string address = "地球深处";
            Console.WriteLine("我的家庭住址是" + address);
            #endregion

            #region 练习题4
            //小明的数学考试成绩是80，语文的考试成绩是78，英语的考试成绩是98，请用变量描述并打印
            byte shuXue = 80;
            byte yuWen = 78;
            byte yingYu = 98;
            Console.WriteLine("我的数学成绩是：" + shuXue);
            Console.WriteLine("我的语文成绩是：" + yuWen);
            Console.WriteLine("我的英语成绩是：" + yingYu);

            #endregion
        }
    }
}
