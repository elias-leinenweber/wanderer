using Wanderer.model;

namespace Wanderer
{
    public class Map
    {
        private Tile[,] _tiles;

        public Tile[,] Tiles
        {
            get => _tiles;
            set => _tiles = value;
        }
    }
}