using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Lesson17 : MonoBehaviour
{
    Rigidbody rigidBody;
    // Start is called before the first frame update
    void Start()
    {
        #region 知识点一 刚体自带添加力的方法
        //给刚体加力的目标就是 
        //让其有一个速度 朝向某一个方向移动

        //1.首先应该获取刚体组件
        rigidBody = this.GetComponent<Rigidbody>();

        //2.添加力
        //相对世界坐标
        //世界坐标系 Z轴正方向加了一个里
        //加力过后 对象是否停止移动 是由阻力决定的
        //如果阻力为0 那给了一个力过后 始终 是不会停止运动
        //rigidBody.AddForce(Vector3.forward * 10);
        //如果想要在 世界坐标系方法中 让对象 相对于自己的面朝向动
        //rigidBody.AddForce(this.transform.forward * 10);

        //相对本地坐标
        //rigidBody.AddRelativeForce(Vector3.forward * 10);


        //3.添加扭矩力，让其旋转
        //相对世界坐标
        //rigidBody.AddTorque(Vector3.up * 10);
        //相对本地坐标
        //rigidBody.AddRelativeTorque(Vector3.up * 10);

        //4.直接改变速度
        //这个速度方向 是相对于 世界坐标系的 
        //如果要直接通过改变速度 来让其移动 一定要注意这一点
        //rigidBody.velocity = Vector3.forward * 5;

        //5.模拟爆炸效果
        //模拟爆炸的力 一定是 所有希望产生爆炸效果影响的对象 
        //都需要得到他们的刚体 来执行这个方法 才能都有效果
        //rigidBody.AddExplosionForce(100, Vector3.zero, 10);
        #endregion

        #region 知识点二 力的几种模式

        //第二个参数 力的模式 主要的作用 就是 计算方式不同而已 
        //由于4中计算方式的不同 最终的移动速度就会不同
        //rigidBody.AddForce(Vector3.forward * 10, ForceMode.Acceleration);

        //动量定理
        //Ft = mv
        // v = Ft/m;
        //F:力
        //t：时间
        //m:质量
        //v:速度

        //1.Acceleration 
        //给物体增加一个持续的加速度，忽略其质量
        //v = Ft/m
        //F:(0,0,10)
        //t:0.02s
        //m:默认为1
        //v = 10*0.02/ 1 = 0.2m/s
        //每物理帧移动0.2m/s*0.02 = 0.004m

        //2.Force
        //给物体添加一个持续的力，与物体的质量有关
        //v = Ft/m
        //F:(0,0,10)
        //t:0.02s
        //m:2kg
        //v = 10*0.02/ 2 = 0.1m/s
        //每物理帧移动0.1m/s*0.02 = 0.002m

        //3.Impulse
        //给物体添加一个瞬间的力，与物体的质量有关,忽略时间 默认为1
        //v = Ft/m
        //F:(0,0,10)
        //t:默认为1
        //m:2kg
        //v = 10*1/ 2 = 5m/s
        //每物理帧移动5m/s*0.02 = 0.1m

        //4.VelocityChange
        //给物体添加一个瞬时速度，忽略质量，忽略时间
        //v = Ft/m
        //F:(0,0,10)
        //t:默认为1
        //m:默认为1
        //v = 10*1/ 1 = 10m/s
        //每物理帧移动10m/s*0.02 = 0.2m
        #endregion

        #region 知识点三 力场脚本

        #endregion
    }

    // Update is called once per frame
    void Update()
    {
        //如果你希望即使有阻力 也希望对象一直动 那你就一直“推”就行了
        //rigidBody.AddForce(Vector3.forward * 10);

        #region 补充 刚体的休眠
        //获取刚体是否处于休眠状态 如果是 
        if (rigidBody.IsSleeping())
        {
            //就唤醒它
            rigidBody.WakeUp();
        }
        #endregion
    }
}
