using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Lesson6_Exercises : MonoBehaviour
{
    public int n = 1;

    // Start is called before the first frame update
    void Start()
    {
        #region 练习题一
        //1.一个空对象上挂了一个脚本，这个脚本可以让游戏运行时，
        //在场景中创建出一个n层由Cube构成的金字塔（提示：实例化预设体或者实例化自带几何体方法）

        //决定层数
        for (int i = 0; i < n; i++)
        {
            //每一层开始创建时 应该得到一个 初始的坐标
            Vector3 pos = new Vector3(-0.5f * i, -1 * i, 0.5f * i);
            //决定每层多少个立方体
            for (int j = 0; j < (i+1)*(i+1); j++)
            {
                //实例化 立方体 
                GameObject obj = GameObject.CreatePrimitive(PrimitiveType.Cube);
                //然后设置位置
                //因为 是起始位置 + 偏移位置 所以 Y不用变
                obj.transform.position = pos + new Vector3(j%(i+1)*1, 0, j/(i+1)*-1);
            }
        }
        #endregion

        #region 练习题二
        //2.
        //this.transform.Translate(Vector3.forward, Space.World); //始终是朝向 世界坐标系的 Z轴移动的
        //this.transform.Translate(Vector3.forward, Space.Self);  //始终是朝向自己的面朝向移动的
        //this.transform.Translate(this.transform.forward, Space.Self); //你也不知道朝哪里动 XXXXX
        //this.transform.Translate(this.transform.forward, Space.World);//始终是朝向自己的面朝向移动的
        //这四个方法，哪些才能让对象朝自己的面朝向移动？为何？（可以画图说明）
        #endregion

        
    }

    // Update is called once per frame
    void Update()
    {
        #region 练习题三
        //3.使用你之前创建的坦克预设体，让其可以朝自己的面朝向向前移动
        //this.transform.Translate(Vector3.forward * 1 * Time.deltaTime, Space.Self);
        this.transform.Translate(this.transform.forward * 1 * Time.deltaTime, Space.World);
        #endregion
    }
}
