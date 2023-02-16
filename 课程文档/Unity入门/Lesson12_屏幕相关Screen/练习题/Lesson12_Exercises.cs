using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Lesson12_Exercises : MonoBehaviour
{
    //摄像机看向的对象
    public Transform target;
    //摄像机旋转的速度
    public float roundSpeed = 50;

    // Start is called before the first frame update
    void Start()
    {
        #region 练习题一
        //1.在输入习题的基础上，鼠标滚轮控制控制炮管的抬起放下
        #endregion

        #region 练习题二
        //2.在上一题的基础上，加入长按鼠标右键移动鼠标
        // 可以让摄像机围着坦克旋转，改变观察坦克的视角
        #endregion
    }

    // Update is called once per frame
    void Update()
    {
        this.transform.LookAt(target);

        //使用 绕着某一个点 的某一个轴 旋转的知识点 进行处理
        //鼠标 右键按下 知识点
        if( Input.GetMouseButton(1) )
        {
            this.transform.RotateAround(target.position, //围绕的点
                Vector3.up, //哪个轴
                roundSpeed * Time.deltaTime * Input.GetAxis("Mouse X"));//速度 Mouse X -1到1 
        }
    }
}
