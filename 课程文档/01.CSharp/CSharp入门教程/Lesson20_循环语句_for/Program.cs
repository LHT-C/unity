using System;

namespace Lesson20_循环语句_for
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("for循环");

            #region 知识点一 基本语法
            //for( /*初始表达式*/; /*条件表达式*/; /*增量表达式*/ )
            //{
            //    //循环代码逻辑;
            //}
            // 第一个空（初始表达式）： 一般声明一个临时变量，用来计数用
            // 第二个空（条件表达式）： 表明进入循环的条件 一个bool类型的结果（bool变量 条件运算符 逻辑运算符 算术运算符）
            // 第三个空（增量表达式）： 用第一个空中的变量 进行 自增减运算
            
            // 第一次进入循环时 才会调用 第一个空中的代码
            // 每次进入循环之前 都会判断第二个空中的条件 满足才会进入循环逻辑
            for( int i = 0; i < 10; i++ )
            {
                Console.WriteLine(i);
                //执行完循环语句块中的逻辑后
                //最后执行第三个空中的代码
            }

            for( int i = 10; i >= 0; i-- )
            {
                Console.WriteLine(i);
            }

            //每个空位 可以按照规则进行书写
            //第一个空位 就是申明变量  所以可以连续申明
            //第二个空位 就是进入条件 只要是bool结果的表达式 都可以
            //第三个空位 就是执行一次循环逻辑过后要做的事情 做啥都行
            //for( int i = 0, j = 0; i < 10 && j < 0; ++i, j = j + 1)
            //{

            //}

            #endregion

            #region 知识点二 支持嵌套
            //for( int i = 0; i < 10; i++ )
            //{
            //    for( int j = 0; j < 10; j++)
            //    {
            //        Console.WriteLine(i + "_" + j);
            //    }
            //    while(true)
            //    {

            //    }
            //    if(true)
            //    {

            //    }
            //    do
            //    {

            //    } while (true);
            //}

            #endregion

            #region 知识点三 特殊写法
            //for循环 这三个空位 可以都空着 可以根据需求去填写

            // for循环可以写死循环
            //for( ; ; )
            //{
            //    Console.WriteLine("for循环的死循环");
            //}

            //int k = 0;
            //for(; k < 10; )
            //{
                
                
            //    ++k;//k++, k += 1;
            //}

            //for( k = 0; ; ++k )
            //{
            //    if( k >= 10 )
            //    {
            //        break;
            //    }
            //}

            #endregion

            #region 知识点四 对比while循环
            //for循环 一般用来可以准确得到 一个范围中的所有数
            for( int i = 0; i < 10; ++i )
            {

            }

            int j = 0;
            while(j < 10)
            {
                //......................
                ++j;
            }

            #endregion
        }
    }
}
