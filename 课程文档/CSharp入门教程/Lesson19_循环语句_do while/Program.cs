using System;

namespace Lesson19_循环语句_do_while
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("do...while循环");

            #region 知识点一 基本语法
            // while循环 是先判断条件再执行
            // do while循环 是先斩后奏 先至少执行一次循环语句块中的逻辑 再判断是否继续
            //do
            //{
            //    //do while 循环语句块;
            //} while (bool类型的值);
            // 注意 do while 语句 存在一个重要的分号
            #endregion

            #region 知识点二 实际使用

            // do while 使用较多

            //do
            //{
            //    Console.WriteLine("do while 循环语句块");
            //} while (true);

            //int a = 0;
            //do
            //{
            //    Console.WriteLine(a);
            //    ++a;
            //} while (a < 2);
            #endregion

            #region 知识点三 嵌套使用
            // if switch while do while
            do
            {
                //if(true)
                //{

                
                //}
                //while(true)
                //{

                //}
                //int i = 1;
                //switch (i)
                //{
                //    default:
                //        break;
                //}

                //break;
                //Console.WriteLine("111");
                //continue;
                //Console.WriteLine("111");
            } while (false);
            #endregion
        }
    }
}
