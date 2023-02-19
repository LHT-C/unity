using System;

namespace Lesson9_异常捕获
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("异常捕获");

            #region 作用
            //将玩家输入的内容 存储 string类型的变量(容器)中
            //string str = Console.ReadLine();
            //Parse转字符串为 数值类型时  必须 要合法合规
            //int i = int.Parse(str);

            //通过对异常捕获的学习 可以避免当代码报错时 造成程序卡死的情况

            #endregion

            #region 基本语法

            //必备部分 
            try 
            {
                //希望进行异常捕获的代码块
                //放到try中 
                //如果try中的代码 报错了 不会让程序卡死
            }
            catch
            {
                //如果出错了 会执行 catch中的代码 来捕获异常
                //catch(Exception e) 具体报错跟踪 通过e得到 具体的错误信息
            }
            //可选部分
            finally
            {
                //最后执行的代码 不管有没有出错 都会执行其中的代码
                //目前 大家可以不用写
            }
            //注意：异常捕获代码基本结构中 不需要加; 在里面去写代码逻辑时  每一句代码才加;

            #endregion

            #region 实践
            try
            {
                string str = Console.ReadLine();
                int i = int.Parse(str);
                Console.WriteLine(i);
                //.......
            }
            catch
            {
                Console.WriteLine("请输入合法数字");
            }
            //finally
            //{
            //    Console.WriteLine("执行完毕");
            //}
            #endregion
        }
    }
}
