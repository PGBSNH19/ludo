using System;
using System.Collections.Generic;
using System.Text;

namespace GameEngine
{
    public class Piece : Position
    {
        public int PieceID { get; set; }
        public Player Player { get; set; }

        public Piece(Position point) : base(point.X, point.Y)
        {

        }
    }
}
