using System;

namespace Lesson12_练习题
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("条件运算符练习题");
            #region 练习题一
            //请口答下列表达式的结果
            //我的年龄（18） > 你们的年龄（22）   // false
            //兔子的速度（3m / s） < 乌龟的速度(0.3m / s)  //false
            //狗的重量(50kg) < 兔子的重量(5kg)  //false
            //我身上的Money(10元) == 你身上也有Money(10元)  //true
            #endregion

            #region 练习题二
            //求打印结果是什么？
            //bool b = true;
            //Console.WriteLine(b != true); //false

            //Console.WriteLine(10 == 10); // true
            //Console.WriteLine(10 > 20); // false
            //Console.WriteLine(10 <= 20); // true
            //Console.WriteLine(10 <= 10); // true
            #endregion

            #region 练习题三
            bool gameOver, startGame; //是可以不初始化
            int a = 10, b = 15;
            // 10 > 10 false
            gameOver = a > (b - 5); //false
            // false == false
            startGame = gameOver == (b > (a + 5));// true
            Console.WriteLine("startGame = " + startGame);
            //请问打印结果是什么？
            #endregion
        }
    }
}
