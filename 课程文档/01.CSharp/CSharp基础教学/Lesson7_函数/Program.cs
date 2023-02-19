using System;

namespace Lesson7_函数
{
    class Program
    {
        #region 知识点一 基本概念
        //函数（方法）
        //本质是一块具有名称的代码块
        //可以使用函数（方法）的名称来执行该代码块
        //函数（方法）是封装代码进行重复使用的一种机制

        //函数（方法）的主要作用
        //1.封装代码
        //2.提升代码复用率（少写点代码）
        //3.抽象行为
        #endregion

        #region 知识点二 函数写在哪里
        //1.class语句块中
        //2.struct语句块中
        #endregion

        #region 知识点三 基本语法
        //    1      2      3                4
        // static 返回类型 函数名(参数类型 参数名1, 参数类型 参数名2, .......)
        //{
        //      函数的代码逻辑;
        //      函数的代码逻辑;
        //      函数的代码逻辑;
        //      .............
        //       5
        //      return 返回值;(如果有返回类型才返回)
        //}

        //1. 关于static 不是必须的 在没有学习类和结构体之前 都是必须写的

        //2-1. 关于返回类型 引出一个新的关键字  void(表示没有返回值)
        //2-2. 返回类型 可以写任意的变量类型  14种变量类型 + 复杂数据类型（数组、枚举、结构体、类class）

        //3. 关于函数名 使用帕斯卡命名法命名  myName（驼峰命名法）  MyName(帕斯卡命名法)

        //4-1. 参数不是必须的，可以有0~n个参数  参数的类型也是可以是任意类型的 14种变量类型 + 复杂数据类型（数组、枚举、结构体、类class）
        //     多个参数的时候 需要用 逗号隔开
        //4-2. 参数名 驼峰命名法

        //5. 当返回值类型不为void时 必须通过新的关键词 return返回对应类型的内容  （注意：即使是void也可以选择性使用return）
        #endregion

        #region 知识点四 实际运用
        //1.无参无返回值函数
        //1     2      3      4
        static void SayHellow()
        {
            Console.WriteLine("你好世界");
            // 5 在没有返回值时 也就是返回值类型是void 可以省略
            //return;
        }

        //2.有参无返回值函数
        // 1    2       3         4
        static void SayYourName(string name)
        {
            Console.WriteLine("你的名字是：{0}", name);
            // 5
            // return;省略了
        }

        //3.无参有返回值函数
        //1      2        3        4
        static string WhatYourName()
        {
            // 5 对应返回值类型的 内容 返回出去
            return "唐老狮";
        }

        //4.有参有返回值函数
        // 1    2   3      4
        static int Sum(int a, int b)
        {
            //int c = a + b;
            //return c;
            // 5 retrun后面可以写一个表达式 只要这个表达式的结果和返回值类型是一致的就行
            return a + b;
        }

        //5.有参有多返回值函数

        // 传入两个数 然后计算两个数的和 以及他们两的平均数 得出结果返回出来
        // 函数的返回值 一定是一个类型 只能是一个内容
        //1     2     3       4
        static int[] Calc(int a, int b)
        {
            int sum = a + b;
            int avg = sum / 2;
            //int[] arr = { sum, avg };
            //return arr;
            // 5  
            // 如果用数组作为返回值出去 那么前提是 使用者 知道这个数组的规则
            return new int[] { sum, avg};
        }

        #endregion

        #region 知识点五 关于return
        //即使函数没有返回值，我们也可以使用return，
        //return可以直接不执行之后的代码，直接返回到函数外部

        static void Speak(string str)
        {
            if( str == "混蛋" )
            {
                return;
            }
            Console.WriteLine(str);
        }

        #endregion


        //总结
        //1.基本概念
        //2.函数写在哪里 —— class 或者 struct中
        //3.基本语法  1  2  3  4  5
        //4. return 可以提前结束函数逻辑   程序是线性执行的  从上到下执行

        static void Main(string[] args)
        {
            Console.WriteLine("函数");
            //使用函数 直接 写函数名（参数） 即可
            SayHellow();
            // 参数可以是 常量 变量 函数都可以
            // 参数 一定是传一个 能得到对应类型的表达式
            string str = "唐老狮";
            //传入一个string变量
            SayYourName(str);
            //传入一个string 常量
            SayYourName("唐老师2");
            //传入一个返回值时string的函数 
            SayYourName(WhatYourName());

            //有返回值的函数  要不直接拿返回值来用
            //要不就是拿变量 接收它的结果
            string str2 = WhatYourName();

            //也可以直接调用 但是 返回值 对我们来说就没用了
            WhatYourName();

            Console.WriteLine(Sum(100, 200));


            int[] arr = Calc(5, 7);
            Console.WriteLine(arr[0] + " " + arr[1]);

            Speak("混蛋123");
        }
    }
}
