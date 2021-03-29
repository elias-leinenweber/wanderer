using System.Windows.Forms;

namespace Wanderer.view.Controls
{
    public partial class MapView : TableLayoutPanel
    {
        private TileView[,] tileViews;

        public MapView(Map map)
        {
            InitializeComponent();
            
            ColumnCount = map.Tiles.GetLength(0);
            RowCount = map.Tiles.GetLength(1);

            for (int i = 0; i < ColumnCount; ++i)
                for (int j = 0; j < RowCount; ++j)
                {
                    tileViews[i, j] = new TileView(map.Tiles[i, j]);
                    Controls.Add(tileViews[i, j], i, j);
                }
        }
    }
}