using System;

namespace Lesson1_练习题
{
    class GameObject
    {

    }

    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("类和对象练习题");

            #region 练习题一
            //将下面的事物进行分类，可重复
            //机器人、机器、人、猫、张阿姨、隔壁老王、汽车、飞机、向日葵、菊花、太阳、星星、荷花
            //机器：机器人、机器、汽车、飞机
            //人：人、张阿姨、隔壁老王
            //动物：猫、人、张阿姨、隔壁老王
            //植物：向日葵、菊花、荷花
            //星球：星星

            #endregion

            #region 练习题二
            //GameObject A = new GameObject();
            //GameObject B = A;
            //B = null;
            //A目前等于多少？
            #endregion

            #region 练习题三
            GameObject A = new GameObject();
            GameObject B = A;
            B = new GameObject();
            //A和B有什么关系？
            #endregion
        }
    }
}
