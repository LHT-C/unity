using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Lesson14_Exercises : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        #region 练习题一
        //1.游戏画面中央有一个立方体，请将该立方体的世界坐标系位置，转换为屏幕坐标，并打印出来
        print(Camera.main.WorldToScreenPoint(this.transform.position));
        #endregion

        
    }

    // Update is called once per frame
    void Update()
    {
        #region 练习题二
        //2.在屏幕上点击一下鼠标，则在对应的世界坐标位置 创建一个Cube出来
        if( Input.GetMouseButtonDown(0) )
        {
            GameObject obj = GameObject.CreatePrimitive(PrimitiveType.Cube);
            Vector3 v = Input.mousePosition;
            v.z = 20;
            obj.transform.position = Camera.main.ScreenToWorldPoint(v);
        }
        #endregion
    }
}
