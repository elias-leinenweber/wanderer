namespace Wanderer.model
{
    public class Tile
    {
        private Terrain _terrain;

        public Tile(Terrain terrain)
        {
            _terrain = terrain;
        }
        
        public Terrain Terrain { get; set; }
    }
}