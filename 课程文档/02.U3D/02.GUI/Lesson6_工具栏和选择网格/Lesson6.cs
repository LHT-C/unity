using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Lesson6 : MonoBehaviour
{
    private int toolbarIndex = 0;
    private string[] toolbarInfos = new string[] { "强化", "进阶", "幻化" };

    private int selGridIndex = 0;

    private void OnGUI()
    {
        #region 知识点一 工具栏
        toolbarIndex = GUI.Toolbar(new Rect(0, 0, 200, 30), toolbarIndex, toolbarInfos);
        //工具栏可以帮助我们根据不同的返回索引 来处理不同的逻辑
        switch (toolbarIndex)
        {
            case 0:
                break;
            case 1:
                break;
            case 2:
                break;
        }
        #endregion

        #region 知识点二 选择网格
        //相对toolbar多了一个参数 xCount 代表 水平方向最多显示的按钮数量
        selGridIndex = GUI.SelectionGrid(new Rect(0, 50, 200, 60), selGridIndex, toolbarInfos, 1);
        #endregion
    }
}
