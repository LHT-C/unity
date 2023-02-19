//引用命名空间
using System;

//命名空间
namespace Lesson2_变量
{
    //类
    class Program
    {
        //主函数 程序主入口
        static void Main(string[] args)
        {
            //函数语句块 目前学习的内容 都写在这里
            Console.WriteLine("变量");

            //知识点一 折叠代码
            //主要作用 是让我们编程时 逻辑更加清晰
            //它是有 #region #endregion配对出现的
            //它的具体作用 是可以将中间包裹的代码折叠起来 避免代码太凌乱
            //本质是 编辑器提供给我们的 预处理指令 
            //它只会在编辑时有用 发布了代码 或执行代码 它会被自动删除
            #region 知识点二 如何申明变量
            //变量  可以变化的容器   变量 就是用来存储各种不同类型数值的 一个容器
            //不同的 变量类型 可以存储不同类型的值

            //变量申明固定写法
            // 变量类型 变量名 = 初始值;
            //int i = 1;
            // 变量类型 有14种变化
            // 变量名  我们自定义 要按照一定规则
            // 初始值  一定要和变量类型是统一 
            // = 和 ; 是固定的 不变的

            //变量类型 
            // 一定要死记硬背 各种变量类型的关键字 
            // 一定要记忆 各种不同变量类型 所能存储的范围
            // 一定要记住 各种不同变量类型 所能存储的类型

            //1.有符号的整形变量 是能存储 一定范围 正负数包括0的变量类型
            // sbyte -128~127
            sbyte sb = 1;
            //潜在知识点 通过+来进行拼接打印
            Console.WriteLine("sbyte变量sb中存储的值是：" + sb);
            // int  -21亿~21亿多
            int i = 2;
            // short -32768~32767之间的数
            short s = 3;
            // long -9百万兆~9百万兆之间的数
            long l = 4;

            //2.无符号的整形变量 是能存储 一定范围 0和正数的变量类型
            // byte 0~255
            byte b = 1;
            // uint 0~42亿多的一个范围
            uint ui = 2;
            // ushort 0~65535之间的一个数
            ushort us = 3;
            // ulong 0~18百万兆之间的数
            ulong ul = 4;


            //3.浮点数(小数)
            //float 存储7/8位有效数字 根据编译器不同 有效数字也可能不一样 四舍五入
            //有效数字 是从左到右从非0数开始算有效数字的
            //之所以要在后面加f 是因为c#中 申明的小数 默认是double的类型 加f 是告诉系统 它是float类型
            float f = 1.01234567890f;
            Console.WriteLine(f);
            //double 存储15~17位有效数字 抛弃的数字 会四舍五入
            double d = 0.12345678901234567890123456789;
            Console.WriteLine(d);
            //decimal 存储27~28位的有效数字 不建议使用
            decimal de = 0.123456789012345678901234567890m;
            Console.WriteLine(de);

            //4.特殊类型
            //bool true false 表示真假的数据类型  真假类型
            bool bo = true;
            bool bo2 = false;
            Console.WriteLine(bo + "_" + bo2);

            //char 是用来存储单个字符的变量类型 字符类型
            char c = '唐';
            Console.WriteLine(c);

            //string 是字符串类型 用来存储多个字符的 没有上限
            string str = "的骄傲了肯定就发生123123sdafjkasdkfjaskldjfAKKSAJD";
            Console.WriteLine(str);


            int x = 1000;
            Console.WriteLine(x);
            //变量的使用和修改 不能不中生有 必须要先声明才能用
            x = 900;
            Console.WriteLine(x);

            #endregion


            #region 知识点三 为什么有那么多不同的变量类型
            // 不同的变量 存储的范围和类型不一样 本质是占用的内存空间不同
            // 选择不同的数据（变量）类型装在不同的数据

            //姓名
            //char string 
            string myName = "唐老狮";
            //年龄
            byte age = 18;
            //身高cm
            float height = 177.5f;
            //体重kg
            float weight = 68.5f;
            //性别 true女 false男
            bool sex = false;

            //数字用int  小数用float  字符串用string  真假用bool
            #endregion

            #region 知识点四 多个相同类型变量 同时申明
            int i2 = 1;
            float f2 = 3.2f;
            string str2 = "123";
            bool bo3 = true;
            //多个同类型变量申明 
            //固定写法
            // 变量类型 变量名 = 初始值,变量名 = 初始值,变量名 = 初始值...; 
            int a1 = 1, b1 = 2, c1 = 3, d1 = 4;
            Console.WriteLine(b1);
            string s1 = "123", s2 = "234";
            Console.WriteLine(s1 + s2);
            #endregion

            #region 知识点五 变量初始化相关
            //变量申明时 可以不设置初始值 但是不建议这样写 这样不安全
            int a2;
            a2 = 1;
            Console.WriteLine(a2);
            #endregion
        }
    }
}
