using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerInfo
{
    public int age = 10;
    public string name = "未命名";
    public float height = 177.5f;
    public bool sex = true;

    public List<int> list = new List<int>() { 1, 2, 3, 4 };
}

public class Test : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        PlayerInfo p = new PlayerInfo();
        //需要把这个数据对象的信息 存储到硬盘
        PlayerPrefsDataMgr.Instance.SaveData(p, "Player1");
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
