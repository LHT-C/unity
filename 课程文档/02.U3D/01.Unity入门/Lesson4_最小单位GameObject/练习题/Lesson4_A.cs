using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Lesson4_A : MonoBehaviour
{
    //方法二：通过公共成员变量直接进行关联 来控制
    //虽然方法二简单 但是是有一些破坏面向对象思想的结构的
    //现在相当于 A 有个一个特征 是B
    public Lesson4_B b;

    // Start is called before the first frame update
    void Start()
    {
        //找对象 有几种方法
        //方法一：就是通过GameObject提供的查找对象的方法

        //你要控制别人 那就要得到你想要控制的对象
        //先找到 然后再做
        //找到场景中名字叫Lesson4_B的对象 
        GameObject B = GameObject.Find("Lesson4_B");
        //然后再得到该对象上挂载的某一个脚本 然后进行操作即可
        Lesson4_B lb = B.GetComponent<Lesson4_B>();
        if (lb != null)
        {
            lb.enabled = false;
        }

        b.enabled = false;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
