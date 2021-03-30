using System.Drawing;

namespace Wanderer.model
{
    public class Player
    {
        public Color Color { get; set; }
        public int bonusCh = 0;//bonus Chemin
        public int bonusCl = 0; //bonus Club
        public int marks = 40;
        public int randonneurs = 0;
        public int tailleTerritoire;

        public Player(Color color)
        {
            Color = color;
        }
    }
}