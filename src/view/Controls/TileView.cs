using System;
using System.Drawing;
using System.Windows.Forms;
using Wanderer.model;

namespace Wanderer.view.Controls
{
    public class TileView : Button
    {
        public Tile model { get; }
        
        public TileView(Tile tile)
        {
            model = tile;
            Height = Width;
            FlatStyle = FlatStyle.Flat;
            FlatAppearance.MouseOverBackColor = Color.Transparent;
            BackColor = Color.Transparent;
            MouseEnter += OnMouseEnterButton1;
            MouseLeave += OnMouseLeaveButton1;
            Click += OnClick;
            //Image = imageFromTerrain();
        }

        private void OnMouseEnterButton1(object sender, EventArgs e)
        {
            this.FlatAppearance.BorderColor = Color.Yellow; // or Color.Red or whatever you want
            //this.BackColor = Color.Transparent;
        }
        private void OnMouseLeaveButton1(object sender, EventArgs e)
        {
            this.FlatAppearance.BorderColor = Color.Black;
        }

        private void OnClick(object sender, EventArgs e)
        {
            MapView.SelectedTile = this;
        }
    }
}