﻿using System;

namespace Lesson25_面向对象相关_结构体和类的区别
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("结构体和类的区别");

            #region 区别概述
            //结构体和类最大的区别是在存储空间上的，因为结构体是值，类是引用，
            //因此他们的存储位置一个在栈上，一个在堆上，
            //通过之前知识点的学习，我相信你能够从此处看出他们在使用的区别——值和引用对象在赋值时的区别。

            //结构体和类在使用上很类似，结构体甚至可以用面向对象的思想来形容一类对象。
            //结构体具备着面向对象思想中封装的特性，但是它不具备继承和多态的特性，因此大大减少了它的使用频率。
            //由于结构体不具备继承的特性，所以它不能够使用protected保护访问修饰符。
            #endregion

            #region 细节区别
            //1.结构体是值类型，类是引用类型
            //2.结构体存在栈中，类存在堆中
            //3.结构体成员不能使用protected访问修饰符，而类可以
            //4.结构体成员变量申明不能指定初始值，而类可以
            //5.结构体不能申明无参的构造函数，而类可以
            //6.结构体申明有参构造函数后，无参构造不会被顶掉
            //7.结构体不能申明析构函数，而类可以
            //8.结构体不能被继承，而类可以
            //9.结构体需要在构造函数中初始化所有成员变量，而类随意
            //10.结构体不能被静态static修饰（不存在静态结构体），而类可以
            //11.结构体不能在自己内部申明和自已一样的结构体变量，而类可以
            #endregion

            #region 结构体的特别之处
            //结构体可以继承 接口 因为接口是行为的抽象
            #endregion

            #region 如何选择结构体和类
            //1.想要用继承和多态时，直接淘汰结构体，比如玩家、怪物等等
            //2.对象是数据集合时，优先考虑结构体，比如位置、坐标等等
            //3.从值类型和引用类型赋值时的区别上去考虑，比如经常被赋值传递的对象，并且
            //改变赋值对象，原对象不想跟着变化时，就用结构体。比如坐标、向量、旋转等等
            #endregion
        }
    }
}
