using System;

namespace Lesson8_练习题
{
    class Program
    {
        #region 练习题一 
        //请简要描述ref和out的区别
        // ref的使用 传入的参数 必须要进行初始化  out不用
        // out的使用 在内部必须给传入的参数 赋值  ref不用
        #endregion

        #region 练习题二
        //让用户输入用户名和密码，返回给用户一个bool类型的登陆结果，并且还要单独的返回给用户一个登陆信息。
        //如果用户名错误，除了返回登陆结果之外，登陆信息为“用户名错误”
        //如果密码错误，除了返回登陆结果之外，登陆信息为“密码错误”

        static bool CheckLogin(string name, string passWord, ref string info)
        {
            //判断用户名是否正确
            if( name == "admin"  )
            {
                //正确了做什么
                //判断用户名 是否正确
                if( passWord == "8888" )
                {
                    //正确了做什么
                    info = "登录成功";
                }
                else
                {
                    //不正确做什么
                    info = "密码错误";
                    return false;
                }
            }
            //不正确 做什么
            else
            {
                info = "用户名错误";
                return false;
            }
            return true;
        }

        #endregion

        static void Main(string[] args)
        {
            Console.WriteLine("ref和out练习题");

            Console.WriteLine("请输入用户名");
            string name = Console.ReadLine();
            Console.WriteLine("请输入密码");
            string passWord = Console.ReadLine();
            string info = "";

            while( !CheckLogin(name, passWord, ref info))
            {
                Console.WriteLine(info);
                Console.WriteLine("请输入用户名");
                name = Console.ReadLine();
                Console.WriteLine("请输入密码");
                passWord = Console.ReadLine();
            }            
            Console.WriteLine(info);
        }
    }
}
