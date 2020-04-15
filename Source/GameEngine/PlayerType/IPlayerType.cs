using System;
using System.Collections.Generic;
using System.Text;

namespace GameEngine
{
    public interface IPlayerType
    {
        int PlayerTypeID { get; set; }
        Position[] DestinationPoints { get; }
        Position[] BasePositions { get; }
    }
}
