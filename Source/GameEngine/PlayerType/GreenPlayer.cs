using System;
using System.Collections.Generic;
using System.Text;

namespace GameEngine.PlayerType
{
    public class GreenPlayer : IPlayerType
    {
        readonly Position[] destinationPositions = new Position[] { 
            new Position(2, 7), new Position(3, 7), new Position(4, 7), new Position(5, 7), new Position(6, 7),
            new Position(7, 6)
        };
        readonly Position[] basePositions = new Position[] {
            new Position(2, 5), new Position(5, 5), new Position(5, 2), new Position(2, 2)
        };

        public int PlayerTypeID { get; set; }
        public Position[] DestinationPoints => destinationPositions;
        public Position[] BasePositions => basePositions;
    }
}
