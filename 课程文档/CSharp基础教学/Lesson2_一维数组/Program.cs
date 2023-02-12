using System;

namespace Lesson2_一维数组
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("一维数组");

            #region 知识点一 基本概念
            //数组是存储一组相同类型数据的集合
            //数组分为 一维、多维、交错数组
            //一般情况 一维数组 就简称为 数组
            #endregion

            #region 知识点二 数组的申明

            // 变量类型[] 数组名;//只是申明了一个数组 但是并没有开房
            // 变量类型 可以是我们学过的 或者 没学过的所有变量类型
            int[] arr1;

            // 变量类型[] 数组名 = new 变量类型[数组的长度];
            int[] arr2 = new int[5]; //这种方式 相当于开了5个房间 但是房间里面的int值 默认为0

            // 变量类型[] 数组名 = new 变量类型[数组的长度]{内容1,内容2,内容3,.......};
            int[] arr3 = new int[5] { 1, 2, 3, 4, 5 };

            // 变量类型[] 数组名 = new 变量类型[]{内容1,内容2,内容3,.......};
            int[] arr4 = new int[] { 1,2,3,4,5,6,7,8,9}; //后面的内容就决定了 数组的长度 “房间数”

            // 变量类型[] 数组名 = {内容1,内容2,内容3,.......};
            int[] arr5 = { 1,3,4,5,6};//后面的内容就决定了 数组的长度 “房间数”


            bool[] arr6 = { true, false };
            #endregion

            #region 知识点三 数组的使用

            int[] array = { 1, 2, 3, 4, 5 };
            //1.数组的长度
            // 数组变量名.Length
            Console.WriteLine(array.Length);

            //2.获取数组中的元素
            //数组中的下标和索引 他们是从0开始的
            //通过 索引下标去 获得数组中某一个元素的值时
            //一定注意！！！！！！！！
            //不能越界  数组的房间号 范围 是 0 ~ Length-1
            Console.WriteLine(array[0]);
            Console.WriteLine(array[2]);
            Console.WriteLine(array[4]);

            //3.修改数组中的元素
            array[0] = 99;
            Console.WriteLine(array[0]);

            //4.遍历数组 通过循环 快速获取数组中的每一个元素
            Console.WriteLine("**********************");
            for (int i = 0; i < array.Length; i++)
            {
                Console.WriteLine(array[i]);
            }
            Console.WriteLine("**********************");
            //5.增加数组的元素
            // 数组初始化以后 是不能够 直接添加新的元素的
            int[] array2 = new int[6];
            //搬家
            for (int i = 0; i < array.Length; i++)
            {
                array2[i] = array[i];
            }
            array = array2;
            for (int i = 0; i < array.Length; i++)
            {
                Console.WriteLine(array[i]);
            }
            array[5] = 999;
            Console.WriteLine("**********************");
            //6.删除数组的元素
            // 数组初始化以后 是不能够 直接删除元素的
            // 搬家的原理
            int[] array3 = new int[5];
            //搬家
            for (int i = 0; i < array3.Length; i++)
            {
                array3[i] = array[i];
            }
            array = array3;
            Console.WriteLine(array.Length);

            //7.查找数组中的元素
            // 99 2 3 4 5 
            // 要查找 3这个元素在哪个位置
            // 只有通过遍历才能确定 数组中 是否存储了一个目标元素
            int a = 3;

            for (int i = 0; i < array.Length; i++)
            {
                if( a == array[i] )
                {
                    Console.WriteLine("和a相等的元素在{0}索引位置", i);
                    break;
                }
            }

            #endregion

            //总结
            //1.概念：同一变量类型的数据集合
            //2.一定要掌握的知识：申明，遍历，增删查改
            //3.所有的变量类型都可以申明为 数组
            //4.她是用来批量存储游戏中的同一类型对象的 容器  比如 所有的怪物 所有玩家
        }
    }
}
