using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Lesson3 : MonoBehaviour
{
    public Lesson3 otherLesson3;

    // Start is called before the first frame update
    void Start()
    {
        #region 知识点一 重要成员
        //1.获取依附的GameObject
        print(this.gameObject.name);
        //2.获取依附的GameObject的位置信息
        //得到对象位置信息
        print(this.transform.position);//位置
        print(this.transform.eulerAngles);//角度
        print(this.transform.lossyScale);//缩放大小
        //这种写法和上面是一样的效果 都是得到依附的对象的位置信息
        //this.gameObject.transform

        //3.获取脚本是否激活
        this.enabled = false;

        //获取别的脚本对象 依附的gameobject和 transform位置信息
        print(otherLesson3.gameObject.name);
        print(otherLesson3.transform.position);
        #endregion

        #region 知识点二 重要方法
        //得到依附对象上挂载的其它脚本

        //1.得到自己挂载的单个脚本
        //根据脚本名获取
        //获取脚本的方法 如果获取失败 就是没有对应的脚本 会默认返回空
        Lesson3_Test t = this.GetComponent("Lesson3_Test") as Lesson3_Test;
        print(t);
        //根据Type获取
        t = this.GetComponent(typeof(Lesson3_Test)) as Lesson3_Test;
        print(t);
        //根据泛型获取 建议使用泛型获取 因为不用二次转换
        t = this.GetComponent<Lesson3_Test>();
        if( t != null )
        {
            print(t);
        }
        
        //只要你能得到场景中别的对象或者对象依附的脚本
        //那你就可以获取到它的所有信息

        //2.得到自己挂载的多个脚本
        Lesson3[] array = this.GetComponents<Lesson3>();
        print(array.Length);
        List<Lesson3> list = new List<Lesson3>();
        this.GetComponents<Lesson3>(list);
        print(list.Count);

        //3.得到子对象挂载的脚本(它默认也会找自己身上是否挂载该脚本)
        //函数是有一个参数的 默认不传 是false 意思就是 如果子对象失活 是不会去找这个对象上是否有某个脚本的
        //如果传true 及时 失活 也会找
        //得子对象 挂载脚本 单个
        t = this.GetComponentInChildren<Lesson3_Test>(true);
        print(t);
        //得子对象 挂载脚本 多个
        
        Lesson3_Test[] lts = this.GetComponentsInChildren<Lesson3_Test>(true);
        print(lts.Length);
        
        List<Lesson3_Test> list2 = new List<Lesson3_Test>();
        this.GetComponentsInChildren<Lesson3_Test>(true, list2);
        print(list2.Count);

        //4.得到父对象挂载的脚本(它默认也会找自己身上是否挂载该脚本)
        t = this.GetComponentInParent<Lesson3_Test>();
        print(t);
        lts = this.GetComponentsInParent<Lesson3_Test>();
        print(lts.Length);
        //它也有list的 省略不写了 和上面是一样的套路

        //5.尝试获取脚本
        Lesson3_Test l3t;
        //提供了一个更加安全的 获取单个脚本的方法 如果得到了 会返回true
        //然后在来进行逻辑处理即可
        if(this.TryGetComponent<Lesson3_Test>(out l3t))
        {
            //逻辑处理
        }

        #endregion
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
