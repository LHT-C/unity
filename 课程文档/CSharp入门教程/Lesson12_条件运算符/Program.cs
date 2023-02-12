using System;

namespace Lesson12_条件运算符
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("条件运算符");

            #region 知识点一 条件运算符
            // 用于比较两个变量或常量
            // 是否大于 >
            // 是否小于 <
            // 是否等于 == 
            // 是否不等于 !=
            // 是否大于等于 >=
            // 是否小于等于 <=

            // 条件运算符 一定存在左右两边的内容
            // 左边内容 条件运算符 右边内容
            int a = 5;
            int b = 10;
            //条件运算符 不能直接这样使用
            //纯比较不用结果 那么对于我们来说 没有任何的意义
            //a > b;
            // 比较的结果 返回的是 一个 bool 类型的值
            // true和false 如果比较的条件满足 那就返回true 不满足 就返回false
            // 先算右边 再赋值给左边
            bool result = a > b;
            Console.WriteLine(result);

            result = a < b;
            Console.WriteLine(result);

            result = a >= b;
            Console.WriteLine(result);

            result = a <= b;
            Console.WriteLine(result);

            result = a == b;
            Console.WriteLine(result);

            result = a != b;
            Console.WriteLine(result);
            #endregion

            #region 知识点二 各种应用写法

            //变量和变量比较
            a = 5;
            b = 10;
            result = a < b;// true
            //变量和数值(常量)比较
            result = a < 10;// true
            result = b > 5;// true
            //数值和数值比较
            result = 5 > 3;//true
            result = 5 == 3; // false
            result = 5 != 3; // true;
            //计算结果比较
            //条件运算符的 优先级 低于算数运算符
            // 8 > 6
            // 先计算 再比较
            result = a + 3 > a - 2 + 3;// true
            result = 3 + 3 < 5 - 1;//false

            //左边 条件运算符 右边
            #endregion

            #region 知识点三 不能进行范围比较

            a = 5;
            //判断是否在某两个值之间
            // 1 < a < 6
            //在C#都不能这样写
            //result = 1 < a < 6;
            //要判断 一个变量是否在两个数之间 要结合 逻辑运算符的知识点
            #endregion

            #region 知识点四 不同类型之间的比较

            //不同数值类型之间 可以随意进行条件运算符比较
            int i = 5;
            float f = 1.2f;
            double d = 12.4;
            short s = 2;
            byte by = 20;
            uint ui = 222;

            //只要是数值 就能够进行条件运算符比较  比较大于小于等于等等
            result = i > f;
            result = f < d;
            result = i > by;
            result = f > ui;
            result = ui > d;

            //特殊类型 char string bool 只能同类型进行 == 和 != 比较
            string str = "123";
            char c = 'A';
            bool bo = true;

            result = str == "234";//false
            result = str == "123";//true
            result = str != "123";//false

            result = c == 'B';//false

            //不仅可以和自己类型进行 == != 还可以和数值类型进行比较
            //还可以和 字符类型进行大小比较
            result = c > 123;
            result = c > 'B';

            result = bo == true;//true;

            #endregion
        }
    }
}
