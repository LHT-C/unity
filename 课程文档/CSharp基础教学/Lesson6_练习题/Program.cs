using System;

namespace Lesson6_练习题
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("引用类型练习题");

            int[] a = new int[] { 10 };
            int[] b = a;
            b = new int[5];
            Console.WriteLine(a[0]);
        }
    }
}
