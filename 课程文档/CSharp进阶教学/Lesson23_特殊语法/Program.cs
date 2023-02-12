using System;
using System.Collections.Generic;

namespace Lesson23_特殊语法
{
    class Person
    {
        private int money;
        public bool sex;

        public string Name
        {
            get => "唐老狮";
            set => sex = true;
        }

        public int Age
        {
            get;
            set;
        }

        public Person(int money)
        {
            this.money = money;
        }

        public int Add(int x, int y) => x + y;

        public void Speak(string str) => Console.WriteLine(str);
    }

    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("特殊语法");

            #region 知识点一 var隐式类型
            //var是一种特殊的变量类型
            //它可以用来表示任意类型的变量
            //注意：
            //1.var不能作为类的成员 只能用于临时变量申明时
            //  也就是 一般写在函数语句块中
            //2.var必须初始化
            var i = 5;
            var s = "123";
            var array = new int[] { 1, 2, 3, 4 };
            var list = new List<int>();
            #endregion

            #region 知识点二 设置对象初始值
            //申明对象时 
            //可以通过直接写大括号的形式初始化公共成员变量和属性
            Person p = new Person(100) { sex = true, Age = 18, Name = "唐老狮" };
            Person p2 = new Person(200) { Age = 18 };
            #endregion

            #region 知识点三 设置集合初始值
            //申明集合对象时
            //也可以通过大括号 直接初始化内部属性
            int[] array2 = new int[] { 1, 2, 3, 4, 5 };

            List<int> listInt = new List<int>() { 1, 2, 3, 4, 5, 6 };

            List<Person> listPerson = new List<Person>() {
                new Person(200),
                new Person(100){Age = 10},
                new Person(1){sex = true, Name = "唐老狮"}
            };

            Dictionary<int, string> dic = new Dictionary<int, string>()
            {
                { 1, "123" },
                { 2, "222"}
            };

            #endregion

            #region 知识点四 匿名类型
            //var 变量可以申明为自定义的匿名类型
            var v = new { age = 10, money = 11, name = "小明" };
            Console.WriteLine(v.age);
            Console.WriteLine(v.name);
            #endregion

            #region 知识点五 可空类型
            //1.值类型是不能赋值为 空的
            //int c = null;
            //2.申明时 在值类型后面加? 可以赋值为空
            int? c = 3;
            //3.判断是否为空
            if( c.HasValue )
            {
                Console.WriteLine(c);
                Console.WriteLine(c.Value);
            }
            //4.安全获取可空类型值
            int? value = null;
            //  4-1.如果为空 默认返回值类型的默认值
            Console.WriteLine(value.GetValueOrDefault());
            //  4-2.也可以指定一个默认值
            Console.WriteLine(value.GetValueOrDefault(100));

            float? f = null;
            double? d = null;

            
            object o = null;
            if( o != null )
            {
                Console.WriteLine(o.ToString());
            }
            //相当于是一种语法糖 能够帮助我们自动去判断o是否为空
            //如果是null就不会执行tostring也不会报错
            Console.WriteLine(o?.ToString());

            int[] arrryInt = null;

            Console.WriteLine(arrryInt?[0]);

            Action action = null;
            //if (action != null)
            //{
            //    action();
            //}
            action?.Invoke();

            #endregion

            #region 知识点六 空合并操作符
            // 空合并操作符 ??
            // 左边值 ?? 右边值
            // 如果左边值为null 就返回右边值 否则返回左边值
            // 只要是可以为null的类型都能用

            int? intV = null;
            //int intI = intV == null ? 100 : intV.Value;
            int intI = intV ?? 100;
            Console.WriteLine(intI);

            string str = null;
            str = str ?? "hahah";
            Console.WriteLine(str);
            #endregion

            #region 知识点七 内插字符串
            //关键符号：$
            //用$来构造字符串，让字符串中可以拼接变量
            string name = "唐老狮";
            int age = 18;
            Console.WriteLine($"好好学习,{name},年龄：{age}");
            #endregion

            #region 知识点八 单句逻辑简略写法
            //当循环或者if语句中只有 一句代码时 大括号可以省略
            if (true)
                Console.WriteLine("123123");

            for (int j = 0; j < 10; j++)
                Console.WriteLine(j);

            while (true)
                Console.WriteLine("123123");

            #endregion
        }
    }
}
