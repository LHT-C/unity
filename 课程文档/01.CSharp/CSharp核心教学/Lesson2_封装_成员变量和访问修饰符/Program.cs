using System;

namespace Lesson2_封装_成员变量和访问修饰符
{
    #region 知识回顾
    // 类和对象
    // 申明类
    //class Person
    //{
    //    //特征——成员变量
    //    //行为——成员方法
    //    //保护特征——成员属性

    //    //构造函数和析构函数
    //    //索引器
    //    //运算符重载函数
    //    //静态函数
    //}

    // 实例化对象
    // Person 变量名;
    // Person 变量名 = null;
    // Person 变量名 = new Person();
    #endregion

    #region 知识点一 成员变量
    //基本规则
    //1.申明在类语句块中
    //2.用来描述对象的特征
    //3.可以是任意变量类型
    //4.数量不做限制
    //5.是否赋值根据需求来定
    
    //性别枚举
    enum E_SexType
    {
        Man,
        Woman,
    }
    //位置结构体
    struct Position
    {

    }
    //宠物类
    class Pet
    {

    }
    class Person
    {
        //特征——成员变量
        //姓名
        public string name = "唐老狮";
        //年龄
        public int age;
        //性别
        public E_SexType sex;
        //女朋友
        //如果要在类中申明一个和自己相同类型的成员变量时
        //不能对它进行实例化
        public Person gridFriend;
        //朋友
        public Person[] boyFriend;
        //位置
        public Position pos;
        //宠物
        private Pet pet = new Pet();
    }

    #endregion

    #region 知识点二 访问修饰符
    // public —— 公共的  自己(内部)和别人(外部)都能访问和使用
    // private —— 私有的  自己(内部)才能访问和使用  不写 默认为private
    // protected —— 保护的  自己(内部)和子类才能访问和使用
    // 目前决定类内部的成员 的 访问权限
    #endregion

    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("成员变量和访问修饰符");

            Person p = new Person();

            #region 知识点三 成员变量的使用和初始值
            //值类型来说 数字类型 默认值都是0  bool类型 false  
            //引用类型的 null
            //交给大家一个看默认值的小技巧  default(变量类型) 就能得到默认值
            Console.WriteLine(default(Person));

            p.age = 10;
            Console.WriteLine(p.age);
            #endregion
        }
    }
    //总结
    //成员变量
    //描述特征
    //类中申明
    //赋值随意
    //默认值，值不相同
    //默认值，引用为null
    //任意类型
    //任意数量

    //访问修饰符
    //3P
    //public 公共 内外
    //private 私有的 内
    //protected 保护的 内和子类
}
