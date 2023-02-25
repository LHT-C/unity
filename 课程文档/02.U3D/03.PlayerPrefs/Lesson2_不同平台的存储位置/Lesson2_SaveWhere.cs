using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Lesson2_SaveWhere : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        #region 知识点一 PlayerPrefs存储的数据存在哪里？
        //不同平台存储位置不一样

        #region Windows
        //PlayerPrefs 存储在 
        //HKCU\Software\[公司名称]\[产品名称] 项下的注册表中
        //其中公司和产品名称是 在“Project Settings”中设置的名称。

        //运行 regedit
        //HKEY_CURRENT_USER
        //SOFTWARE
        //Unity
        //UnityEditor
        //公司名称
        //产品名称
        #endregion

        #region Android
        // /data/data/包名/shared_prefs/pkg-name.xml 
        #endregion

        #region IOS
        // /Library/Preferences/[应用ID].plist
        #endregion

        #endregion

        #region 知识点二 PlayerPrefs数据唯一性
        //PlayerPrefs中不同数据的唯一性
        //是由key决定的，不同的key决定了不同的数据
        //同一项目中 如果不同数据key相同 会造成数据丢失
        //要保证数据不丢失就要建立一个保证key唯一的规则
        #endregion
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
