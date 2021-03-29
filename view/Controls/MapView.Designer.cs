using System.ComponentModel;

namespace Wanderer.view.Controls
{
    public partial class MapView
    {
        private IContainer components = null;
        
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.SuspendLayout();
            this.ResumeLayout(false);
        }
    }
}