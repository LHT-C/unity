using System;

namespace Lesson12_练习题
{
    #region 练习题
    //写一个人类，人类中有姓名，年龄属性，有说话行为
    //战士类继承人类，有攻击行为

    class Warrior : Person
    {
        public void Atk( Warrior otherWarrior )
        {
            Console.WriteLine("{0}打了{1}", Name, otherWarrior.Name);
        }
    }

    class Person
    {
        public string Name
        {
            get;
            set;
        }
        private int Age
        {
            get;
            set;
        }
        public void Speak(string str)
        {
            Age = 10;
            Console.WriteLine(Age);
            Console.WriteLine(str);
        }
    }
    #endregion
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("继承练习题");

            Warrior w1 = new Warrior();
            w1.Name = "唐老狮";
            Warrior w2 = new Warrior();
            w2.Name = "奥特曼";

            w1.Atk(w2);
            w1.Speak("123");
        }
    }
}
