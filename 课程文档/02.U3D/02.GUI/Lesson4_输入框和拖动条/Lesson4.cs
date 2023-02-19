using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Lesson4 : MonoBehaviour
{
    private string inputStr = "";

    private string inputPW = "";

    private float nowValue = 0.5f;
    private void OnGUI()
    {
        #region 知识点一 输入框

        #region 普通输入
        //输入框 重要参数 一个是显示内容 string
        //一个是 最大输入字符串的长度
        inputStr = GUI.TextField(new Rect(0, 0, 100, 30), inputStr, 5);
        #endregion

        #region 密码输入
        inputPW = GUI.PasswordField(new Rect(0, 50, 100, 30), inputPW, '★');
        #endregion

        #endregion

        #region 知识点二 拖动条

        #region 水平拖动条
        // 当前的值
        // 最小值 left
        // 最大值 right
        nowValue = GUI.HorizontalSlider(new Rect(0, 100, 100, 50), nowValue, 0, 1);
        Debug.Log(nowValue);
        #endregion

        #region 竖直拖动条
        nowValue = GUI.VerticalSlider(new Rect(0, 150, 50, 100), nowValue, 0, 1);
        #endregion

        #endregion
    }
}
