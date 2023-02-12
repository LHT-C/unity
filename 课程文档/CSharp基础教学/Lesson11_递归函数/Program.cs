using System;

namespace Lesson11_递归函数
{
    class Program
    {
        #region 知识点一 基本概念
        //递归函数 就是 让函数自己调用自己
        //static void Fun()
        //{
        //    if( false )
        //    {
        //        return;
        //    }
        //    Fun();
        //}
        //一个正确的递归函数
        // 1.必须有结束调用的条件
        // 2.用于条件判断的 这个条件 必须改变 能够达到停止的目的
        #endregion

        #region 知识点二 实例
        //用递归函数打印出 0到10
        //递归函数 就是自己调用自己
        static void Fun(int a)
        {
            //第四步：结束条件
            if( a > 10 )
            {
                return;
            }
            //第二步：完成要求 打印
            Console.WriteLine(a);
            //第三部：完成一个 递归的变化 作为我们条件的判断
            ++a;
            //第一步：构造了一个递归
            Fun(a);
        }

        #endregion

        static void Main(string[] args)
        {
            Console.WriteLine("递归函数");
            //Fun(0);
        }
    }
}
