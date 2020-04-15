using System;
using System.Collections.Generic;
using System.Text;

namespace GameEngine
{
    public class Player
    {
        private const int maxAmountPiecesForPlayer = 4;

        public int PlayerID { get; set; }
        public IPlayerType PlayerType { get; set; }
        public List<Piece> Pieces { get; set; }

        public Player(IPlayerType playerType)
        {
            this.PlayerType = playerType;
        }

        public void AddPieces()
        {
            for (int i = 0; i < maxAmountPiecesForPlayer; i++)
            {
                Pieces.Add(new Piece(PlayerType.BasePositions[i]));
            }
        }
    }
}
