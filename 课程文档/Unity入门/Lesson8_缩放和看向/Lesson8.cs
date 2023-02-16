using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Lesson8 : MonoBehaviour
{
    public Transform lookAtObj;

    // Start is called before the first frame update
    void Start()
    {
        #region 知识点一 缩放
        //相对世界坐标系
        print(this.transform.lossyScale);
        //相对本地坐标系（父对象）
        print(this.transform.localScale);

        //注意：
        //1.同样缩放不能只改xyz 只能一起改(相对于世界坐标系的缩放大小只能得 不能改)
        //所以 我们一般要修改缩放大小 都是改的 相对于父对象的 缩放大小 localScale
        //this.transform.localScale = new Vector3(3, 3, 3);

        //2.Unity没有提供关于缩放的API
        //之前的 旋转 位移 都提供了 对应的 API 但是 缩放并没有
        //如果你想要 让 缩放 发生变化 只能自己去写(自己算)
        #endregion

       
    }

    // Update is called once per frame
    void Update()
    {
        //2.Unity没有提供关于缩放的API
        //之前的 旋转 位移 都提供了 对应的 API 但是 缩放并没有
        //如果你想要 让 缩放 发生变化 只能自己去写(自己算)
        //this.transform.localScale += Vector3.one * Time.deltaTime;

        #region 知识点二 看向
        //让一个对象的面朝向 可以一直看向某一个点或者某一个对象
        //看向一个点 相对于世界坐标系的
        //this.transform.LookAt(Vector3.zero);
        //看向一个对象 就传入一个对象的  Transform信息
        this.transform.LookAt(lookAtObj);
        #endregion
    }

    //总结：
    //缩放相关
    //相对于 世界坐标系的缩放 只能得 不能改
    //只能去修改相对于本地坐标系的缩放（相对于父对象）
    //没有提供对应的API来 缩放变化 只能自己算
    //看向
    //LookAt 看向一个点 或者一个对象  
    //一定记住 是写在Update里面 才会不停变化
}
