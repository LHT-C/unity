using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public enum E_Do_Type
{
    //改名
    ChangeName,
    //失活
    ActiveFlase, 
    //延迟删除
    DelayDes,
    //删除
    Des,
}

public class Lesson4_A1 : MonoBehaviour
{
    //申明一个枚举 表示不同的状态
    public E_Do_Type type = E_Do_Type.ChangeName;

    //通过Inspector窗口 关联B 这种方式 更加效率
    public GameObject B;

    // Start is called before the first frame update
    void Start()
    {
        switch (type)
        {
            case E_Do_Type.ChangeName:
                B.name = "B改名";
                break;
            case E_Do_Type.ActiveFlase:
                B.SetActive(false);
                break;
            case E_Do_Type.DelayDes:
                Destroy(B, 5);
                break;
            case E_Do_Type.Des:
                DestroyImmediate(B);
                break;
            default:
                break;
        }
    }

}
