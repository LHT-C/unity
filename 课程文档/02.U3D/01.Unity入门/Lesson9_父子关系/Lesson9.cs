using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Lesson9 : MonoBehaviour
{
    public Transform son;
    // Start is called before the first frame update
    void Start()
    {
        #region 知识点一 获取和设置父对象
        //获取父对象
        //print(this.transform.parent.name);
        //设置父对象 断绝父子关系
        //this.transform.parent = null;
        //设置父对象 认爸爸
        //this.transform.parent = GameObject.Find("Father2").transform;

        //通过API来进行父子关系的设置
        //this.transform.SetParent(null);//断绝父子关系
        //this.transform.SetParent(GameObject.Find("Father2").transform);//认爸爸

        //参数一：我的父亲
        //参数二：是否保留世界坐标的 位置 角度 缩放 信息
        //       true  会保留 世界坐标下的状态  和 父对象 进行计算 得到本地坐标系的信息
        //       false 不会保留 会直接把世界坐标系下的 位置角度缩放 直接赋值到 本地坐标系下 
        //this.transform.SetParent(GameObject.Find("Father3").transform, false);
        #endregion

        #region 知识点二 抛妻弃子
        //就是和自己的所有儿子 断绝关系 没有父子关系了
        //this.transform.DetachChildren();
        #endregion

        #region 知识点三 获取子对象
        //按名字查找儿子
        //找到儿子的 transform信息
        //Find方法 是能够找到 失活的对象的 ！！！！！ GameObject相关的 查找 是不能找到失活对象的
        print(this.transform.Find("Cube (1)").name);
        //他只能找到自己的儿子 找不到自己的孙子 ！！！！！！
        //print(this.transform.Find("GameObject").name);
        //虽然它的效率 比GameObject.Find相关 要高一些 但是 前提是你必须知道父亲是谁 才能找

        //遍历儿子
        //如何得到有多少个儿子
        //1.失活的儿子也会算数量
        //2.找不到孙子 所以孙子不会算数量
        print(this.transform.childCount);
        //通过索引号 去得到自己对应的儿子
        //如果编号 超出了儿子数量的范围 那会直接报错的 
        //返回值 是 transform 可以得到对应儿子的 位置相关信息
        this.transform.GetChild(0);

        for (int i = 0; i < this.transform.childCount; i++)
        {
            print("儿子的名字：" + this.transform.GetChild(i).name);
        }
        #endregion

        #region 知识点四 儿子的操作
        //判断自己的爸爸是谁
        //一个对象 判断自己是不是另一个对象的儿子
        if(son.IsChildOf(this.transform))
        {
            print("是我的儿子");
        }
        //得到自己作为儿子的编号
        print(son.GetSiblingIndex());
        //把自己设置为第一个儿子
        son.SetAsFirstSibling();
        //把自己设置为最后一个儿子
        son.SetAsLastSibling();
        //把自己设置为指定个儿子
        //就算你填的数量 超出了范围（负数或者更大的数） 不会报错 会直接设置成最后一个编号
        son.SetSiblingIndex(1);
        #endregion
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    //总结
    // 设置父对象相关的内容
    // 获取子对象

    //抛弃妻子
    //儿子的操作
}
