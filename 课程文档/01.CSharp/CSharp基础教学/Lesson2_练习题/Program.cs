using System;

namespace Lesson2_练习题
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("数组练习题");

            #region 练习题一
            //请创建一个一维数组并赋值，让其值与下标一样，长度为100
            //int[] array = new int[100];
            //for (int i = 0; i < array.Length; i++)
            //{
            //    array[i] = i;
            //    //Console.WriteLine(array[i]);
            //}
            #endregion

            #region 练习题二
            //创建另一个数组B，让数组A中的每个元素的值乘以2存入到数组B中
            //int[] arrayB = new int[100];
            //for (int i = 0; i < arrayB.Length; i++)
            //{
            //    arrayB[i] = array[i] * 2;
            //    Console.WriteLine(arrayB[i]);
            //}
            #endregion

            #region 练习题三
            //随机（0~100）生成1个长度为10的整数数组

            //int[] array = new int[10];
            //Random r = new Random();
            //for (int i = 0; i < array.Length; i++)
            //{
            //    array[i] = r.Next(0, 101);
            //    Console.WriteLine(array[i]);
            //}
            #endregion

            #region 练习题四
            // 从一个整数数组中找出最大值、最小值、总合、平均值
            //（可以使用随机数1~100）
            //int[] array = new int[10];
            //Random r = new Random();
            //for (int i = 0; i < array.Length; i++)
            //{
            //    array[i] = r.Next(0, 101);
            //    Console.WriteLine(array[i]);
            //}
            ////第一次进入时  不存在 最大最小的概念
            ////可以认为 第一次 最大值最小值 都是第一个数
            //int min = array[0];
            //int max = array[0];
            //int sum = 0;
            //int avg = 0;
            //for (int i = 0; i < array.Length; i++)
            //{
            //    //如果当前的值 比min还要小 那么当前的值就是最小的值
            //    if( min > array[i] )
            //    {
            //        min = array[i];
            //    }
            //    //如果当前的值 比max还要大 那么当前的值就是最大的值
            //    if( max < array[i] )
            //    {
            //        max = array[i];
            //    }
            //    //每一次的值加上去 就是总和
            //    sum += array[i];
            //}
            ////平均数 用总合 / 个数
            //avg = sum / array.Length;
            //Console.WriteLine("最小值{0}最大值{1}总合{2}平均数{3}", min, max, sum, avg);


            #endregion

            #region 练习题五
            //交换数组中的第一个和最后一个、第二个和倒数第二个，依次类推，把数组进行反转并打印
            //int[] array = new int[10];
            //Random r = new Random();
            //for (int i = 0; i < array.Length; i++)
            //{
            //    array[i] = r.Next(0, 101);
            //    Console.WriteLine(array[i]);
            //}
            //Console.WriteLine("*****************");
            ////交换 那就中间商不赚差价
            ////int temp = array[0];
            ////array[0] = array[array.Length - 1 - 0];
            ////array[array.Length - 1] = temp;

            ////temp = array[1];
            ////array[1] = array[array.Length - 1 - 1];
            ////array[array.Length - 1 - 1] = temp;

            ////temp = array[2];
            ////array[2] = array[array.Length - 1 - 2];
            ////array[array.Length - 1 - 2] = temp;

            //for (int i = 0; i < array.Length / 2; i++)
            //{
            //    int temp = array[i];
            //    array[i] = array[array.Length - 1 - i];
            //    array[array.Length - 1 - i] = temp;
            //}

            //for (int i = 0; i < array.Length; i++)
            //{
            //    Console.WriteLine(array[i]);
            //}

            #endregion

            #region 练习题六
            //将一个整数数组的每一个元素进行如下的处理：
            //如果元素是正数则将这个位置的元素值加1；
            //如果元素是负数则将这个位置的元素值减1；
            //如果元素是0，则不变
            //int[] array = new int[10];
            //Random r = new Random();
            //for (int i = 0; i < array.Length; i++)
            //{
            //    array[i] = r.Next(-10, 11);
            //    Console.WriteLine(array[i]);
            //}
            //Console.WriteLine("*******************");
            //for (int i = 0; i < array.Length; i++)
            //{
            //    //得到每一个元素 进行判断即可
            //    if( array[i] > 0 )
            //    {
            //        array[i] += 1;
            //    }
            //    else if( array[i] < 0 )
            //    {
            //        array[i] -= 1;
            //    }

            //    Console.WriteLine(array[i]);
            //}


            #endregion

            #region 练习题七
            //定义一个有10个元素的数组，使用for循环，输入10名同学的数学成绩，
            //将成绩依次存入数组，然后分别求出最高分和最低分，
            //并且求出10名同学的数学平均成绩
            //int[] array = new int[10];

            //try
            //{
            //    int min = 0;
            //    int max = 0;
            //    int sum = 0;
            //    int avg = 0;
            //    for (int i = 0; i < array.Length; i++)
            //    {
            //        Console.WriteLine("请输入第{0}位同学的成绩", i + 1);
            //        array[i] = int.Parse(Console.ReadLine());
            //        //第一次进来 min max 没有任何意义 所以第一次可以就认为该成绩即使 最高分也是最低分
            //        if( i == 0 )
            //        {
            //            min = array[i];
            //            max = array[i];
            //        }
            //        else
            //        {
            //            //只有 除了第一次以外  才来进行 大小值的判断 
            //            if (min > array[i])
            //            {
            //                min = array[i];
            //            }
            //            if (max < array[i])
            //            {
            //                max = array[i];
            //            }
            //        }
            //        sum += array[i];
            //    }
            //    avg = sum / array.Length;

            //    Console.WriteLine("最高分{0}最低分{1}平均分{2}", max, min, avg);
            //}
            //catch
            //{
            //    Console.WriteLine("请输入数字");
            //}
            #endregion

            #region 练习题八
            //请声明一个string类型的数组(长度为25)（该数组中存储着符号），
            //通过遍历数组的方式取出其中存储的符号打印出以下效果
            string[] strs = new string[25];
            for (int i = 0; i < strs.Length; i++)
            {
                strs[i] = i % 2 == 0 ? "■" : "□";
                //if( i % 2 == 0 )
                //{
                //    strs[i] = "■";
                //}
                //else
                //{
                //    strs[i] = "□";
                //}
            }

            for (int i = 0; i < strs.Length; i++)
            {
                if (i % 5 == 0 && i != 0)
                {
                    Console.WriteLine();
                }
                Console.Write(strs[i]);
            }

            #endregion
        }
    }
}
