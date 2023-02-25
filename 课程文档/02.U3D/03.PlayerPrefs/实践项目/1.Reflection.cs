using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Father
{

}

public class Son
{

}

public class Reflection : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        #region 知识点一 反射知识回顾
        //反射3剑客—— 1T 两 A
        //Type —— 用于获取 类的所有信息 字段 属性 方法 等等
        //Assembly —— 用于获取程序集 通过程序集获取Type
        //Activator —— 用于快速实例化对象
        #endregion

        #region 知识点二 判断一个类型的对象是否可以让另一个类型为自己分配空间
        //父类装子类
        //是否可以从某一个类型的对象 为自己 分配 空间

        Type fatherType = typeof(Father);
        Type sonType = typeof(Son);

        //调用者 通过该方法进行判断 判断是否可以通过传入的类型为自己 分配空间
        if( fatherType.IsAssignableFrom(sonType) )
        {
            print("可以装");
            Father f = Activator.CreateInstance(sonType) as Father;
            print(f);
        }
        else
        {
            print("不能装");
        }
        #endregion

        #region 知识点三 通过反射获取泛型类型
        List<int> list = new List<int>();
        Type listType = list.GetType();

        Type[] types = listType.GetGenericArguments();
        print(types[0]);

        Dictionary<string, float> dic = new Dictionary<string, float>();
        Type dicType = dic.GetType();
        types = dicType.GetGenericArguments();
        print(types[0]);
        print(types[1]);
        #endregion
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
