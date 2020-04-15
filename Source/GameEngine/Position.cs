using System;
using System.Collections.Generic;
using System.Text;

namespace GameEngine
{
    public class Position
    {
        public float X { get; set; }
        public float Y { get; set; }

        public Position(float x, float y) {
            this.X = x;
            this.Y = y;
        }

        public bool Equals(Position position)
        {
            return position.X == this.X && position.Y == this.Y;
        }
    }
}
