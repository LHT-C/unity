using System;
using System.Collections.Generic;
using System.Text;

namespace CSharp实践教学
{
    /// <summary>
    /// 绘制类型 根据不同类型 改变绘制的方块的颜色
    /// </summary>
    enum E_DrawType
    {
        /// <summary>
        /// 墙壁
        /// </summary>
        Wall,
        /// <summary>
        /// 正方形方块
        /// </summary>
        Cube,
        /// <summary>
        /// 直线
        /// </summary>
        Line,
        /// <summary>
        /// 坦克
        /// </summary>
        Tank,
        /// <summary>
        /// 左梯子
        /// </summary>
        Left_Ladder,
        /// <summary>
        /// 右梯子
        /// </summary>
        Right_Ladder,
        /// <summary>
        /// 左长梯子
        /// </summary>
        Left_Long_Ladder,
        /// <summary>
        /// 右长梯子
        /// </summary>
        Right_Long_Ladder,
    }

    class DrawObject : IDraw
    {
        public Position pos;

        public E_DrawType type;

        public DrawObject(E_DrawType type)
        {
            this.type = type;
        }

        public DrawObject(E_DrawType type, int x, int y):this(type)
        {
            this.pos = new Position(x, y);
        }

        public void Draw()
        {
            //屏幕外不用再绘制
            if (pos.y < 0)
                return;

            Console.SetCursorPosition(pos.x, pos.y);

            switch (type)
            {
                case E_DrawType.Wall:
                    Console.ForegroundColor = ConsoleColor.Red;
                    break;
                case E_DrawType.Cube:
                    Console.ForegroundColor = ConsoleColor.Blue;
                    break;
                case E_DrawType.Line:
                    Console.ForegroundColor = ConsoleColor.Green;
                    break;
                case E_DrawType.Tank:
                    Console.ForegroundColor = ConsoleColor.Cyan;
                    break;
                case E_DrawType.Left_Ladder:
                case E_DrawType.Right_Ladder:
                    Console.ForegroundColor = ConsoleColor.Magenta;
                    break;
                case E_DrawType.Left_Long_Ladder:
                case E_DrawType.Right_Long_Ladder:
                    Console.ForegroundColor = ConsoleColor.DarkGray;
                    break;
            }
            Console.Write("■");
        }

        #region Lesson6 添加一个清楚绘制的方法
        public void ClearDraw()
        {
            //屏幕外不用再绘制
            if (pos.y < 0)
                return;
            Console.SetCursorPosition(pos.x, pos.y);
            Console.Write("  ");
        }
        #endregion

        /// <summary>
        /// 这是切换方块类型 主要用于搬砖下落到地图时 把搬砖类型编程墙壁类型
        /// </summary>
        /// <param name="type"></param>
        public void ChangeType(E_DrawType type)
        {
            this.type = type;
        }
    }
}
