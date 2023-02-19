using System;

namespace Lesson13_逻辑运算符
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("逻辑运算符");
            //对bool类型 进行逻辑运算

            #region 知识点一 逻辑与
            //符号 &&  并且
            //规则 对两个bool值进行逻辑运算 有假则假 同真为真

            bool result = true && false;
            Console.WriteLine(result);
            result = true && true;
            Console.WriteLine(result);
            result = false && true;
            Console.WriteLine(result);

            //bool相关的类型 bool变量  条件运算符 
            //逻辑运算符优先级 低于 条件运算符 算术运算
            // true && true
            result = 3 > 1 && 1 < 2;
            Console.WriteLine(result);

            int i = 3;
            // 1 < i < 5;
            // true && true
            result = i > 1 && i < 5;
            Console.WriteLine(result);

            //多个逻辑与 组合运用
            int i2 = 5;
            // true && false && true && true
            //在没有括号的情况下 从左到右 依次看即可
            //有括号 先看括号内
            result = i2 > 1 && i2 < 5 && i > 1 && i < 5;
            Console.WriteLine(result);

            #endregion

            #region 知识点二 逻辑或
            //符号 || 或者
            //规则 对两个bool值进行逻辑运算 有真则真 同假为假
            result = true || false;
            Console.WriteLine(result);
            result = true || true;
            Console.WriteLine(result);
            result = false || true;
            Console.WriteLine(result);
            result = false || false;
            Console.WriteLine(result);

            // false || true
            result = 3 > 10 || 3 < 5;
            Console.WriteLine(result);//true

            int a = 5;
            int b = 11;
            // true || true || false
            result = a > 1 || b < 20 || a > 5;
            Console.WriteLine(result);

            // ? && ?
            // ? || ?
            // ? 可以是写死的bool变量 或者 bool值
            // 还可以是 条件运算符相关

            #endregion

            #region 知识点三 逻辑非
            //符号 !
            //规则 对一个bool值进行取反  真变假  假变真

            result = !true;
            Console.WriteLine(result);
            result = !false;
            Console.WriteLine(result);
            result = !!true;
            Console.WriteLine(result);
            //逻辑非的 优先级 较高
            result = !(3 > 2);
            Console.WriteLine(result);

            a = 5;
            result = !(a > 5);
            Console.WriteLine(result);
            #endregion

            #region 知识点四 混合使用优先级问题
            // 规则  !(逻辑非)优先级最高   &&(逻辑与)优先级高于||(逻辑或)
            // 逻辑运算符优先级 低于 算数运算符 条件运算符（逻辑非除外）

            bool gameOver = false;
            int hp = 100;
            bool isDead = false;
            bool isMustOver = true;

            //false || false && true || true;
            //false || false || true;
            result = gameOver || hp < 0 && !isDead || isMustOver;
            Console.WriteLine(result);

            #endregion

            #region 知识点五 逻辑运算符短路规则

            int i3 = 1;
            // || 有真则真
            // 只要 逻辑与或者逻辑或 左边满足了条件 
            // i3 > 0 true 
            // 只要 满足条件 右边的内容 对于我们来说 已经不重要

            //逻辑或 有真则真 那左边只要为真了 右边就不重要
            result = i3 > 0 || ++i3 >= 1;
            Console.WriteLine(i3);
            Console.WriteLine(result);
            // false && i3 ++ > 1;抛弃后面不去计算

            //逻辑与 有假则假 那左边只要为假了 右边就不重要
            result = i3 < 0 && i3++ > 1;
            Console.WriteLine(i3);
            Console.WriteLine(result);
            #endregion
        }
    }
}
