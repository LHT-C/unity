using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CubeObj : MonoBehaviour
{
    public int HP = 3;

    //当子弹碰到我时  就减血 血量为0了 就移除
    private void OnTriggerEnter(Collider other)
    {
        //由于场景上 只有子弹时触发器 所以我们可以不用进行任何判断 就可以完成这个功能
        //减血
        HP -= 1;
        //为0就移除自己
        if( HP <= 0 )
        {
            Destroy(this.gameObject);
        }
    }
}
