using System;
using System.Collections.Generic;
using System.Text;

namespace GameEngine.PlayerType
{
    public class RedPlayer : IPlayerType
    {
        readonly Position[] destinationPositions = new Position[] { };
        readonly Position[] basePositions = new Position[] { };

        public int PlayerTypeID { get; set; }
        public Position[] DestinationPoints => destinationPositions;
        public Position[] BasePositions => basePositions;
    }
}
