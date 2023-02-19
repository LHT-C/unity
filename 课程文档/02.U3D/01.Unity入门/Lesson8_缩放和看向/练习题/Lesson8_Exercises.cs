using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// 该脚本会挂载到摄像机上
/// </summary>
public class Lesson8_Exercises : MonoBehaviour
{
    public Transform target;

    // Start is called before the first frame update
    void Start()
    {
        #region 练习题
        //使用之前的坦克预设体，让摄像机可以跟随其移动，并且一直看向坦克
        #endregion
    }

    // Update is called once per frame
    void Update()
    {
        this.transform.LookAt(target);
    }
}
