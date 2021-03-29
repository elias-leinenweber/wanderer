using System.Windows.Forms;

namespace Wanderer.view.Controls
{
    public class MapView : TableLayoutPanel
    {
        private TileView[,] tileViews;

        public MapView(Map map)
        {
            for (int i = 0; i < map.Tiles.GetLength(0); ++i)
                for (int j = 0; j < map.Tiles.GetLength(1); ++j)
                {
                    tileViews[i, j] = new TileView(map.Tiles[i, j]);
                }
        }
    }
}