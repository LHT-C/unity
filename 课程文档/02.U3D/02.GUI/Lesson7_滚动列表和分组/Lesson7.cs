using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Lesson7 : MonoBehaviour
{
    public Rect groupPos;


    public Rect scPos;
    public Rect showPos;

    private Vector2 nowPos;

    private string[] strs = new string[] { "123", "234", "222", "111" };
    private void OnGUI()
    {
        #region 知识点一 分组
        // 用于批量控制控件位置 
        // 可以理解为 包裹着的控件加了一个父对象 
        // 可以通过控制分组来控制包裹控件的位置
        GUI.BeginGroup(groupPos);

        GUI.Button(new Rect(0, 0, 100, 50), "测试按钮");
        GUI.Label(new Rect(0, 60, 100, 20), "Label信息");

        GUI.EndGroup();

        #endregion

        
        #region 知识点二 滚动列表
        nowPos = GUI.BeginScrollView(scPos, nowPos, showPos);

        GUI.Toolbar(new Rect(0, 0, 300, 50), 0, strs);
        GUI.Toolbar(new Rect(0, 60, 300, 50), 0, strs);
        GUI.Toolbar(new Rect(0, 120, 300, 50), 0, strs);
        GUI.Toolbar(new Rect(0, 180, 300, 50), 0, strs);

        GUI.EndScrollView();
        #endregion
    }
}
