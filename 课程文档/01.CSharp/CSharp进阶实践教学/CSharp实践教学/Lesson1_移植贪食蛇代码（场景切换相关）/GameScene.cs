using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace CSharp实践教学
{
    class GameScene : ISceneUpdate
    {
        Map map;
        BlockWorker blockWorker;

        #region Lesson10 
        //bool isRunning;
        //Thread inputThread;
        #endregion
        public GameScene()
        {
            map = new Map(this);
            blockWorker = new BlockWorker();
            #region Lesson10 输入线程

            //添加输入事件监听
            InputThread.Instance.inputEvent += CheckInputThread;

            //isRunning = true;
            //inputThread = new Thread(CheckInputThread);
            ////设置成后台线程 声明周期随主线程决定
            //inputThread.IsBackground = true;
            ////开启线程
            //inputThread.Start();
            #endregion
        }

        #region Lesson10 输入线程
        private void CheckInputThread()
        {
            //while (isRunning)
            //{
            //这只是 另一个输入线程 每帧会执行的逻辑 不需要自己来死循环
                if (Console.KeyAvailable)
                {
                    //为了避免影响主线程 在输入后加锁
                    lock (blockWorker)
                    {
                        switch (Console.ReadKey(true).Key)
                        {
                            case ConsoleKey.LeftArrow:
                                //判断能不能变形
                                if (blockWorker.CanChange(E_Change_Type.Left, map))
                                    blockWorker.Change(E_Change_Type.Left);
                                break;
                            case ConsoleKey.RightArrow:
                                //判断能不能变形
                                if (blockWorker.CanChange(E_Change_Type.Right, map))
                                    blockWorker.Change(E_Change_Type.Right);
                                break;
                            case ConsoleKey.A:
                                if (blockWorker.CanMoveRL(E_Change_Type.Left, map))
                                    blockWorker.MoveRL(E_Change_Type.Left);
                                break;
                            case ConsoleKey.D:
                                if (blockWorker.CanMoveRL(E_Change_Type.Right, map))
                                    blockWorker.MoveRL(E_Change_Type.Right);
                                break;
                            case ConsoleKey.S:
                                //向下动
                                if (blockWorker.CanMove(map))
                                    blockWorker.AutoMove();
                                break;
                        }
                    }

                }
            //}
        }
        #endregion

        /// <summary>
        /// 停止线程
        /// </summary>
        public void StopThread()
        {
            //isRunning = false;
            //inputThread = null;

            //移除输入事件监听
            InputThread.Instance.inputEvent -= CheckInputThread;

            //在某些c#版本中 会直接报错 没用
            //inputThread.Abort();
        }

        public void Update()
        {
            //锁里面不要包含 休眠 不然会影响别人
            lock(blockWorker)
            {
                //地图绘制
                map.Draw();
                //搬运工绘制
                blockWorker.Draw();
                //自动向下移动
                if (blockWorker.CanMove(map))
                    blockWorker.AutoMove();
            }
            //用线程休眠的形式 
            Thread.Sleep(200);
        }
    }
}
