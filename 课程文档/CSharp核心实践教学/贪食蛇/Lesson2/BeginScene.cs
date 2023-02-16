using System;
using System.Collections.Generic;
using System.Text;
using 贪食蛇.Lesson1;

namespace 贪食蛇.Lesson2
{
    class BeginScene : BeginOrEndBaseScene
    {
        public BeginScene()
        {
            strTitle = "贪食蛇";
            strOne = "开始游戏";
        }

        public override void EnterJDoSomthing()
        {
            //按J键做什么的逻辑
            if (nowSelIndex == 0)
            {
                Game.ChangeScene(E_SceneType.Game);
            }
            else
            {
                Environment.Exit(0);
            }
        }
    }
}
