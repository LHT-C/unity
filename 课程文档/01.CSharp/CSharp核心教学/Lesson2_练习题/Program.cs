using System;

namespace Lesson2_练习题
{
    #region 练习题一
    //3P是什么？
    //public 公共 内外
    //private 私有的 内
    //protected 保护的 内部和子类
    #endregion

    #region 练习题二
    //定义一个人类，有姓名，身高，年龄，家庭住址等特征
    //用人创建若干个对象
    class Person
    {
        public string name;
        public float height;
        public int age;
        public string homeAddress;
    }
    #endregion

    #region 练习题三
    //定义一个学生类，有姓名，学号，年龄，同桌等特征。用学生类创建若干个学生
    class Student
    {
        public string name;
        public int number;
        public int age;
        public Student deskmate;
    }
    #endregion

    #region 练习题四
    //定义一个班级类，有专业名称，教室容量，学生等
    //创建一个班级对象
    class Class
    {
        public string name;
        public int capacity;
        public Student[] students;
    }


    #endregion
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("成员变量和访问修饰符练习题");
            #region 练习题五
            //Person p = new Person();
            //p.age = 10;
            //Person p2 = new Person();
            //p2.age = 20;
            //Console.WriteLine(p.age);
            //请问p.age为多少？
            #endregion

            #region 练习题六
            Person p = new Person();
            p.age = 10;
            Person p2 = p;
            p2.age = 20;
            Console.WriteLine(p.age);
            //请问p.age为多少？
            #endregion

            #region 练习题七
            //Student s = new Student();
            //s.age = 10;
            //int age = s.age;
            //age = 20;
            //Console.WriteLine(s.age);
            //请问s.age为多少？
            #endregion

            #region 练习题八
            Student s = new Student();
            s.deskmate = new Student();
            s.deskmate.age = 10;
            Student s2 = s.deskmate;
            s2.age = 20;
            Console.WriteLine(s.deskmate.age);
            //请问s.deskmate.age为多少？
            #endregion

            //Person p = new Person();
            //p.age = 10;
            //p.name = "唐老狮";
            //p.height = 177.5f;
            //p.homeAddress = "成都";

            //Person p1 = new Person();
            //p1.age = 20;
            //p1.name = "小红";
            //p1.height = 180f;
            //p1.homeAddress = "火星";

            //Student s = new Student();
            //s.name = "火山哥";
            //s.number = 1;
            //s.age = 22;

            //Student s1 = new Student();
            //s1.name = "小明";
            //s1.number = 2;
            //s1.age = 18;

            //s.deskmate = s1;
            //s1.deskmate = s;

            //Class c = new Class();
            //c.name = "Unity";
            //c.capacity = 999999999;
            //c.students = new Student[] { s, s1 };
        }
    }
}
