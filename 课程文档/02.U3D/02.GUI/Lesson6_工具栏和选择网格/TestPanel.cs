using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TestPanel : MonoBehaviour
{
    public Rect toolbarPos;
    public Rect selGridPos;

    public string[] strs = new string[] { "装备", "进阶", "幻化" };

    private int nowSelIndex = 0;

    public Rect labelPos;

    private void OnGUI()
    {
        nowSelIndex = GUI.Toolbar(toolbarPos, nowSelIndex, strs);
        nowSelIndex = GUI.SelectionGrid(selGridPos, nowSelIndex, strs, 1);

        switch (nowSelIndex)
        {
            case 0:
                GUI.Label(labelPos, "装备信息");
                break;
            case 1:
                GUI.Label(labelPos, "进阶信息");
                break;
            case 2:
                GUI.Label(labelPos, "幻化信息");
                break;
        }
    }
}
