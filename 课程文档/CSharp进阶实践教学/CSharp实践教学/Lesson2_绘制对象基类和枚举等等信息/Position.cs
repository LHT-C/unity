using System;
using System.Collections.Generic;
using System.Text;

namespace CSharp实践教学
{
    struct Position
    {
        public int x;
        public int y;

        public Position(int x, int y)
        {
            this.x = x;
            this.y = y;
        }

        //肯定是存在比较相关的信息的
        public static bool operator ==( Position p1, Position p2 )
        {
            if (p1.x == p2.x && p1.y == p2.y)
                return true;
            return false;
        }

        public static bool operator !=(Position p1, Position p2)
        {
            if (p1.x == p2.x && p1.y == p2.y)
                return false;
            return true;
        }

        public static Position operator +(Position p1, Position p2)
        {
            Position pos = new Position(p1.x + p2.x, p1.y + p2.y);
            return pos;
        }
    }
}
