using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Lesson7 : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        #region 知识点一 角度相关
        //相对世界坐标角度
        print(this.transform.eulerAngles);

        //相对父对象角度
        print(this.transform.localEulerAngles);

        //注意：设置角度和设置位置一样 不能单独设置xyz 要一起设置
        //如果我们希望改变的 角度 是面板上显示的内容 那一点是改变 相对父对象的角度
        //this.transform.localEulerAngles = new Vector3(10, 10, 10);
        //this.transform.eulerAngles = new Vector3(10, 10, 10);
        print(this.transform.localEulerAngles);
        #endregion
    }

    // Update is called once per frame
    void Update()
    {
        #region 知识点二 旋转相关
        //自己计算（省略不讲了 和位置一样 不停改变角度即可）

        //API计算
        //自转
        //每个轴 具体转多少度
        //第一个参数 相当于 是旋转的角度 每一帧 
        //第二个参数 默认不填 就是相对于自己坐标系 进行的旋转
        //this.transform.Rotate(new Vector3(0, 10, 0) * Time.deltaTime);
        //this.transform.Rotate(new Vector3(0, 10, 0) * Time.deltaTime, Space.World);

        //相对于某个轴 转多少度
        //参数一：是相对哪个轴进行转动
        //参数二：是转动的 角度 是多少
        //参数三：默认不填 就是相对于自己的坐标系 进行旋转
        //       如果填  可以填写相对于 世界坐标系进行旋转
        //this.transform.Rotate(Vector3.right, 10 * Time.deltaTime);
        //this.transform.Rotate(Vector3.right, 10 * Time.deltaTime, Space.World);

        //相对于某一个点转
        //参数一：相当于哪一个点 转圈圈
        //参数二：相对于那一个点的 哪一个轴转圈圈
        //参数三：转的度数  旋转速度 * 时间
        this.transform.RotateAround(Vector3.zero, Vector3.right, 10 * Time.deltaTime);
        #endregion
    }

    //总结
    //角度相关和位置相关 差不多
    //如何得到角度
    //通过transform 可以得到相对于世界坐标系和相对于父对象的
    //如何自转和绕着别人赚
    //Rotate
    //RotateAround
}
