using System;
using System.Collections.Generic;
using System.Text;
using 贪食蛇.Lesson3;

namespace 贪食蛇.Lesson4
{
    class Wall : GameObject
    {
        public Wall(int x, int y)
        {
            pos = new Position(x, y);
        }

        public override void Draw()
        {
            Console.SetCursorPosition(pos.x, pos.y);
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("■");
        }
    }
}
