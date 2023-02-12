using System;
using System.ComponentModel.DataAnnotations;
using System.Reflection;

namespace Lesson10_算数运算符
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("算数运算符");

            //算数运算符 是用于 数值类型变量计算的运算符
            //它的返回结果是数值

            #region 知识点一：赋值符号
            // =
            // 关键知识点 : 
            // 先看右侧 再看左侧 把右侧的值赋值给左侧的变量
            string myName = "唐老狮";
            int myAge = 18;
            float myHeight = 177.5f;

            #endregion

            #region 知识点二： 算数运算符

            #region 加 +
            // 用自己计算 先算右侧结果 再赋值给左侧变量
            int i = 1;
            // 3
            i = i + 2;
            Console.WriteLine(i);
            // 连续运算 先算右侧结果 再赋值给左侧变量
            // 99
            i = 1 + 3 + 89 + i + i;
            Console.WriteLine(i);
            //4
            i = 1 + 2 + 1;
            Console.WriteLine(i);

            // 初始化时就运算  先算右侧结果 再赋值给左侧变量
            int i2 = 1 + 2 + 4 + i;
            Console.WriteLine(i2);
            #endregion

            #region 减 -
            // 用自己计算 先算右侧结果 再赋值给左侧变量
            int j = 1;
            j = j - 1;
            Console.WriteLine(j);
            // 连续运算 先算右侧结果 再赋值给左侧变量
            j = 1 - 2 - 3;
            Console.WriteLine(j);
            j = 1 - j;
            Console.WriteLine(j);//5
            // 初始化时就运算  先算右侧结果 再赋值给左侧变量
            int j2 = 1 - j - 0;
            Console.WriteLine(j2);
            #endregion

            #region 乘 *
            // 用自己计算 先算右侧结果 再赋值给左侧变量
            int c = 1;
            c = c * 10;
            Console.WriteLine(c);
            // 连续运算 先算右侧结果 再赋值给左侧变量
            c = 1 * 2 * 3;
            Console.WriteLine(c);
            c = 2 * c * 2;
            Console.WriteLine(c);
            // 初始化时就运算  先算右侧结果 再赋值给左侧变量
            int c2 = c * 2;
            Console.WriteLine(c2);
            #endregion

            #region 除 / 
            // 用自己计算 先算右侧结果 再赋值给左侧变量
            int chu = 1;
            chu = 10 / chu;
            Console.WriteLine(chu);
            // 连续运算 先算右侧结果 再赋值给左侧变量

            // 初始化时就运算  先算右侧结果 再赋值给左侧变量

            chu = 1;
            chu = 1 / 2;
            Console.WriteLine(chu);
            //默认的整数 是int 如果用来做除法运算 要注意 会丢失小数点后的小数
            //如果你想用浮点数来存储 一定是 在运算时要有浮点数的特征
            float f = 1 / 2f;
            Console.WriteLine(f);

            #endregion

            #region 取余 %
            // 用自己计算 先算右侧结果 再赋值给左侧变量
            int y = 4;
            // 4 / 3 得到余数 1
            y = y % 3;
            Console.WriteLine(y);
            // 连续运算 先算右侧结果 再赋值给左侧变量
            y = 4 % 3 % 2;
            Console.WriteLine(y);
            // 初始化时就运算  先算右侧结果 再赋值给左侧变量

            #endregion

            #endregion

            #region 知识点三：算数运算符的 优先级
            //优先级 是指 在混合运算时的运算顺序

            //乘除取余 优先级高于 加减 先算乘除取余 后算加减
            // 1 + 3 + 1 + 6
            int a = 1 + 2 * 3 / 2 + 1 + 2 * 3;
            Console.WriteLine(a);

            a = 1 + 4 % 2 * 3 / 2 + 1;
            Console.WriteLine(a);

            //括号可以改变优先级 优先计算括号内内容
            a = 1 + 4 % (2 * 3 / 2) + 1;
            Console.WriteLine(a);

            //多组括号 先算最里层括号 依次往外算
            a = 1 + (4 % (2 * (3 / 2))) + 1;
            Console.WriteLine(a);
            #endregion

            #region 知识点四：算数运算符的 复合运算符
            // 固定写法 运算符=
            // += -= *= /= %=
            //复合运算符 是用于 自己=自己进行运算
            int i3 = 1;
            i3 = i3 + 2;
            Console.WriteLine(i3);

            i3 = 1;
            i3 += 2;//i3 = i3 + 2;
            Console.WriteLine(i3);

            i3 = 2;
            i3 += 2;//4
            i3 -= 2;//2
            i3 /= 2;//1
            i3 *= 2;//2
            i3 %= 2;//0
            Console.WriteLine(i3);

            int i4 = 10;
            // i4 += 4
            i4 += 20 * 2 / 10;
            Console.WriteLine(i4);

            //注意：复合运算符 只能进行一种运算 不能混合运算
            //i4 */-= 2;

            #endregion

            #region 知识点五：算术运算符的 自增减
            int a2 = 1;
            a2 = a2 + 1;
            
            a2 = 1;
            a2 += 1;

            //自增运算符  让自己+1 
            a2 = 1;
            a2++;//先用再加
            Console.WriteLine(a2);
            ++a2;//先加再用
            Console.WriteLine(a2);

            a2 = 1;
            Console.WriteLine(a2++);//1
            //2
            Console.WriteLine(++a2);//3

            //自减运算符 让自己-1
            a2 = 1;
            a2--;//先用再减
            --a2;//先减再用

            a2 = 1;
            Console.WriteLine(a2--);//1
            //0
            Console.WriteLine(--a2);//-1

            #endregion
        }
    }
}
