using System;

namespace Lesson17_练习题
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("switch练习题");
            #region 练习题一
            //唐老狮的工资是由基本工资 + 绩效决定的
            //绩效说明：
            //学生评价 很兴奋，则评定为A级，绩效工资500
            //学生评价 很充实，则评定为B级，不加绩效工资
            //学生评价 还好吧，则评定为C级，绩效工资扣300
            //学生评价 难理解，则评定为D级，绩效工资扣500
            //学生评价 枯燥泛味，则评定为E级，绩效工资扣800

            //假设唐老狮的工资是4000
            //请用户输入唐老师的评级，并算出唐老师的工资是多少？
            //int money = 4000;
            //Console.WriteLine("请输入对唐老狮的评级");
            //string str = Console.ReadLine();
            //switch (str)
            //{
            //    case "A":
            //        //money = money + 500;
            //        money += 500;
            //        break;
            //    case "B":
            //        break;
            //    case "C":
            //        //money = money - 300;
            //        money -= 300;
            //        break;
            //    case "D":
            //        money -= 500;
            //        break;
            //    case "E":
            //        money -= 800;
            //        break;
            //    default:
            //        Console.WriteLine("请输入 正确的等级");
            //        break;
            //}

            //Console.WriteLine("你对唐老狮的评级为{0},他的最终薪资是{1}", str, money);

            #endregion

            #region 练习题二
            //小唐带了10元钱去星巴克买咖啡，三种型号选择：
            //1 = (中杯，¥5)
            //2 = (大杯，¥7)
            //3 = (超大杯，¥11)
            //请用户输入选择的型号，如果钱够，则购买成功，并算出小王最后还剩多少钱？
            //如果钱不够，则提示用户“钱不够，请换其他型号”
            //int money = 10;
            //Console.WriteLine("请输入你要买的型号（1是中杯，2是大杯，3是超大杯）");
            //string str = Console.ReadLine();
            //switch (str)
            //{
            //    case "1":
            //        money -= 5;
            //        Console.WriteLine("购买成功，还剩{0}元", money);
            //        break;
            //    case "2":
            //        money -= 7;
            //        Console.WriteLine("购买成功，还剩{0}元", money);
            //        break;
            //    case "3":
            //        Console.WriteLine("钱不够，请换其他型号");
            //        break;
            //    default:
            //        Console.WriteLine("请输入正确内容");
            //        break;
            //}

            #endregion

            #region 练习题三
            //输入学生的考试成绩，如果
            //成绩 >= 90：A
            //90 > 成绩 >= 80:B
            //80 > 成绩 >= 70:C
            //70 > 成绩 >= 60:D
            //成绩 < 60:E
            //（使用switch语法完成）
            //最后输出学生的考试等级
            //try
            //{
            //    Console.WriteLine("请输入学生成绩");
            //    int cj = int.Parse(Console.ReadLine());
            //    // 取它的 十位数
            //    // 100 / 10 = 10
            //    // 99 / 10 = 9
            //    // 84 / 10 = 8
            //    // 74 / 10 = 7
            //    // cj = cj / 10;
            //    cj /= 10;
            //    switch (cj)
            //    {
            //        case 10:
            //        case 9:
            //            Console.WriteLine("你的成绩是A");
            //            break;
            //        case 8:
            //            Console.WriteLine("你的成绩是B");
            //            break;
            //        case 7:
            //            Console.WriteLine("你的成绩是C");
            //            break;
            //        case 6:
            //            Console.WriteLine("你的成绩是D");
            //            break;
            //        default:
            //            Console.WriteLine("你的成绩是E");
            //            break;
            //    }
            //}
            //catch
            //{
            //    Console.WriteLine("请输入数字");
            //}

            #endregion

            #region 练习题四
            //在控制台输入一个（0~9）的数并显示为大写。如输入2，则显示二
            try
            {
                Console.WriteLine("请输入0~9之间的数字");
                int num = int.Parse(Console.ReadKey().KeyChar.ToString());
                switch (num)
                {
                    case 0:
                        Console.WriteLine("零");
                        break;
                    case 1:
                        Console.WriteLine("一");
                        break;
                    case 2:
                        Console.WriteLine("二");
                        break;
                    case 3:
                        Console.WriteLine("三");
                        break;
                    case 4:
                        Console.WriteLine("四");
                        break;
                    case 5:
                        Console.WriteLine("五");
                        break;
                    case 6:
                        Console.WriteLine("六");
                        break;
                    case 7:
                        Console.WriteLine("七");
                        break;
                    case 8:
                        Console.WriteLine("八");
                        break;
                    case 9:
                        Console.WriteLine("九");
                        break;
                }
            }
            catch
            {
                Console.WriteLine("请输入正确内容");
            }
            #endregion
        }
    }
}
