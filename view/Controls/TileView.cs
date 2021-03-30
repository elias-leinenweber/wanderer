using System.Drawing;
using System.Windows.Forms;
using Wanderer.model;

namespace Wanderer.view.Controls
{
    public class TileView : Button
    {
        private Tile model;
        
        public TileView(Tile tile)
        {
            model = tile;
            Height = Width;
            FlatStyle = FlatStyle.Flat;
            BackColor = Color.Transparent;
            Margin.All = 0;
            //Image = imageFromTerrain();
        }

        private Image imageFromTerrain()
        {
            switch (model.Terrain)
            {
                case Terrain.Plains:
                    break;
                case Terrain.Hills:
                    break;
            }

            return null;
        }
    }
}