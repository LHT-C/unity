using System;

namespace 必备知识点_随机数练习题
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("随机数练习题");
            //唐老狮打小怪兽
            //唐老狮攻击力为8~12之间的一个值
            //小怪兽防御为10，血量为20
            //在控制台中通过打印信息表现唐老狮打小怪兽的过程
            //描述小怪兽的掉血情况
            //伤害计算公式：攻击力小于防御力时，减血为0，否则减血攻击力和防御力的差值

            //知识点：循环、随机数等等

            //先申明 关于对象的属性
            int monsterDef = 10;
            int monsterHp = 20;
            int teacherTangAtk = 0;
            Random r = new Random();

            while (true)
            {
                teacherTangAtk = r.Next(8, 13);
                if( teacherTangAtk > monsterDef )
                {
                    //减血攻击力和防御力的差值
                    //monsterHp = monsterHp - (teacherTangAtk - monsterDef);
                    monsterHp -= teacherTangAtk - monsterDef;
                    Console.WriteLine("唐老狮本次攻击力为{0},造成{1}伤害,怪物剩{2}血", 
                        teacherTangAtk, teacherTangAtk - monsterDef, monsterHp);
                    if( monsterHp <= 0 )
                    {
                        break;
                    }
                }
                else
                {
                    Console.WriteLine("唐老狮本次攻击力为{0},不足以造成伤害", teacherTangAtk);
                }

                Console.WriteLine("请按任意键继续攻击");
                Console.ReadKey(true);
                Console.Clear();
            }

            Console.WriteLine("怪物已死亡");
        }
    }
}
