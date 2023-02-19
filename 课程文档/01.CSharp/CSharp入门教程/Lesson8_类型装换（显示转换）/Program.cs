using System;

namespace Lesson8_类型装换_显示转换_
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("类型装换——显示转换");

            //显示转换——>手动处理 强制转换 

            #region 知识点一 括号强转
            // 作用 一般情况下 将高精度的类型强制转换为低精度
            // 语法： 变量类型 变量名 = (变量类型)变量;
            // 注意： 精度问题 范围问题

            //相同大类的整形
            //有符号整形
            sbyte sb = 1;
            short s = 1;
            int i = 40000;
            long l = 1;

            //括号强转 可能会出现范围问题 造成的异常
            s = (short)i;
            Console.WriteLine(s);

            i = (int)l;
            sb = (sbyte)s;
            sb = (sbyte)i;
            sb = (sbyte)l;

            //无符号整形 
            byte b = 1;
            uint ui = 1;
            b = (byte)ui;

            //浮点之间
            float f = 1.1f;
            double d = 1.1234567890123456789f;

            f = (float)d;
            Console.WriteLine(f);


            //无符号和有符号
            uint ui2 = 1;
            int i2 = -1;
            //在强壮时 一定要注意范围 不然得到的结果 可能有异常
            ui2 = (uint)i2;
            Console.WriteLine(ui2);

            i2 = (int)ui2;

            //浮点和整形  浮点数强转成整形时 会直接抛弃掉小数点后面的小数 
            i2 = (int)1.64f;
            Console.WriteLine(i2);

            //char和数值类型
            i2 = 'A';

            char c = (char)i2;
            Console.WriteLine(c);

            //bool和string 是不能够通过 括号强转的

            //bool bo = true;
            //int i3 = (bool)bo;

            //string str = "123";
            //i3 = (int)str;

            #endregion

            #region 知识点二 Parse法
            //作用  把字符串类型转换为对应的类型
            //语法： 变量类型.Parse("字符串")
            //注意： 字符串必须能够转换成对应类型 否则报错

            //有符号
            //string str2 = "123";
            int i4 = int.Parse("123");
            Console.WriteLine(i4);
            // 我们填写字符串 必须是要能够转成对应类型的字符 如果不符合规则 会报错
            //i4 = int.Parse("123.45");
            //Console.WriteLine(i4);
            // 值的范围 必须是能够被变量存储的值 否则报错
            //short s3 = short.Parse("40000");
            //Console.WriteLine(s3);

            sbyte sb3 = sbyte.Parse("1");
            Console.WriteLine(sb3);
            //他们的意思是相同的 
            Console.WriteLine(sbyte.Parse("1"));
            Console.WriteLine(long.Parse("123123"));

            //无符号
            Console.WriteLine(byte.Parse("1"));
            Console.WriteLine(ushort.Parse("1"));
            Console.WriteLine(ulong.Parse("1"));
            Console.WriteLine(uint.Parse("1"));

            //浮点数
            float f3 = float.Parse("1.2323");
            double d3 = double.Parse("1.2323");

            //特殊类型
            bool b5 = bool.Parse("true");
            Console.WriteLine(b5);

            char c2 = char.Parse("A");
            Console.WriteLine(c2);

            #endregion

            #region 知识点三 Convert法
            //作用  更准确的将 各个类型之间进行相互转换 
            //语法： Convert.To目标类型(变量或常量)
            //注意： 填写的变量或常量必须正确 否则出错

            //转字符串 如果是把字符串转对应类型 那字符串一定要合法合规
            int a = Convert.ToInt32("12");
            Console.WriteLine(a);

            //精度更准确
            // 精度比括号强转好一点 会四舍五入
            a = Convert.ToInt32(1.45845f);
            Console.WriteLine(a);

            //特殊类型转换
            //把bool类型也可以转成 数值类型 true对应1 false对应0
            a = Convert.ToInt32(true);
            Console.WriteLine(a);
            a = Convert.ToInt32(false);
            Console.WriteLine(a);

            a = Convert.ToInt32('A');
            Console.WriteLine(a);

            //每一个类型都存在对应的 Convert中的方法
            sbyte sb5 = Convert.ToSByte("1");
            short s5 = Convert.ToInt16("1");
            int i5 = Convert.ToInt32("1");
            long l5 = Convert.ToInt64("1");

            byte b6 = Convert.ToByte("1");
            ushort us5 = Convert.ToUInt16("1");
            uint ui5 = Convert.ToUInt32("1");
            ulong ul5 = Convert.ToUInt64("1");

            float f5 = Convert.ToSingle("13.2");
            double d5 = Convert.ToDouble("13.2");
            decimal de5 = Convert.ToDecimal("13.2");

            bool bo5 = Convert.ToBoolean("true");
            char c5 = Convert.ToChar("A");

            string str5 = Convert.ToString(123123);

            #endregion

            #region 知识点四 其它类型转string
            // 作用：拼接打印
            // 语法：变量.toString();

            string str6 = 1.ToString();
            str6 = true.ToString();
            str6 = 'A'.ToString();
            str6 = 1.2f.ToString();

            int aa = 1;
            str6 = aa.ToString();
            bool bo6 = true;
            str6 = bo6.ToString();

            //当我们进行字符串拼接时 就自动会调用 tostring 转成string
            Console.WriteLine("123123" + 1 + true);

            str6 = "123123" + 1 + true + 1.23;

            #endregion
        }
    }
}
