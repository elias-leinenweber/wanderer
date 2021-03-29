
namespace Wanderer.view
{
    partial class FormJeu
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormJeu));
            this.pbAide = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnUsine = new System.Windows.Forms.Button();
            this.btnTrain = new System.Windows.Forms.Button();
            this.btnRefuge = new System.Windows.Forms.Button();
            this.btnChemin = new System.Windows.Forms.Button();
            this.btnClub = new System.Windows.Forms.Button();
            this.pbPersonnes = new System.Windows.Forms.PictureBox();
            this.mapView1 = new Wanderer.view.Controls.MapView();
            ((System.ComponentModel.ISupportInitialize) (this.pbAide)).BeginInit();
            ((System.ComponentModel.ISupportInitialize) (this.pbPersonnes)).BeginInit();
            this.SuspendLayout();
            // 
            // pbAide
            // 
            this.pbAide.Image = ((System.Drawing.Image) (resources.GetObject("pbAide.Image")));
            this.pbAide.Location = new System.Drawing.Point(9, 10);
            this.pbAide.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.pbAide.Name = "pbAide";
            this.pbAide.Size = new System.Drawing.Size(42, 40);
            this.pbAide.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbAide.TabIndex = 0;
            this.pbAide.TabStop = false;
            this.pbAide.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // panel1
            // 
            this.panel1.Location = new System.Drawing.Point(82, 8);
            this.panel1.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(453, 46);
            this.panel1.TabIndex = 1;
            // 
            // btnUsine
            // 
            this.btnUsine.Image = ((System.Drawing.Image) (resources.GetObject("btnUsine.Image")));
            this.btnUsine.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnUsine.Location = new System.Drawing.Point(493, 292);
            this.btnUsine.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnUsine.Name = "btnUsine";
            this.btnUsine.Size = new System.Drawing.Size(99, 50);
            this.btnUsine.TabIndex = 5;
            this.btnUsine.Text = "Usine";
            this.btnUsine.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnUsine.UseVisualStyleBackColor = true;
            this.btnUsine.Click += new System.EventHandler(this.btnUsine_Click);
            // 
            // btnTrain
            // 
            this.btnTrain.Image = ((System.Drawing.Image) (resources.GetObject("btnTrain.Image")));
            this.btnTrain.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnTrain.Location = new System.Drawing.Point(132, 292);
            this.btnTrain.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnTrain.Name = "btnTrain";
            this.btnTrain.Size = new System.Drawing.Size(99, 50);
            this.btnTrain.TabIndex = 6;
            this.btnTrain.Text = "Train";
            this.btnTrain.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnTrain.UseVisualStyleBackColor = true;
            this.btnTrain.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnRefuge
            // 
            this.btnRefuge.Image = ((System.Drawing.Image) (resources.GetObject("btnRefuge.Image")));
            this.btnRefuge.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnRefuge.Location = new System.Drawing.Point(9, 292);
            this.btnRefuge.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnRefuge.Name = "btnRefuge";
            this.btnRefuge.Size = new System.Drawing.Size(99, 50);
            this.btnRefuge.TabIndex = 7;
            this.btnRefuge.Text = "Refuge";
            this.btnRefuge.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnRefuge.UseVisualStyleBackColor = true;
            this.btnRefuge.Click += new System.EventHandler(this.btnRefuge_Click);
            // 
            // btnChemin
            // 
            this.btnChemin.Image = ((System.Drawing.Image) (resources.GetObject("btnChemin.Image")));
            this.btnChemin.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnChemin.Location = new System.Drawing.Point(258, 292);
            this.btnChemin.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnChemin.Name = "btnChemin";
            this.btnChemin.Size = new System.Drawing.Size(99, 50);
            this.btnChemin.TabIndex = 8;
            this.btnChemin.Text = "Chemins";
            this.btnChemin.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnChemin.UseVisualStyleBackColor = true;
            // 
            // btnClub
            // 
            this.btnClub.Image = ((System.Drawing.Image) (resources.GetObject("btnClub.Image")));
            this.btnClub.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnClub.Location = new System.Drawing.Point(378, 292);
            this.btnClub.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnClub.Name = "btnClub";
            this.btnClub.Size = new System.Drawing.Size(99, 50);
            this.btnClub.TabIndex = 9;
            this.btnClub.Text = "Club";
            this.btnClub.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnClub.UseVisualStyleBackColor = true;
            // 
            // pbPersonnes
            // 
            this.pbPersonnes.Image = ((System.Drawing.Image) (resources.GetObject("pbPersonnes.Image")));
            this.pbPersonnes.Location = new System.Drawing.Point(539, 10);
            this.pbPersonnes.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.pbPersonnes.Name = "pbPersonnes";
            this.pbPersonnes.Size = new System.Drawing.Size(23, 23);
            this.pbPersonnes.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbPersonnes.TabIndex = 10;
            this.pbPersonnes.TabStop = false;
            // 
            // mapView1
            // 
            this.mapView1.ColumnCount = 2;
            this.mapView1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.mapView1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.mapView1.Location = new System.Drawing.Point(9, 66);
            this.mapView1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.mapView1.Name = "mapView1";
            this.mapView1.RowCount = 2;
            this.mapView1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.mapView1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.mapView1.Size = new System.Drawing.Size(583, 214);
            this.mapView1.TabIndex = 11;
            this.mapView1.Paint += new System.Windows.Forms.PaintEventHandler(this.mapView1_Paint);
            // 
            // FormJeu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(600, 365);
            this.Controls.Add(this.mapView1);
            this.Controls.Add(this.pbPersonnes);
            this.Controls.Add(this.btnClub);
            this.Controls.Add(this.btnChemin);
            this.Controls.Add(this.btnRefuge);
            this.Controls.Add(this.btnTrain);
            this.Controls.Add(this.btnUsine);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.pbAide);
            this.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.Name = "FormJeu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormJeu";
            this.Load += new System.EventHandler(this.FormJeu_Load);
            ((System.ComponentModel.ISupportInitialize) (this.pbAide)).EndInit();
            ((System.ComponentModel.ISupportInitialize) (this.pbPersonnes)).EndInit();
            this.ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.PictureBox pbAide;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnUsine;
        private System.Windows.Forms.Button btnTrain;
        private System.Windows.Forms.Button btnRefuge;
        private System.Windows.Forms.Button btnChemin;
        private System.Windows.Forms.Button btnClub;
        private System.Windows.Forms.PictureBox pbPersonnes;
        private Controls.MapView mapView1;
    }
}