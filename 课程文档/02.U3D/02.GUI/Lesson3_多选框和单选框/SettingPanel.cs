using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SettingPanel : MonoBehaviour
{
    //面板的显示隐藏 所有地方都能够快速使用的
    //静态 方法 和静态变量 就可以直接通过类名就用了
    private static SettingPanel instance;

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

    public Rect toggleMusicPos;
    public Rect toggleSoundPos;

    private bool isSelMusic = true;
    private bool isSelSound = true;

    public Rect btnPos;
    public GUIStyle btnStyle;

    private float musicValue = 1;
    public Rect musicPos;

    private float soundValue = 1;
    public Rect soundPos;

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

        isSelMusic = GUI.Toggle(toggleMusicPos, isSelMusic, "音乐开关");
        isSelSound = GUI.Toggle(toggleSoundPos, isSelSound, "音效开关");

        //拖动条
        musicValue = GUI.HorizontalSlider(musicPos, musicValue, 0, 1);
        soundValue = GUI.HorizontalSlider(soundPos, soundValue, 0, 1);

        if (GUI.Button(btnPos, "", btnStyle))
        {
            //关闭自己这个面板的功能
            HideMe();
            //显示开始界面
            BeginPanel.ShowMe();
        }
    }

    //总结
    //1.要完成 面板之间 相互控制显示 有3中方法
    //  第一种：都写在一个OnGUI中 通过bool标识去控制显影
    //  第二种：挂载在同一个对象上 通过控制脚本的 失活激活 enable去控制代码是否执行 达到显影
    //  第三种：挂载在不同对象上 通过控制对象的 失活激活 来达到 面板的显影

    //2.关键的 如何在多个面板之间相互调用显影  我们是通过 静态变量和静态方法的形式
    //  在Awake时  初始化 静态变量  如果要用该方法 一开始 这个对象不能失活
}
