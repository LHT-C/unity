using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Lesson2 : MonoBehaviour
{
    public Texture tex;
    public Rect rect;

    public Rect rect1;

    public GUIContent content;

    public GUIStyle style;

    public Rect btnRect;
    public GUIContent btnContent;
    public GUIStyle btnStyle;

    private void OnGUI()
    {
        #region 知识点一 GUI 控件绘制的共同点
        //1.他们都是GUI公共类中提供的静态函数 直接调用即可
        //2.他们的参数都大同小异
        //  位置参数：Rect参数  x y位置 w h尺寸
        //  显示文本：string参数
        //  图片信息：Texture参数
        //  综合信息：GUIContent参数
        //  自定义样式：GUIStyle参数
        //3.每一种控件都有多种重载，都是各个参数的排列组合
        //  必备的参数内容 是 位置信息和显示信息
        #endregion

        #region 知识点二 文本控件
        //基本使用
        GUI.Label(new Rect(0, 0, 100, 20), "唐老狮欢迎你", style);
        GUI.Label(rect, tex);
        //综合使用
        GUI.Label(rect1, content);
        //可以获取当前鼠标或者键盘选中的GUI控件 对应的 tooltip信息
        Debug.Log(GUI.tooltip);
        //自定义样式
        #endregion

        #region 知识点三 按钮控件
        //基本使用
        //综合使用
        //自定义样式
        //在按钮范围内 按下鼠标再抬起鼠标 才算一次点击 才会返回true
        //if (GUI.Button(btnRect, btnContent, btnStyle))
        //{
        //    //处理我们按钮点击的逻辑
        //    Debug.Log("按钮被点击");
        //}

        //只要在长按按钮范围内 按下鼠标 就会一直返回true
        if( GUI.RepeatButton(btnRect, btnContent) )
        {
            Debug.Log("长按按钮被点击");
        }
        #endregion
    }
}
