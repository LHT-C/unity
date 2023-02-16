using System;

namespace 必备知识点_随机数
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("随机数");
            #region 知识点一 产生随机数对象
            //固定写法
            // Random 随机数变量名 = new Random();
            Random r = new Random();
            #endregion

            #region 知识点二 生成随机数
            int i = r.Next(); //生成一个非负数的随机数
            Console.WriteLine(i);

            i = r.Next(100); // 生成一个 0~99的随机数 左边始终是0 左包含  右边是100 右不包含
            Console.WriteLine(i);

            i = r.Next(5, 100); // 生成一个 5到99的随机数 左包含 右不包含
            Console.WriteLine(i);
            #endregion
        }
    }
}
