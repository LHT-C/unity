using System;

namespace Lesson4_练习题
{
    #region 练习题一
    //基于成员方法练习题
    //对人类的构造函数进行重载，用人类创建若干个对象
    class Person
    {
        public string name;
        public float height;
        public int age;
        public string homeAddress;

        public Person(string name, float height, int age, string homeAddress) :this(name, height)
        {
            //this
            this.age = age;
            this.homeAddress = homeAddress;
        }

        public Person(string name, float height)
        {
            this.name = name;
            this.height = height;
        }

        public void Speak(string str)
        {
            Console.WriteLine("{0}说{1}", name, str);
        }

        public void Walk()
        {
            Console.WriteLine("{0}开始走路了", name);
        }

        public void Eat(Food f)
        {
            Console.WriteLine("{0}吃了{1}", name, f.name);
        }
    }
    class Food
    {
        public string name;
        public int kaluli;
    }
    #endregion

    #region 练习题二
    //基于成员变量练习题
    //对班级类的构造函数进行重载，用班级类创建若干个对象
    class Class
    {
        public string name;
        public int capacity;
        public Student[] students;

        public Class(string name, int capacity)
        {
            this.name = name;
            this.capacity = capacity;
        }

        public Class(string name, int capacity, Student[] students):this(name, capacity)
        {
            this.students = students;
        }
    }

    class Student
    {

    }
    #endregion

    #region 练习题三
    //写一个Ticket类，有一个距离变量（在构造对象时赋值，不能为负数），有一个价格特征，
    //有一个方法GetPrice可以读取到价格，并且根据距离distance计算价格price（1元/公里）
    //0~100公里 不打折
    //101~200公里 打9.5折
    //201~300公里 打9折
    //300公里以上 打8折
    //有一个显示方法，可以显示这张票的信息。
    //例如：100公里100块钱

    class Ticket
    {
        public uint distance;
        public float price;

        public Ticket(uint distance)
        {
            this.distance = distance;
            price = GetPrice();
        }

        private float GetPrice()
        {
            //0~100公里 不打折
            //101~200公里 打9.5折
            //201~300公里 打9折
            //300公里以上 打8折
            if ( distance > 300 )
            {
                return distance * 0.8f;
            }
            else if( distance >= 201 && distance <= 300 )
            {
                return distance * 0.9f;
            }
            else if (distance >= 101 && distance <= 200)
            {
                return distance * 0.95f;
            }
            else
            {
                return distance;
            }
        }

        public void ShowInfo()
        {
            Console.WriteLine("{0}公里{1}块钱", distance, price);
        }
    }
    #endregion

    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("构造函数析构函数练习题");

            Person p1 = new Person("唐老狮", 177.5f, 18, "成都");
            Person p2 = new Person("小火", 184.5f);

            Class c1 = new Class("Unity", 9999999);
            Class c2 = new Class("C#", 9999999, new Student[] { new Student(), new Student() });

            Ticket t = new Ticket(500);
            t.ShowInfo();
        }
    }
}
