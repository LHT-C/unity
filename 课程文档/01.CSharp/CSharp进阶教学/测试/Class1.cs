using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MrTang
{
    class MyCustomAttribute : Attribute
    {

    }

    struct Position
    {
        public int x;
        public int y;
        public Position(int x, int y)
        {
            this.x = x;
            this.y = y;
        }
    }

    class Player
    {
        [MyCustom()]
        public string name;

        public int hp;
        public int atk;
        public int def;
        public Position pos;
    }
}
