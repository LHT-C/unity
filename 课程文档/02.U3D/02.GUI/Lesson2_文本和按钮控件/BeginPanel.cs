using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class BeginPanel : MonoBehaviour
{
    //面板的显示隐藏 所有地方都能够快速使用的
    //静态 方法 和静态变量 就可以直接通过类名就用了
    private static BeginPanel instance;

    public static void ShowMe()
    {
        if(instance != null)
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


    public Rect labPos;
    public GUIContent labContent;
    public GUIStyle labStyle;

    public Rect btn1Pos;
    public Rect btn2Pos;
    public Rect btn3Pos;

    public GUIStyle btnStyle;

    public Rect bkPos;
    public Texture bkTex;

    private void Awake()
    {
        instance = this;
    }

    private void OnGUI()
    {
        GUI.DrawTexture(bkPos, bkTex);

        //游戏标题
        GUI.Label(labPos, labContent, labStyle);

        //3个游戏按钮
        if(GUI.Button(btn1Pos, "开始游戏", btnStyle))
        {
            //SceneManager.LoadScene("GameScene");
            LoginPanel.ShowMe();
            HideMe();
        }
        if(GUI.Button(btn2Pos, "设置游戏", btnStyle))
        {
            //显示设置界面
            SettingPanel.ShowMe();
            //隐藏自己
            HideMe();
        }
        if(GUI.Button(btn3Pos, "退出游戏", btnStyle))
        {
            QuitTipPanel.ShowMe();
            HideMe();
        }
    }
}
