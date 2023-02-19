using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Lesson10_Exercises : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        

        
    }

    [ContextMenu("左前方创建空物体")]
    void TestFun1()
    {
        #region 练习题一
        //一个物体A，不管它在什么位置，写一个方法，只要执行这个方法就可以在它的左前方（-1,0,1）处创建一个空物体
        //Vector3 pos = this.transform.TransformPoint(new Vector3(-1, 0, 1));
        GameObject obj = new GameObject("左前方物体");
        obj.transform.position = this.transform.TransformPoint(new Vector3(-1, 0, 1));
        #endregion
    }

    [ContextMenu("面前创建3个球体")]
    void TestFun2()
    {
        #region 练习题二
        //一个物体A，不管它在什么位置，写一个方法，只要执行这个方法就可以在它的前方创建出3个球体，
        //位置分别是（0,0,1）,（0,0,2）,（0,0,3）
        //GameObject obj = GameObject.CreatePrimitive(PrimitiveType.Sphere);
        //obj.transform.position = this.transform.TransformPoint(new Vector3(0, 0, 1));

        //obj = GameObject.CreatePrimitive(PrimitiveType.Sphere);
        //obj.transform.position = this.transform.TransformPoint(new Vector3(0, 0, 2));

        //obj = GameObject.CreatePrimitive(PrimitiveType.Sphere);
        //obj.transform.position = this.transform.TransformPoint(new Vector3(0, 0, 3));

        for (int i = 1; i <= 3; i++)
        {
            GameObject obj = GameObject.CreatePrimitive(PrimitiveType.Sphere);
            obj.transform.position = this.transform.TransformPoint(Vector3.forward * i);
        }
        #endregion
    }
}
