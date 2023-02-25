using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// 排行榜具体信息
/// </summary>
public class RankListInfo
{
    public List<RankInfo> rankList;

    public RankListInfo()
    {
        Load();
    }

    /// <summary>
    /// 新加排行榜信息
    /// </summary>
    public void Add(string name , int score, int time)
    {
        rankList.Add(new RankInfo(name, score, time));
    }

    public void Save()
    {
        //存储有多少条数据
        PlayerPrefs.SetInt("rankListNum", rankList.Count);
        for (int i = 0; i < rankList.Count; i++)
        {
            RankInfo info = rankList[i];
            PlayerPrefs.SetString("rankInfo" + i, info.playerName);
            PlayerPrefs.SetInt("rankScore" + i, info.playerScore);
            PlayerPrefs.SetInt("rankTime" + i, info.playerTime);
        }
    }

    private void Load()
    {
        int num = PlayerPrefs.GetInt("rankListNum", 0);
        rankList = new List<RankInfo>();
        for (int i = 0; i < num; i++)
        {
            RankInfo info = new RankInfo(PlayerPrefs.GetString("rankInfo" + i),
                                          PlayerPrefs.GetInt("rankScore" + i),
                                          PlayerPrefs.GetInt("rankTime" + i));
            rankList.Add(info);
        }
    }
}

/// <summary>
/// 排行榜单条信息
/// </summary>
public class RankInfo
{
    public string playerName;
    public int playerScore;
    public int playerTime;

    public RankInfo(string name, int score, int time)
    {
        playerName = name;
        playerScore = score;
        playerTime = time;
    }
}

public class Lesson2_Exercises : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        #region 练习题一 
        //将知识点一中的练习题，改为可以支持存储多个玩家信息
        #endregion

        #region 练习题二
        //要在游戏中做一个排行榜功能
        //排行榜主要记录玩家名（可重复）,玩家得分，玩家通关时间
        //请用PlayerPrefs存储读取排行榜相关信息

        RankListInfo rankList = new RankListInfo();
        print(rankList.rankList.Count);
        for (int i = 0; i < rankList.rankList.Count; i++)
        {
            print("姓名" + rankList.rankList[i].playerName);
            print("分数" + rankList.rankList[i].playerScore);
            print("时间" + rankList.rankList[i].playerTime);
        }

        rankList.Add("唐老狮", 100, 99);
        rankList.Save();
        #endregion
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
