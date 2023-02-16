using System;

namespace Lesson5_常量
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("常量");

            #region 知识点一 常量的申明
            //关键字 const
            //固定写法：
            //const 变量类型 变量名 = 初始值;
            //变量的申明
            int i = 10;
            //常量的申明
            const int i2 = 20;

            #endregion

            #region 知识点二 常量的特点
            //1.必须初始化
            //2.不能被修改

            //变量申明可以不初始化
            string name;
            //之后可以来修改
            name = "123";
            name = "345";

            const string myName = "唐老狮";

            //作用：申明一些常用不变的变量

            //PI 3.1415926
            const float PI = 3.1415926f;

            Console.WriteLine(PI);

            #endregion
        }
    }
}
