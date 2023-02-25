using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// PlayerPrefs数据管理类 统一管理数据的存储和读取
/// </summary>
public class PlayerPrefsDataMgr
{
    private static PlayerPrefsDataMgr instance = new PlayerPrefsDataMgr();

    public static PlayerPrefsDataMgr Instance
    {
        get
        {
            return instance;
        }
    }

    private PlayerPrefsDataMgr()
    {

    }


    /// <summary>
    /// 存储数据
    /// </summary>
    /// <param name="data">数据对象</param>
    /// <param name="keyName">数据对象的唯一key 自己控制</param>
    public void SaveData( object data, string keyName )
    {
        //就是要通过 Type 得到传入数据对象的所有的 字段
        //然后结合 PlayerPrefs来进行存储
    }

    /// <summary>
    /// 读取数据
    /// </summary>
    /// <param name="type">想要读取数据的 数据类型Type</param>
    /// <param name="keyName">数据对象的唯一key 自己控制</param>
    /// <returns></returns>
    public object LoadData( Type type, string keyName )
    {
        //不用object对象传入 而使用 Type传入
        //主要目的是节约一行代码（在外部）
        //假设现在你要 读取一个Player类型的数据 如果是object 你就必须在外部new一个对象传入
        //现在有Type的 你只用传入 一个Type typeof(Player) 然后我在内部动态创建一个对象给你返回出来
        //达到了 让你在外部 少写一行代码的作用

        //根据你传入的类型 和 keyName
        //依据你存储数据时  key的拼接规则 来进行数据的获取赋值 返回出去

        return null;
    }
}
