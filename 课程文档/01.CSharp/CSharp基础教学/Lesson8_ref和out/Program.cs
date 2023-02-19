using System;

namespace Lesson8_ref和out
{
    class Program
    {
        #region 知识点一 学习ref和out的原因
        //学习ref和out的原因
        //它们可以解决 在函数内部改变外部传入的内容 里面变了 外面也要变

        static void ChangeValue(int value)
        {
            value = 3;
        }

        static void ChangeArrayValue(int[] arr)
        {
            arr[0] = 99;
        }

        static void ChangeArray(int[] arr)
        {
            //重新申明了一个 数组
            arr = new int[] { 10, 20, 30 };
        }

        #endregion

        #region 知识点二 ref和out的使用
        //函数参数的修饰符
        //当传入的值类型参数在内部修改时 或者引用类型参数在内部重新申明时
        //外部的值会发生变化

        //ref
        static void ChangeValueRef(ref int value)
        {
            //out传入的变量必须在内部赋值 ref不用
            value = 3;
        }

        static void ChangeArrayRef( ref int[] arr )
        {
            arr = new int[] { 100, 200, 300 };
        }

        //out
        static void ChangeValueOut(out int value)
        {
            //out传入的变量必须在内部赋值 ref不用
            value = 99;
        }

        static void ChangeArrayOut(out int[] arr)
        {
            arr = new int[] { 999, 888, 777 };
        }

        #endregion

        #region 知识点三 ref和out的区别
        //1.ref传入的变量必须初始化  out不用
        //2.out传入的变量必须在内部赋值  ref不用

        // ref传入的变量必须初始化 但是在内部 可改可不改
        // out传入的变量不用初始化 但是在内部 必须修改该值（必须赋值）
        #endregion


        //总结
        //1.ref和out的作用 ： 解决值类型和引用类型 在函数内部 改值 或者 重新申明 能够影响外部传入的变量 让其也被修改
        //2.使用上：就是在申明参数的时候 前面加上 ref和out的 关键字即可 使用时 同上
        //3.区别
        // ref传入的变量必须初始化 但是在内部 可改可不改
        // out传入的变量不用初始化 但是在内部 必须修改该值（必须赋值）

        static void Main(string[] args)
        {
            Console.WriteLine("ref和out");
            //1.ref传入的变量必须初始化  out不用
            int a = 1;
            ChangeValueRef(ref a);
            ChangeValueOut(out a);


            //int a = 1;
            //ChangeValue(a);
            //Console.WriteLine(a);

            //ChangeValueRef(ref a);
            //Console.WriteLine(a);

            //ChangeValueOut(out a);
            //Console.WriteLine(a);

            //Console.WriteLine("***********");
            //int[] arr2 = { 1, 2, 3 };
            //ChangeArrayValue(arr2);
            //Console.WriteLine(arr2[0]);//99
            //Console.WriteLine("***********");
            //ChangeArray(arr2);
            //Console.WriteLine(arr2[0]);

            //ChangeArrayRef(ref arr2);
            //Console.WriteLine(arr2[0]);

            //ChangeArrayOut(out arr2);
            //Console.WriteLine(arr2[0]);
        }
    }
}
