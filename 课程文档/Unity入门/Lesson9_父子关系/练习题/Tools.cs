using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public static class Tools
{
    /// <summary>
    /// 这个方法 是我们为Transform写的一个拓展方法
    /// 主要用来把子对象按名字长短排序
    /// </summary>
    /// <param name="obj"></param>
    public static void Sort( this Transform obj)
    {
        //有什么知识点 是和排序相关
        //使用List的排序 比较符合我们的需求
        //我们的思路 就是把子对象 放到一个 list容器中 然后对list进行排序 
        //排序完毕后 遍历list 去设置 这个顺序中的 对象的 子对象位置
        List<Transform> list = new List<Transform>();
        for (int i = 0; i < obj.childCount; i++)
        {
            list.Add(obj.GetChild(i));
        }
        //这是根据 名字长短进行排序 利用的 是list的排序
        list.Sort((a, b) =>
        {
            if (a.name.Length < b.name.Length)
                return -1;
            else
                return 1;
        });
        //根据 list中的排序结果 重新设置每一个对象的 索引编号
        for (int i = 0; i < list.Count; i++)
        {
            list[i].SetSiblingIndex(i);
        }
    }


    /// <summary>
    /// 根据名字找到 子对象 不管藏多深
    /// </summary>
    /// <param name="father">调用方法的对象</param>
    /// <param name="childName">要找的对象名字</param>
    /// <returns></returns>
    public static Transform CustomFind( this Transform father, string childName)
    {
        //如何查找子对象的子对象
        //我要找的对象
        Transform target = null;
        //先从自己身上的子对象找
        target = father.Find(childName);
        if (target != null)
            return target;

        //如果在自己身上没有找到 那就去找自己的子对象的子对象
        for (int i = 0; i < father.childCount; i++)
        {
            //让子对象去帮我找 有没有这个名字的对象
            //递归
            target = father.GetChild(i).CustomFind(childName);
            //找到了 直接返回
            if (target != null)
                return target;
        }

        return target;
    }
}
