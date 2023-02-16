using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Lesson11_Exercises : MonoBehaviour
{
    public float moveSpeed = 10;
    public float rotateSpeed = 10;

    public Transform head;
    public float headRotateSpeed = 50;

    public Transform pkPos;
    public float pkRotateSpeed = 20;

    //子弹预设体
    public GameObject bulletObj;
    //子弹将要出现的位置
    public Transform bulletPos;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        #region 练习题一
        //1.使用之前的坦克预设体，用WASD键控制坦克的前景后退，左右转向
        //Transform当中的 位移 自转 相关知识点
        //键盘输入相关知识点

        //Input.GetAxis("Horizontal"); 水平方向 -1到1之间的值 0就是没有按下
        //Input.GetAxis("Vertical");  竖直方向 -1到1之间的值 0就是没有按下
        //ws键 控制位移
        // 这公式 是 ： 前进方向 * 速度 * 时间 * 当前是否移动（-1~1 相当于 正向还是反向的感觉 不按就不动 0）
        this.transform.Translate(Vector3.forward * moveSpeed * Time.deltaTime * Input.GetAxis("Vertical"));

        //ad键 控制 左右转向
        // 这公式 是 ： 转动的轴 * 速度 * 时间 * 当前是否移动（-1~1 相当于 正向还是反向的感觉 不按就不动 0）
        this.transform.Rotate(Vector3.up * rotateSpeed * Time.deltaTime * Input.GetAxis("Horizontal"));
        #endregion

        #region 练习题二
        //2.在上一题的基础上，鼠标左右移动控制炮台的转向
        //鼠标输入相关 
        //Input.GetAxis("Mouse X");
        // 这公式 是 ： 转动的轴 * 速度 * 时间 * 当前是否移动（-1~1 相当于 正向还是反向的感觉 不按就不动 0）
        head.Rotate(Vector3.up * headRotateSpeed * Time.deltaTime * Input.GetAxis("Mouse X"));
        #endregion

        #region Lesson12 练习题一
        //1.在输入习题的基础上，鼠标滚轮控制控制炮管的抬起放下
        //Input.mouseScrollDelta.y
        pkPos.Rotate(Vector3.right * pkRotateSpeed * Time.deltaTime * Input.mouseScrollDelta.y);
        #endregion

        #region Lesson16 练习题一
        if( Input.GetMouseButtonDown(0) )
        {
            //实例化一个子弹对象
            GameObject obj = Instantiate(bulletObj);
            //设置对象的位置
            obj.transform.position = bulletPos.position;
            //角度
            //obj.transform.rotation = bulletPos.rotation;
            //角度
            obj.transform.eulerAngles = bulletPos.eulerAngles;
        }
        #endregion
    }
}
