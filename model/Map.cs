using Wanderer.model;

namespace Wanderer
{
    public class Map
    {
        private Tile[,] _tiles;

        public Map(int x, int y)
        {
            _tiles = new Tile[x, y];
        }

        public Tile[,] Tiles
        {
            get => _tiles;
            set => _tiles = value;
        }
    }
}