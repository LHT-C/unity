using System;

namespace Lesson18_练习题
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("while循环练习题");
            #region 练习题一
            //在控制台输出1到100
            //int i = 0;
            //while( i < 100 )
            //{
            //    ++i;
            //    Console.WriteLine(i);
            //}
            #endregion

            #region 练习题二
            //在控制台输出1到100之间所有整数的和
            //int i = 0;
            ////用于表示最终结果的 变量 一定在外面申明
            //int sum = 0;
            //while ( i < 100)
            //{
            //    ++i;
            //    //每次加完这个i 就得把它加起来
            //    //sum = sum + i;
            //    sum += i;
            //}
            //Console.WriteLine(sum);
            #endregion

            #region 练习题三
            ////用while和continue实现计算1到100（包含）之间的除了能被7整除之外所有整数的和
            //int i = 0;
            //int sum = 0;
            //while(i < 100)
            //{
            //    ++i;
            //    //只要能被 7 整除 就不执行后面的累加
            //    if( i % 7 == 0 )
            //    {
            //        Console.WriteLine(i);
            //        continue;
            //    }
            //    sum += i;
            //}
            //Console.WriteLine(sum);
            #endregion

            #region 练习题四
            //提示用户输入一个数，判断该数是否是素数并打印。
            //（素数 / 质数：只能被1和这个数字本身整除的数字，1不是质数，最小的质数是2）
            //while (true)
            //{
            //    try
            //    {
            //        Console.WriteLine("请输入一个数字");
            //        int num = int.Parse(Console.ReadLine());

            //        int index = 2;
            //        while (index < num)
            //        {
            //            //有了这个数 做一些操作判断
            //            //num = 5
            //            //index = 4
            //            if (num % index == 0)
            //            {
            //                break;
            //            }
            //            ++index;
            //            // 5
            //        }
            //        if (index != num)
            //        {
            //            Console.WriteLine("不是一个质数");
            //        }
            //        else
            //        {
            //            Console.WriteLine("是质数");
            //        }
            //        // 5
            //        // 5 % 2 能不能整除 不能
            //        // 5 % 3 能不能整除 不能
            //        // 5 % 4 能不能整除 不能
            //        // 5 % 5 能 质数

            //        // 6
            //        // 6 % 2 能 不是质数
            //    }
            //    catch
            //    {
            //        Console.WriteLine("请正确输入");
            //    }
            //}
            #endregion

            #region 练习题五
            //要求输入用户名和密码（admin/8888），用户名或者密码错误，
            //则提示“用户名或密码错误”，直到输入正确为止
            //while(true)
            //{
            //    Console.WriteLine("请输入用户名");
            //    string userName = Console.ReadLine();
            //    Console.WriteLine("请输入密码");
            //    string passWord = Console.ReadLine();
            //    if (userName == "admin" && passWord == "8888")
            //    {
            //        Console.WriteLine("登录成功");
            //        break;
            //    }
            //    else
            //    {
            //        Console.WriteLine("用户名或密码错误");
            //    }
            //}

            #endregion

            #region 练习题六
            //输入班级人数，然后依次输入学员成绩（需提示当前是第几个学员），
            //计算班级学员的平均成绩和总成绩。
            //try
            //{
            //    Console.WriteLine("请输入班级人数");
            //    int num = int.Parse(Console.ReadLine());
            //    //表示输入到第几次 第几个人
            //    int index = 0;
            //    int sum = 0;
            //    while(index < num)
            //    {
            //        ++index;
            //        Console.WriteLine("请输入第{0}个学员的成绩", index);
            //        //得到输入的成绩
            //        int cj = int.Parse(Console.ReadLine());
            //        //计算总成绩 每次 加上输入的分数 
            //        sum += cj;
            //    }
            //    //计算平均成绩 打印他们
            //    Console.WriteLine("平均成绩是{0},总分是{1}", sum / num, sum);
            //}
            //catch
            //{
            //    Console.WriteLine("请输入数字");
            //}
            #endregion

            #region 练习题七
            //定义一个整形变量sum，然后分别把1~100之间的数字依次累加到sum中，
            //当sum的值大于500的时候，中断操作，并在控制台输出累加到第几个数字就可以使sum大于500
            //int sum = 0;
            //int index = 0;
            //while( index < 100 )
            //{
            //    ++index;
            //    sum += index;
            //    if( sum > 500 )
            //    {
            //        break;
            //    }
            //}
            //Console.WriteLine("sum大于500时是第{0}个数", index);
            #endregion

            #region 练习题八
            //假设看唐老狮视频的同学有100人，每个月增长20 %，
            //请问按此速度增长，经历多少个月看唐老狮视频的同学能达到1000人？
            // 100   
            // 1   100 * 20% + 100 = 120
            // 2   120 * 20% + 120 = 144
            // 3   144 * 20% + 144 = 结果
            //     上一次结果 * 20% + 上一次的结果 = 本月结果
            //int persons = 100;
            //int month = 0;
            //while(true)
            //{
            //    //本月结果 = 上一次结果 * 20% + 上一次的结果
            //    //persons = persons + (int)(persons * 0.2f);
            //    persons += (int)(persons * 0.2f);
            //    ++month;
            //    if(persons >= 1000)
            //    {
            //        break;
            //    }
            //}
            //Console.WriteLine("经历了{0}个月，观看视频的人数能达到1000", month);

            #endregion

            #region 练习题九
            //求数列 1,1,2,3,5,8,13....的第20位数字是多少？
            //斐波那契数列  从第三个数开始 每个数的值等于前两个数相加
            // 2 = 1 + 1
            // 3 = 2 + 1;
            // 5 = 3 + 2;
            // 1 1 2 3 5 8 13 21 34 55 89 144 233 377 610 987 1597 2584 4181 6765

            //int n1 = 1;
            //int n2 = 1;
            //// 构造一个 可以数20次数的一个流程
            //int index = 0;
            //int result = 0;
            //while(index < 20)
            //{
            //    ++index;
            //    if( index == 1 )
            //    {
            //        result = n1;
            //    }
            //    else if( index == 2 )
            //    {
            //        result = n2;
            //    }
            //    else
            //    {
            //        //从第三个数以后 都是用前两个数相加得到结果
            //        // 2 = 1 + 1;
            //        //目前算的第三个数
            //        result = n1 + n2;
            //        //接下来要算第四个数
            //        n1 = n2;
            //        n2 = result;
            //    }
            //}
            //Console.WriteLine(result);

            #endregion

            #region 练习题十
            //找出100内所有素数并打印。
            int num = 2;
            while( num < 100 )
            {
                // 用想要判断是素数的数  从2开始 去取余 如果 中途就整除了 证明不是素数
                // 如果 累加到和自己一样的数了 证明是素数
                int i = 2;
                while( i < num )
                {
                    //判断是否整除
                    if( num % i == 0 )
                    {
                        break;
                    }
                    ++i;
                }
                if( i == num )
                {
                    Console.WriteLine(num);
                }
                ++num;
            }
            #endregion
        }
    }
}
