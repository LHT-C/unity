using System;

namespace Lesson3_练习题
{
    #region 练习题一
    //基于成员变量练习题
    //为人类定义说话、走路、吃饭等方法
    class Person
    {
        public string name;
        public float height;
        public int age;
        public string homeAddress;

        public void Speak(string str)
        {
            Console.WriteLine("{0}说{1}", name, str);
        }

        public void Walk()
        {
            Console.WriteLine("{0}开始走路了", name);
        }

        public void Eat( Food f )
        {
            Console.WriteLine("{0}吃了{1}", name, f.name);
        }
    }
    #endregion

    #region 练习题二
    //基于成员变量练习题
    //为学生类定义学习、吃饭等方法
    class Student
    {
        public string name;
        public int number;
        public int age;
        public Student deskmate;

        public void Learn()
        {
            Console.WriteLine("{0}在学习", name);
        }

        public void Eat(Food f)
        {
            Console.WriteLine("{0}开始吃{1}", name, f.name);
        }
    }
    #endregion

    #region 练习题三
    //定义一个食物类，有名称，热量等特征
    //思考如何和人类以及学生类联系起来
    class Food
    {
        public string name;
        public int kaLuli;

        public void BeiEat(Person p)
        {
            Console.WriteLine("{0}吃了{1}", p.name, name);
        }

        public void BeiEat(Student s)
        {
            Console.WriteLine("{0}吃了{1}", s.name, name);
        }
    }
    #endregion

    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("成员方法练习题");
            Person p = new Person();
            p.name = "唐老狮";
            Student s = new Student();
            s.name = "小火";
            
            Food f = new Food();
            f.name = "火龙果";

            p.Eat(f);
            s.Eat(f);
        }
    }
}
