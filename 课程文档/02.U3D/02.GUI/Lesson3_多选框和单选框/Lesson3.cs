using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Lesson3 : MonoBehaviour
{
    private bool isSel;
    private bool isSel2;

    public GUIStyle style;

    private int nowSelIndex = 1;
    private void OnGUI()
    {
        #region 知识点一 多选框
        #region 普通样式
        isSel = GUI.Toggle(new Rect(0, 0, 100, 30), isSel, "效果开关");
        #endregion

        #region 自定义样式 显示问题
        //修改固定宽高 fixedWidth和fixedHeight
        //修改从GUIStyle边缘到内容起始处的空间 padding

        isSel2 = GUI.Toggle(new Rect(0, 40, 100, 30), isSel2, "音效开关", style);
        #endregion
        #endregion

        #region 知识点二 单选框
        //单选框是基于 多选框的实现
        //关键：通过一个int标识来决定是否选中 
        if(GUI.Toggle(new Rect(0, 100, 100, 30), nowSelIndex == 1, "选项一"))
        {
            nowSelIndex = 1;
        }
        if(GUI.Toggle(new Rect(0, 140, 100, 30), nowSelIndex == 2, "选项二"))
        {
            nowSelIndex = 2;
        }
        if(GUI.Toggle(new Rect(0, 180, 100, 30), nowSelIndex == 3, "选项三"))
        {
            nowSelIndex = 3;
        }
        #endregion
    }
}
