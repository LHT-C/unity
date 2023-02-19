using Game;
using System;


namespace 必备知识_多脚本文件
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("多脚本文件");

            #region 知识点一 了解脚本文件格式和路径

            #endregion

            #region 知识点二 新建脚本文件
            //接口 类 结构体 一个申明 就对应一个脚本
            Person p = new Person();
            #endregion

            #region 知识点三 在文件夹中新建脚本文件
            GameObjectr obj = new GameObjectr();
            #endregion
        }
    }

    //总结
    //1.c#脚本文件的后缀 是 .cs 
    //2.c#解决方案中的一些重要文件夹 bin
    //3.解决方案资源管理器窗口 工程右键 点添加
    //4.文件中新建脚本文件 需要注意命名空间名 的改变
}
