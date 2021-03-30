using System.ComponentModel;
using System.Drawing.Design;
using System.Windows.Forms;
using System.Windows.Forms.Design;

namespace Wanderer.view.Controls
{
    public partial class MapView : TableLayoutPanel
    {
        public static TileView SelectedTile;
        private TileView[,] tileViews;

        [Category("Model")]
        [Browsable(true)]
        [Description("La map correspondante.")]
        [Editor(typeof(WindowsFormsComponentEditor), typeof(UITypeEditor))]
        public Map Model {
            set {
                ColumnCount = value.Tiles.GetLength(0);
                RowCount = value.Tiles.GetLength(1);

                tileViews = new TileView[ColumnCount, RowCount];

                for(int i = 0; i < ColumnCount; i++)
                {
                    this.ColumnStyles.Add(new ColumnStyle());
                }

                for (int i = 0; i < RowCount; i++)
                {
                    this.RowStyles.Add(new RowStyle());
                }


                for (int i = 0; i < ColumnCount; ++i)
                {

                    for (int j = 0; j < RowCount; ++j)
                    {
                        tileViews[i, j] = new TileView(value.Tiles[i, j]);
                        Controls.Add(tileViews[i, j], i, j);
                        this.RowStyles[j].Height = 14;
                    }
                    this.ColumnStyles[i].Width = 14;
                }

            }
        }

        public MapView()
        {
            InitializeComponent();
            
        }
    }
}