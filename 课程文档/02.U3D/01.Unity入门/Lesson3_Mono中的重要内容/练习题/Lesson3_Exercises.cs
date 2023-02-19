using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Lesson3_Exercises : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        #region 练习题一
        //请说出一个继承了MonoBehavior的脚本中
        //this、this.gameObject、this.transform分别代表什么？

        //this 代表这个脚本对象
        //this.gameObject 代表这个脚本对象 依附的GameObject游戏对象
        //this.transform 代表这个脚本对象 依附的GameObject游戏对象的位置相关信息
        #endregion

        #region 练习题二
        //一个脚本A一个脚本B，他们都挂在一个GameObject上，
        //实现在A中的Start函数中让B脚本实活，请用代码失活
        #endregion

        #region 练习题三
        //一个脚本A一个脚本B，脚本A挂在A对象上，脚本B挂在B对象上
        //实现在B脚本的Start函数中将A对象上的A脚本失活
        #endregion
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
