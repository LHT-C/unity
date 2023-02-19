using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Lesson8 : MonoBehaviour
{

    private Rect dragWinPos = new Rect(400, 400, 200, 150);
    private void OnGUI()
    {
        #region 知识点一 窗口
        //第一个参数 id 是窗口的唯一ID 不要和别的窗口重复
        //委托参数 是用于 绘制窗口用的函数 传入即可
        GUI.Window(1, new Rect(100, 100, 200, 150), DrawWindow, "测试窗口");
        //id对于我们来说 有一个重要作用 除了区分不同窗口 还可以在一个函数中去处理多个窗口的逻辑
        //通过id去区分他们
        GUI.Window(2, new Rect(100, 350, 200, 150), DrawWindow, "测试窗口2");
        #endregion

        #region 知识点二 模态窗口
        //模态窗口 可以让该其它控件不在有用
        //你可以理解该窗口在最上层 其它按钮都点击不到了
        //只能点击该窗口上控件

        //GUI.ModalWindow(3, new Rect(300, 100, 200, 150), DrawWindow, "模态窗口");
        #endregion

        #region 知识点三 拖动窗口
        //位置赋值只是前提
        dragWinPos = GUI.Window(4, dragWinPos, DrawWindow, "拖动窗口");
        #endregion
    }

    private void DrawWindow(int id)
    {
        switch (id)
        {
            case 1:
                GUI.Button(new Rect(0, 30, 30, 20), "1");
                break;
            case 2:
                GUI.Button(new Rect(0, 30, 30, 20), "2");
                break;
            case 3:
                GUI.Button(new Rect(0, 30, 30, 20), "3");
                break;
            case 4:
                //该API 写在窗口函数中调用 可以让窗口被拖动
                //传入Rect参数的重载 作用 
                //是决定窗口中哪一部分位置 可以被拖动
                //默认不填 就是无参重载 默认窗口的所有位置都能被拖动
                GUI.DragWindow(new Rect(0,0,1000,20));
                break;
        }
        
    }
}
