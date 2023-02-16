using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Lesson7_Exercises : MonoBehaviour
{
    public float rotateSpeed = 10;
    public float headRotateSpeed = 10;
    public float pkPosRotateSpeed = 10;
    //头部位置信息
    public Transform head;
    public Transform pkPos;

    public Transform dq;
    public Transform ty;
    public Transform yl;
    // Start is called before the first frame update
    void Start()
    {
        #region 练习题一 
        //1.使用你之前创建的坦克预设体，在坦克下面加一个底座（用自带几何体即可）
        //让其可以原地旋转，类似一个展览台
        #endregion

        #region 练习题二 
        //2.在第一题的基础上，让坦克的炮台可以自动左右来回旋转，炮管可以自动上下抬起
        #endregion

        #region 练习题三 
        //3.请用3个球体，模拟太阳、地球、月亮之间的旋转移动
        #endregion
    }

    // Update is called once per frame
    void Update()
    {
        #region 练习题一
        this.transform.Rotate(Vector3.up, rotateSpeed * Time.deltaTime);
        #endregion

        #region 练习题二
        //炮台左右来回旋转
        head.Rotate(Vector3.up, headRotateSpeed * Time.deltaTime);
        //炮管上下来回旋转
        pkPos.Rotate(Vector3.right, pkPosRotateSpeed * Time.deltaTime);
        //通过head.localEulerAngles得到的角度 不会出现负数的情况 
        //虽然界面上显示出了负数 但是 通过代码获取 始终 只能得到0~360之间的数

        //只能是0到360 那就只有特殊判断了
        if (!(head.localEulerAngles.y >= 315 && head.localEulerAngles.y <= 360) &&
            head.localEulerAngles.y >= 45 && headRotateSpeed > 0)
            headRotateSpeed = -headRotateSpeed;
        else if (!(head.localEulerAngles.y <= 45 && head.localEulerAngles.y >= 0) &&
                  head.localEulerAngles.y <= 315 && headRotateSpeed < 0)
            headRotateSpeed = -headRotateSpeed;

        //只能是0到360 那就只有特殊判断了
        if (!(pkPos.localEulerAngles.x >= 350 && pkPos.localEulerAngles.x <= 360) &&
            pkPos.localEulerAngles.x >= 10 && pkPosRotateSpeed > 0)
            pkPosRotateSpeed = -pkPosRotateSpeed;
        else if (!(pkPos.localEulerAngles.x <= 10 && pkPos.localEulerAngles.x >= 0) &&
                  pkPos.localEulerAngles.x <= 350 && pkPosRotateSpeed < 0)
            pkPosRotateSpeed = -pkPosRotateSpeed;
        #endregion

        #region 练习题三
        //太阳自转
        ty.Rotate(Vector3.up, 10 * Time.deltaTime);
        //地球自转
        dq.Rotate(Vector3.up, 10 * Time.deltaTime);
        //月亮自转
        yl.Rotate(Vector3.up, 10 * Time.deltaTime);

        //地球公转
        dq.RotateAround(ty.position, Vector3.up, 10 * Time.deltaTime);
        #endregion
    }
}
