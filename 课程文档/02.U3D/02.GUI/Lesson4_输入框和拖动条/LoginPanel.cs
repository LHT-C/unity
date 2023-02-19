using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LoginPanel : MonoBehaviour
{
    //面板的显示隐藏 所有地方都能够快速使用的
    //静态 方法 和静态变量 就可以直接通过类名就用了
    private static LoginPanel instance;

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

    //两个 按钮
    public Rect btn1Pos;
    public Rect btn2Pos;
    //两个 label
    public Rect lab1Pos;
    public Rect lab2Pos;
    //两个 输入框
    public Rect input1Pos;
    public Rect input2Pos;

    private string userName = "";
    private string passWord = "";

    public Rect bkPos;
    public Texture bkTex;
    private void Awake()
    {
        instance = this;
        HideMe();
    }

    private void OnGUI()
    {
        GUI.DrawTexture(bkPos, bkTex);

        //按钮
        if ( GUI.Button(btn1Pos, "登录游戏") )
        {
            if(userName == "admin" && passWord == "8888")
            {
                SceneManager.LoadScene("GameScene");
            }
            else
            {
                Debug.Log("用户名或者密码错误");
            }
        }
        if( GUI.Button(btn2Pos, "返回") )
        {
            BeginPanel.ShowMe();
            HideMe();
        }
        //文本
        GUI.Label(lab1Pos, "用户名");
        GUI.Label(lab2Pos, "密码");
        //输入框
        userName = GUI.TextField(input1Pos, userName);
        passWord = GUI.PasswordField(input2Pos, passWord, '*');
    }
}
