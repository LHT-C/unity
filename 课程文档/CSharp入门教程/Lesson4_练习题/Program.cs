using System;

namespace Lesson4_练习题
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("变量命名规范练习题");
            #region 练习题一
            //下面的变量名哪些是错误的？
            //U3d       No.1      3day
            //$money    discount_ 1    Shang Hai
            //class     int        _a_b_c_
            //Main      _ 2C       print

            int print = 1;

            #endregion

            #region 练习题二
            //按照驼峰命名法命名以下变量（使用英文）
            //我的年龄、我的性别、我的攻击力、我的防御力、你的身高、你的体重
            int myAge = 18;
            //bool mySex = false;
            //string mySex = "男";
            int mySex = 1;

            int myAtk = 9999;
            int myDef = 10000;

            float yourHeight = 180;
            float yourWeight = 50.5f;

            #endregion
        }
    }
}
