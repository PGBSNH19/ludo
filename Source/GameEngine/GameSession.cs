using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace GameEngine
{
    public class GameSession
    {
        private const int minimumAmountPlayers = 2,
            maxinumAmountPlayers = 4;

        public int GameSessionID { get; set; }
        public List<Player> Players { get; set; }

        public GameSession()
        {
            Players = new List<Player>();
        }

        public void AddPlayer(Player player)
        {
            if (PlayerOfTypeExists(player.PlayerType)) {
                throw new ArgumentException("Player of type " + player.PlayerType.GetType() + " already exists in the list of players");
            }
            if (Players.Count >= maxinumAmountPlayers)
            {
                throw new ArgumentException("Cannot add more than " + maxinumAmountPlayers + " players to the game.");
            }
            else
            {
                Players.Add(player);
            }
        }

        private bool PlayerOfTypeExists(IPlayerType playerType)
        {
            return Players.Any(x => x.PlayerType.GetType() == playerType.GetType());
        }
    }
}
