using System;

namespace Lesson5_练习题
{
    #region 练习题
    //定义一个学生类，有五种属性，分别为姓名、性别、年龄、CSharp成绩、Unity成绩
    //有两个方法：
    //一个打招呼：介绍自己交XX，今年几岁了。是男同学还是女同学
    //计算自己总分数和平均分并显示的方法
    //使用属性完成：年龄必须是0 ~150岁之间，成绩必须是0 ~100
    //性别只能是男或女
    //实例化两个对象并测试
    class Student
    {
        private int age;
        private int cSharp;
        private int unity;
        private string sex;
        public string Name
        {
            get;
            set;
        }
        public string Sex
        {
            get
            {
                return sex;
            }
            set
            {
                if (value != "男" && value != "女")
                {
                    sex = "不男不女";
                }
                else
                {
                    sex = value;
                }
            }
        }
        public int Age
        {
            get
            {
                return age;
            }
            set
            {
                if (value < 0)
                {
                    age = 0;
                }
                else if (value > 150)
                {
                    age = 150;
                }
                else
                {
                    age = value;
                }
            }
        }
        public int CSharp
        {
            get
            {
                return cSharp;
            }
            set
            {
                if (value < 0)
                {
                    cSharp = 0;
                }
                else if (value > 100)
                {
                    cSharp = 100;
                }
                else
                {
                    cSharp = value;
                }
            }
        }
        public int Unity
        {
            get
            {
                return unity;
            }
            set
            {
                if (value < 0)
                {
                    unity = 0;
                }
                else if (value > 100)
                {
                    unity = 100;
                }
                else
                {
                    unity = value;
                }
            }
        }

        public void SayHellow()
        {
            Console.WriteLine("我叫{0},今年{1}岁了,是{2}同学", Name, Age, Sex);
        }

        public void ShowInfo()
        {
            int sum = CSharp + Unity;
            float avg = sum / 2f;
            Console.WriteLine("总分{0}，平均分{1}", sum, avg);
        }
    }
    #endregion
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("成员属性练习题");

            Student s1 = new Student();
            s1.Name = "唐老狮";
            s1.Age = 160;
            s1.Unity = 150;
            s1.CSharp = 150;
            s1.Sex = "超人";
            s1.SayHellow();
            s1.ShowInfo();

            Student s2 = new Student();
            s2.Name = "亲爱的同学";
            s2.Age = 20;
            s2.Unity = 80;
            s2.CSharp = 90;
            s2.Sex = "女";
            s2.SayHellow();
            s2.ShowInfo();
        }
    }
}
