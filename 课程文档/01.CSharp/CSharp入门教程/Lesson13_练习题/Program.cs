using System;

namespace Lesson13_练习题
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("逻辑运算符练习题");
            #region 练习题一
            //求打印结果是什么？
            Console.WriteLine(true || true);// true
            Console.WriteLine(false || true);// true
            Console.WriteLine(true && true);// true
            Console.WriteLine(true && false);//false
            Console.WriteLine(!true);//false
            #endregion

            #region 练习题二
            //求打印结果是什么？
            bool gameOver;
            bool isWin;
            int health = 100;
            gameOver = true;
            isWin = false;
            // true || false && true
            Console.Write(gameOver || isWin && health > 0);
            #endregion
        }
    }
}
