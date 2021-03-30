using System.Drawing;

namespace Wanderer.model
{
    public class Player
    {
        public Color Color { get; set; }

        public Player(Color color)
        {
            Color = color;
        }
    }
}