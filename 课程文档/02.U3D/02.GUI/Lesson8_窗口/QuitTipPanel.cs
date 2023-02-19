using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class QuitTipPanel : MonoBehaviour
{
    //面板的显示隐藏 所有地方都能够快速使用的
    //静态 方法 和静态变量 就可以直接通过类名就用了
    private static QuitTipPanel instance;

    public static void ShowMe()
    {
        if (instance != null)
        {
            instance.gameObject.SetActive(true);
        }
    }

    public static void HideMe()
    {
        if (instance != null)
        {
            instance.gameObject.SetActive(false);
        }
    }


    public Rect winPos;

    public Rect labPos;
    public Rect btnPos1;
    public Rect btnPos2;

    private void Awake()
    {
        instance = this;
        HideMe();
    }

    private void OnGUI()

    {
        GUI.ModalWindow(1, winPos, DrawWindow, "提示");
    }

    private void DrawWindow(int id)
    {
        GUI.Label(labPos, "是否退出");

        if( GUI.Button(btnPos1, "退出") )
        {
            Application.Quit();
        }

        if( GUI.Button(btnPos2, "取消") )
        {
            HideMe();
            BeginPanel.ShowMe();
        }
    }
}
