using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Lesson5 : MonoBehaviour
{
    public Rect texPos;

    public Texture tex;

    public ScaleMode mode = ScaleMode.StretchToFill;

    public bool alpha = true;

    public float wh = 0;

    private void OnGUI()
    {
        #region 知识点一 图片绘制
        // ScaleMode
        // ScaleAndCrop:也会通过宽高比来计算图片 但是 会进行裁剪
        // ScaleToFit：会自动根据宽高比进行计算 不会拉变形 会一直保持图片完全显示的状态
        // StretchToFill:始终填充满你传入的 Rect范围

        // alpha 是用来 控制 图片是否开启透明通道的

        //imageAspect ： 自定义宽高比  如果不填 默认为0 就会使用 图片原始宽高  
        GUI.DrawTexture(texPos, tex, mode, alpha, wh);
        #endregion

        #region 知识点二 框绘制
        //GUI.Box(texPos, "");
        #endregion
    }
}
