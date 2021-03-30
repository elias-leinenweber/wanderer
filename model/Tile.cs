namespace Wanderer.model
{
    public class Tile
    {
        private Improvement _improvement;
        public Terrain Terrain { get; set; }
        public Player Owner { get; set; }
        public bool HasChanged { get; set; }

        public Improvement Improvement
        {
            get => _improvement;
            set
            {
                _improvement = _improvement == 0 ? value : _improvement;
                HasChanged = true;
            }
        }
    }
}