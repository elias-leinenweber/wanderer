using Wanderer.model;

namespace Wanderer
{
    public class Map
    {
        private Tile[,] _tiles;

        public Map(int dx, int dy)
        {
            _tiles = new Tile[dx, dy];
        }

        public Tile[,] Tiles
        {
            get => _tiles;
            set => _tiles = value;
        }
    }
}