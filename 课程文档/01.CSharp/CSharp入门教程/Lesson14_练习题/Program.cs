using System;

namespace Lesson14_练习题
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("位与算符练习题");
            #region 练习题一
            //35 << 4 和 66 >> 1 的结果为？
            // 35 => 100011
            // 35 << 4 = 10 0011 0000
            // 16 + 32 + 512 = 560
            Console.WriteLine(35 << 4);

            // 66 => 1000010
            // 66 >> 1 = 100001
            // 1 + 32 = 33
            Console.WriteLine(66 >> 1);

            #endregion

            #region 练习题二
            //99 ^ 33 和 76 | 85 的结果为？

            // 1100011 ^ 100001
            // 1100011
            //^0100001
            // 1000010
            Console.WriteLine(99 ^ 33);

            // 1001100 | 1010101
            // 1001100
            //|1010101
            // 1011101 => 64 + 29 = 93
            Console.WriteLine(76 | 85);

            #endregion
        }
    }
}
