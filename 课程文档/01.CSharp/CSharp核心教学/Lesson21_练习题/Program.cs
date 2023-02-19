using System;
using UI;
using Graph;

#region 练习题一
//请说明关键词using有什么作用
//using是用来引用命名空间
#endregion

#region 练习题二
//有两个命名空间，UI(用户界面)和Graph（图表）
//两个命名空间中都有一个Image类
//请在主函数中实例化两个不同命名空间中的Image对象
namespace UI
{
    class Image
    {

    }
}

namespace Graph
{
    class Image
    {

    }
}

#endregion

namespace Lesson21_练习题
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("命名空间练习题");

            UI.Image uiImg = new UI.Image();
            Graph.Image grImg = new Graph.Image();
        }
    }
}
