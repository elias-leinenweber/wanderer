using System.Collections.Generic;
using System.Drawing;
using Wanderer.model;

namespace Wanderer.controller
{
    public class Game
    {
        public List<Player> Players { get; set; }
        public int currentPlayerIndex { get; set; }
        public static Game Instance { get; set; }

        public Game()
        {
            Players = new List<Player>(2);
            Players.Add(new Player(Color.Brown));
            Players.Add(new Player(Color.RoyalBlue));
        }
    }
}