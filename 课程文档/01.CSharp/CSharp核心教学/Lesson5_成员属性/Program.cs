using System;

namespace Lesson5_成员属性
{
    #region 知识回顾
    //class Person
    //{
    //    //特征——成员变量
    //    private int age;
    //    private string name;
    //    //金钱
    //    private int money;
    //    //行为——成员方法
    //    public void Speak()
    //    {
    //        Console.WriteLine(name);
    //    }
    //    //初始化调用——构造函数
    //    public Person(int age)
    //    {
    //        this.age = age;
    //    }
    //    public Person(int age, string name) : this(age)
    //    {
    //        this.name = name;
    //    }
    //    //释放时调用——析构函数
    //    ~Person()
    //    {

    //    }
    //}
    #endregion

    #region 知识点一 成员属性的基本概念
    //基本概念
    //1.用于保护成员变量
    //2.为成员属性的获取和赋值添加逻辑处理
    //3.解决3P的局限性
    //  public——内外访问
    //  private——内部访问
    //  protected——内部和子类访问
    //  属性可以让成员变量在外部
    //  只能获取 不能修改  或者  只能修改 不能获取
    #endregion

    #region 知识点二 成员属性的基本语法
    // 访问修饰符 属性类型 属性名
    // {
    //     get{}
    //     set{}
    // }
    class Person
    {
        private string name;
        private int age;
        private int money;
        private bool sex;

        //属性的命名一般使用 帕斯卡命名法
        public string Name
        {
            get
            {
                //可以在返回之前添加一些逻辑规则 
                //意味着 这个属性可以获取的内容
                return name;
            }
            set
            {
                //可以在设置之前添加一些逻辑规则 
                // value 关键字 用于表示 外部传入的值
                name = value;
            }
        }
        #region 知识点四 成员属性中 get和set前可以加访问修饰符
        // 注意
        // 1.默认不加 会使用属性申明时的访问权限
        // 2.加的访问修饰符要低于属性的访问权限
        // 3.不能让get和set的访问权限都低于属性的权限
        #endregion
        public int Money
        {
            get
            {
                //解密处理
                return money - 5;
            }
            set
            {
                //加密处理
                money = value + 5;
            }
        }

        #region 知识点五 get和set可以只有一个
        //注意：
        //只有一个时  没必要在前面加访问修饰符
        //一般情况下 只会出现 只有 get的情况 基本不会出现只有set
        public bool Sex
        {
            get
            {
                return sex;
            }
            //set
            //{
            //    sex = value;
            //}
        }
        #endregion

        #region 知识点六 自动属性
        //作用：外部能得不能改的特征
        //如果类中有一个特征是只希望外部能得不能改的 又没什么特殊处理
        //那么可以直接使用自动属性
        public float Height
        {
            //没有再get和set中写逻辑的需求或者想法
            get;
            private set;
        }
        #endregion

    }
    #endregion

    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("成员属性");
            #region 知识点三 成员属性的使用
            Person p = new Person();
            p.Name = "唐老狮";
            Console.WriteLine(p.Name);

            p.Money = 1000;
            Console.WriteLine(p.Money);

            //Console.WriteLine(p.Sex);
            //p.Sex = true;
            #endregion
        }
    }
    //总结
    //1.成员属性概念：一般是用来保护成员变量的
    //2.成员属性的使用和变量一样 外部用对象点出
    //3.get中需要return内容 ； set中用value表示传入的内容
    //4.get和set语句块中可以加逻辑处理
    //5.get和set可以加访问修饰符，但是要按照一定的规则进行添加
    //6.get和set可以只有一个
    //7.自动属性是属性语句块中只有get和set，一般用于 外部能得不能改这种情况
}
