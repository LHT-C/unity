using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Lesson10 : MonoBehaviour
{
    private void OnGUI()
    {
        #region 知识点一 GUILayout 自动布局
        //主要用于进行编辑器开发 如果用它来做游戏UI不太合适
        GUI.BeginGroup(new Rect(100, 100, 200, 300));
        GUILayout.BeginVertical();

        GUILayout.Button("123", GUILayout.Width(200));
        GUILayout.Button("245666656565");
        GUILayout.Button("235", GUILayout.ExpandWidth(false));

        GUILayout.EndVertical();
        GUI.EndGroup();
        #endregion

        #region 知识点二 GUILayoutOption 布局选项
        //控件的固定宽高
        GUILayout.Width(300);
        GUILayout.Height(200);
        //允许控件的最小宽高
        GUILayout.MinWidth(50);
        GUILayout.MinHeight(50);
        //允许控件的最大宽高
        GUILayout.MaxWidth(100);
        GUILayout.MaxHeight(100);
        //允许或禁止水平拓展
        GUILayout.ExpandWidth(true);//允许
        GUILayout.ExpandHeight(false);//禁止
        GUILayout.ExpandHeight(true);//允许
        GUILayout.ExpandHeight(false);//禁止
        #endregion
    }
}
