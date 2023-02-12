using System;

namespace Lesson12_练习题
{
    #region 练习题一
    //使用结构体描述学员的信息，姓名，性别，年龄，班级，专业，
    //创建两个学员对象，并对其基本信息进行初始化并打印
    struct Student
    {
        public string name;
        public bool sex;
        public int age;
        public int clas;
        public string major;

        public Student(string name, bool sex, int age, int clas, string major)
        {
            this.name = name;
            this.sex = sex;
            this.age = age;
            this.clas = clas;
            this.major = major;
        }

        public void Speak()
        {
            Console.WriteLine("姓名：{0}性别：{1}年龄：{2}班级：{3}专业：{4}", name, sex ? "女":"男", age, clas, major);
        }
    }
    #endregion

    #region 练习题二
    //请简要描述private和public两个关键字的区别
    // 他们都是访问修饰符 用来修饰变量和函数的
    // 如果默认不写访问修饰符 则为private
    // private 私有的 被它修饰的变量和函数只能在结构体内部使用 外部无法使用  
    // public 公共的 被它修饰的变量和函数 能在内外都访问
    #endregion

    #region 练习题三
    //使用结构体描述矩形的信息，长，宽；创建一个矩形，
    //对其长宽进行初始化，并打印矩形的长、宽、面积、周长等信息。

    struct Rect
    {
        public float w;
        public float h;
        public float area;
        public float perimeter;

        public Rect(int w, int h)
        {
            this.w = w;
            this.h = h;
            area = w * h;
            perimeter = 2 * (w + h);
        }

        public void WriteInfo()
        {
            Console.WriteLine("该矩形宽为{0}高为{1}面积为{2}周长为{3}", w, h, area, perimeter);
        }
    }
    #endregion

    #region 练习题四
    //使用结构体描述玩家信息，玩家名字，玩家职业
    //请用户输入玩家姓名，选择玩家职业，最后打印玩家的攻击信息
    //职业：
    //战士（技能：冲锋）
    //猎人（技能：假死）
    //法师（技能：奥术冲击）

    //打印结果：猎人唐老狮释放了假死
    struct PlayerInfo
    {
        public string name;
        public E_Occupation occupation;

        public PlayerInfo(string name, E_Occupation occupation)
        {
            this.name = name;
            this.occupation = occupation;
        }

        public void Atk()
        {
            string o = "";
            string s = "";
            switch (occupation)
            {
                case E_Occupation.Warrior:
                    o = "战士";
                    s = "冲锋";
                    //Console.WriteLine("战士{0}释放了冲锋");
                    break;
                case E_Occupation.Hunter:
                    o = "猎人";
                    s = "假死";
                    //Console.WriteLine("猎人{0}释放了假死");
                    break;
                case E_Occupation.Master:
                    o = "法师";
                    s = "奥术冲击";
                    //Console.WriteLine("法师0}释放了奥数冲击");
                    break;
                default:
                    break;
            }
            Console.WriteLine("{0}{1}释放了{2}", o, name, s);
        }
    }
    enum E_Occupation
    {
        /// <summary>
        /// 战士
        /// </summary>
        Warrior,
        /// <summary>
        /// 猎人
        /// </summary>
        Hunter,
        /// <summary>
        /// 法师
        /// </summary>
        Master,
    }
    #endregion

    #region 练习题五
    //使用结构体描述小怪兽
    
    struct Monster
    {
        public string name;
        public int atk;

        public Monster(string name)
        {
            this.name = name;
            Random r = new Random();
            atk = r.Next(10, 30);
        }

        public void Atk()
        {
            Console.WriteLine("{0}的攻击力是{1}", name, atk);
        }
    }
    #endregion

    #region 练习题六
    //定义一个数组存储10个上面描述的小怪兽，每个小怪兽的名字为（小怪兽+数组下标）
    //举例：小怪兽0，最后打印10个小怪兽的名字+攻击力数值
    #endregion

    #region 练习题七
    //应用已学过的知识，实现奥特曼打小怪兽
    //提示：
    //结构体描述奥特曼与小怪兽
    //定义一个方法实现奥特曼攻击小怪兽
    //定义一个方法实现小怪兽攻击奥特曼

    struct OutMan
    {
        public string name;
        public int atk;
        public int def;
        public int hp;

        public OutMan(string name, int atk, int def, int hp)
        {
            this.name = name;
            this.atk = atk;
            this.def = def;
            this.hp = hp;
        }

        //结构体是值类型 想要在函数内部改变值类型信息 外部受影响 一定 记住 用 ref或者out
        public void Atk( ref Boss monster )
        {
            //奥特曼打小怪兽的逻辑
            monster.hp -= atk - monster.def;
            Console.WriteLine("{0}攻击了{1},造成了{2}伤害,{3}剩余血量{4}", name, monster.name, atk - monster.def, monster.name, monster.hp);
        }
    }

    struct Boss
    {
        public string name;
        public int atk;
        public int def;
        public int hp;

        public Boss(string name, int atk, int def, int hp)
        {
            this.name = name;
            this.atk = atk;
            this.def = def;
            this.hp = hp;
        }

        public void Atk(ref OutMan outMan)
        {
            //小怪兽打奥特曼的逻辑
            outMan.hp -= atk - outMan.def;
            Console.WriteLine("{0}攻击了{1},造成了{2}伤害,{3}剩余血量{4}", name, outMan.name, atk - outMan.def, outMan.name, outMan.hp);
        }
    }

    #endregion

    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("结构体练习题");

            //变量类型[] 数组名 = new 变量类型[10];
            Monster[] monsters = new Monster[10];
            for (int i = 0; i < monsters.Length; i++)
            {
                monsters[i] = new Monster("小怪兽" + i);
                monsters[i].Atk();
            }

            OutMan outMan = new OutMan("雷欧奥特曼", 10, 5, 100);
            Boss boss = new Boss("哥斯拉", 8, 4, 100);

            while(true)
            {
                outMan.Atk(ref boss);
                if( boss.hp <= 0 )
                {
                    Console.WriteLine("{0}胜利",outMan.name);
                    break;
                }
                boss.Atk(ref outMan);
                if (outMan.hp <= 0)
                {
                    Console.WriteLine("{1}胜利", boss.name);
                    break;
                }
                Console.WriteLine("按任意键继续");
                Console.ReadKey(true);
            }




            Student s1 = new Student("唐老狮", false, 18, 3, "软件工程");
            s1.Speak();

            Student s2;
            s2.name = "小明";
            s2.sex = false;
            s2.age = 10;
            s2.clas = 1;
            s2.major = "网络工程";
            s2.Speak();

            Rect r = new Rect(5, 4);
            r.WriteInfo();

            Console.WriteLine("请输入你的姓名");
            string name = Console.ReadLine();
            Console.WriteLine("请输入职业(0战士 1猎人 2法师)");
            try
            {
                E_Occupation o = (E_Occupation)int.Parse(Console.ReadLine());
                //根据输入的内容初始化了一个玩家对象
                PlayerInfo info = new PlayerInfo(name, o);
                info.Atk();
            }
            catch
            {
                Console.WriteLine("请输入数字");
            }
        }
    }
}
