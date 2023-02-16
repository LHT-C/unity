using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletObj : MonoBehaviour
{
    public float moveSpeed = 10;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        this.transform.Translate(Vector3.forward * moveSpeed * Time.deltaTime);
    }

    //private void OnCollisionEnter(Collision collision)
    //{
    //    //问题一：如果发射子弹时  和坦克自身的碰撞和重合了 可能一开始 就会被移除
    //    //解决方案：判断自己碰撞到的对象 是什么 一定是特定对象 才移除自己
    //    if(collision.gameObject.CompareTag("Ground"))
    //    {
    //        //碰撞到别的东西 就让子弹小时
    //        //一定是移除自己依附的GameObject对象 而不是脚本自己
    //        Destroy(this.gameObject);
    //    }

    //    //问题二：坦克本身就带有碰撞盒  当子弹和坦克自身的碰撞盒碰撞可能会产生力的作用 出现一些意想不到的效果
    //    //解决方案：把子弹做成触发器 这样就没有了力的作用
    //}

    private void OnTriggerEnter(Collider other)
    {
        //问题一：如果发射子弹时  和坦克自身的碰撞和重合了 可能一开始 就会被移除
        //解决方案：判断自己碰撞到的对象 是什么 一定是特定对象 才移除自己
        if (other.gameObject.CompareTag("Ground") ||
            other.gameObject.CompareTag("Monster"))
        {
            //碰撞到别的东西 就让子弹小时
            //一定是移除自己依附的GameObject对象 而不是脚本自己
            Destroy(this.gameObject);
        }

        //问题二：坦克本身就带有碰撞盒  当子弹和坦克自身的碰撞盒碰撞可能会产生力的作用 出现一些意想不到的效果
        //解决方案：把子弹做成触发器 这样就没有了力的作用
    }
}
