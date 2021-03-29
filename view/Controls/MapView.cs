﻿using System.ComponentModel;
using System.Drawing.Design;
using System.Windows.Forms;
using System.Windows.Forms.Design;

namespace Wanderer.view.Controls
{
    public partial class MapView : TableLayoutPanel
    {
        private TileView[,] tileViews;

        [Category("Model")]
        [Browsable(true)]
        [Description("La map correspondante.")]
        [Editor(typeof(WindowsFormsComponentEditor), typeof(UITypeEditor))]
        public Map Model {
            set {
                ColumnCount = value.Tiles.GetLength(0);
                RowCount = value.Tiles.GetLength(1);

                for (int i = 0; i < ColumnCount; ++i)
                    for (int j = 0; j < RowCount; ++j)
                    {
                        tileViews[i, j] = new TileView(value.Tiles[i, j]);
                        Controls.Add(tileViews[i, j], i, j);
                    }
            }
        }

        public MapView()
        {
            InitializeComponent();
        }
    }
}