using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Lesson9 : MonoBehaviour
{
    public GUIStyle style;

    public GUISkin skin;
    private void OnGUI()
    {
        #region 知识点一 全局颜色
        //全局的着色颜色 影响背景和文本颜色
        //GUI.color = Color.red;

        //文本着色颜色 会和 全局颜色相乘
        //GUI.contentColor = Color.yellow;
        //GUI.Button(new Rect(0, 0, 100, 30), "测试按钮");
        
        ////背景元素着色颜色 会和 全局颜色相乘
        //GUI.backgroundColor = Color.red;
        //GUI.Label(new Rect(0, 50, 100, 30), "测试按钮");
        //GUI.color = Color.white;
        //GUI.Button(new Rect(0, 100, 100, 30), "测试按钮", style);

        #endregion

        #region 知识点二 整体皮肤样式
        GUI.skin = skin;
        //虽然设置了皮肤 但是绘制时 如果使用GUIStyle参数 皮肤就没有
        GUI.Button(new Rect(0, 0, 100, 30), "测试按钮");

        GUI.skin = null;
        GUI.Button(new Rect(0, 50, 100, 30), "测试按钮2");

        //它可以帮助我们整套的设置 自定义样式 
        //相对单个控件设置Style要方便一些
        #endregion
    }
}
