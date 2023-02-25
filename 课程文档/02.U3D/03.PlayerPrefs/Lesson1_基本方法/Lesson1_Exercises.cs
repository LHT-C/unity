using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Item
{
    public int id;
    public int num;
}

public class Player
{
    public string name;
    public int age;
    public int atk;
    public int def;
    //拥有的装备信息
    public List<Item> itemList;

    //这个变量 是一个 存储和读取的一个唯一key标识
    private string keyName;

    /// <summary>
    /// 存储数据
    /// </summary>
    public void Save()
    {
        PlayerPrefs.SetString(keyName +"_name", name);
        PlayerPrefs.SetInt(keyName + "_age", age);
        PlayerPrefs.SetInt(keyName + "_atk", atk);
        PlayerPrefs.SetInt(keyName + "_def", def);
        //存储有多少个装备
        PlayerPrefs.SetInt(keyName + "_ItemNum", itemList.Count);
        for (int i = 0; i < itemList.Count; i++)
        {
            //存储每一个装备的信息
            PlayerPrefs.SetInt(keyName + "_itemID" + i, itemList[i].id);
            PlayerPrefs.SetInt(keyName + "_itemNum" + i, itemList[i].num);
        }

        PlayerPrefs.Save();
    }
    /// <summary>
    /// 读取数据
    /// </summary>
    public void Load(string keyName)
    {
        //记录你传入的标识
        this.keyName = keyName;

        name = PlayerPrefs.GetString(keyName + "_name", "未命名");
        age = PlayerPrefs.GetInt(keyName + "_age", 18);
        atk = PlayerPrefs.GetInt(keyName + "_atk", 10);
        def = PlayerPrefs.GetInt(keyName + "_def", 5);

        //得到有多少个装备
        int num = PlayerPrefs.GetInt(keyName + "_ItemNum", 0);
        //初始化容器
        itemList = new List<Item>();
        Item item;
        for (int i = 0; i < num; i++)
        {
            item = new Item();
            item.id = PlayerPrefs.GetInt(keyName + "_itemID" + i);
            item.num = PlayerPrefs.GetInt(keyName + "_itemNum" + i);
            itemList.Add(item);
        }
    }
}

public class Lesson1_Exercises : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        #region 练习题一
        //现在有玩家信息类，有名字，年龄，攻击力，防御力等成员
        //现在为其封装两个方法，一个用来存储数据，一个用来读取数据

        //Player p = new Player();
        //p.Load();
        //print(p.name);
        //print(p.age);
        //print(p.atk);
        //print(p.def);

        //p.name = "唐老狮";
        //p.age = 22;
        //p.atk = 40;
        //p.def = 10;
        ////改了过后存储
        //p.Save();
        #endregion

        #region 练习题二
        //现在有装备信息类，装备类中有id，数量两个成员。
        //上一题的玩家类中包含一个List存储了拥有的所有装备信息。
        //请在上一题的基础上，把装备信息的存储和读取加上

        Player p = new Player();
        p.Load("Player1");
        p.Save();

        Player p2 = new Player();
        p2.Load("Player2");
        p.Save();
        //装备信息
        //print(p.itemList.Count);
        //for (int i = 0; i < p.itemList.Count; i++)
        //{
        //    print("道具ID：" + p.itemList[i].id);
        //    print("道具数量：" + p.itemList[i].num);
        //}

        ////为玩家添加一个装备
        //Item item = new Item();
        //item.id = 1;
        //item.num = 1;
        //p.itemList.Add(item);
        //item = new Item();
        //item.id = 2;
        //item.num = 2;
        //p.itemList.Add(item);


        #endregion
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
