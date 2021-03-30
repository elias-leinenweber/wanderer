namespace Wanderer.model
{
    public class Map
    {
        private Tile[,] _tiles;

        public Map(int x, int y)
        {
            _tiles = new Tile[x, y];
            for (int i = 0; i < x; ++i)
                for (int j = 0; j < y; ++j)
                    _tiles[i, j] = new Tile();
        }

        public Tile[,] Tiles
        {
            get => _tiles;
            set => _tiles = value;
        }
    }
}