
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
            this.lblMarcheurBleu = new System.Windows.Forms.Label();
            this.lblArgentBleu = new System.Windows.Forms.Label();
            this.lblMarcheursUp = new System.Windows.Forms.Label();
            this.lblArgentUp = new System.Windows.Forms.Label();
            this.lblMarcheurRouge = new System.Windows.Forms.Label();
            this.lblArgentRouge = new System.Windows.Forms.Label();
            this.lblTour = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pbPersonnes = new System.Windows.Forms.PictureBox();
            this.btnUsine = new System.Windows.Forms.Button();
            this.btnTrain = new System.Windows.Forms.Button();
            this.btnRefuge = new System.Windows.Forms.Button();
            this.btnChemin = new System.Windows.Forms.Button();
            this.btnClub = new System.Windows.Forms.Button();
            this.lblRefuge = new System.Windows.Forms.Label();
            this.lblChemins = new System.Windows.Forms.Label();
            this.lblClub = new System.Windows.Forms.Label();
            this.lblTrain = new System.Windows.Forms.Label();
            this.lblUsine = new System.Windows.Forms.Label();
            this.mapView1 = new Wanderer.view.Controls.MapView();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pbAide)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbPersonnes)).BeginInit();
            this.SuspendLayout();
            // 
            // pbAide
            // 
            this.pbAide.Image = ((System.Drawing.Image)(resources.GetObject("pbAide.Image")));
            this.pbAide.Location = new System.Drawing.Point(8, 10);
            this.pbAide.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.pbAide.Name = "pbAide";
            this.pbAide.Size = new System.Drawing.Size(46, 42);
            this.pbAide.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbAide.TabIndex = 0;
            this.pbAide.TabStop = false;
            this.pbAide.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.lblMarcheurBleu);
            this.panel1.Controls.Add(this.lblArgentBleu);
            this.panel1.Controls.Add(this.lblMarcheursUp);
            this.panel1.Controls.Add(this.lblArgentUp);
            this.panel1.Controls.Add(this.lblMarcheurRouge);
            this.panel1.Controls.Add(this.lblArgentRouge);
            this.panel1.Controls.Add(this.lblTour);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.pbAide);
            this.panel1.Controls.Add(this.pbPersonnes);
            this.panel1.Location = new System.Drawing.Point(29, 8);
            this.panel1.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1218, 65);
            this.panel1.TabIndex = 1;
            // 
            // lblMarcheurBleu
            // 
            this.lblMarcheurBleu.AutoSize = true;
            this.lblMarcheurBleu.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.lblMarcheurBleu.ForeColor = System.Drawing.Color.Blue;
            this.lblMarcheurBleu.Location = new System.Drawing.Point(922, 24);
            this.lblMarcheurBleu.Name = "lblMarcheurBleu";
            this.lblMarcheurBleu.Size = new System.Drawing.Size(105, 25);
            this.lblMarcheurBleu.TabIndex = 18;
            this.lblMarcheurBleu.Text = "Marcheurs";
            // 
            // lblArgentBleu
            // 
            this.lblArgentBleu.AutoSize = true;
            this.lblArgentBleu.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.lblArgentBleu.ForeColor = System.Drawing.Color.Blue;
            this.lblArgentBleu.Location = new System.Drawing.Point(616, 23);
            this.lblArgentBleu.Name = "lblArgentBleu";
            this.lblArgentBleu.Size = new System.Drawing.Size(70, 25);
            this.lblArgentBleu.TabIndex = 17;
            this.lblArgentBleu.Text = "Argent";
            // 
            // lblMarcheursUp
            // 
            this.lblMarcheursUp.AutoSize = true;
            this.lblMarcheursUp.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.lblMarcheursUp.Location = new System.Drawing.Point(1108, 24);
            this.lblMarcheursUp.Name = "lblMarcheursUp";
            this.lblMarcheursUp.Size = new System.Drawing.Size(0, 25);
            this.lblMarcheursUp.TabIndex = 16;
            // 
            // lblArgentUp
            // 
            this.lblArgentUp.AutoSize = true;
            this.lblArgentUp.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.lblArgentUp.Location = new System.Drawing.Point(889, 27);
            this.lblArgentUp.Name = "lblArgentUp";
            this.lblArgentUp.Size = new System.Drawing.Size(0, 25);
            this.lblArgentUp.TabIndex = 15;
            // 
            // lblMarcheurRouge
            // 
            this.lblMarcheurRouge.AutoSize = true;
            this.lblMarcheurRouge.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.lblMarcheurRouge.ForeColor = System.Drawing.Color.Red;
            this.lblMarcheurRouge.Location = new System.Drawing.Point(779, 24);
            this.lblMarcheurRouge.Name = "lblMarcheurRouge";
            this.lblMarcheurRouge.Size = new System.Drawing.Size(105, 25);
            this.lblMarcheurRouge.TabIndex = 14;
            this.lblMarcheurRouge.Text = "Marcheurs";
            // 
            // lblArgentRouge
            // 
            this.lblArgentRouge.AutoSize = true;
            this.lblArgentRouge.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.lblArgentRouge.ForeColor = System.Drawing.Color.Red;
            this.lblArgentRouge.Location = new System.Drawing.Point(506, 23);
            this.lblArgentRouge.Name = "lblArgentRouge";
            this.lblArgentRouge.Size = new System.Drawing.Size(70, 25);
            this.lblArgentRouge.TabIndex = 13;
            this.lblArgentRouge.Text = "Argent";
            // 
            // lblTour
            // 
            this.lblTour.AutoSize = true;
            this.lblTour.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F);
            this.lblTour.Location = new System.Drawing.Point(61, 9);
            this.lblTour.Name = "lblTour";
            this.lblTour.Size = new System.Drawing.Size(354, 46);
            this.lblTour.TabIndex = 12;
            this.lblTour.Text = "Nombre d\'actions :";
            this.lblTour.Click += new System.EventHandler(this.label1_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(462, 18);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(32, 33);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 11;
            this.pictureBox1.TabStop = false;
            // 
            // pbPersonnes
            // 
            this.pbPersonnes.Image = ((System.Drawing.Image)(resources.GetObject("pbPersonnes.Image")));
            this.pbPersonnes.Location = new System.Drawing.Point(737, 19);
            this.pbPersonnes.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.pbPersonnes.Name = "pbPersonnes";
            this.pbPersonnes.Size = new System.Drawing.Size(32, 33);
            this.pbPersonnes.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbPersonnes.TabIndex = 10;
            this.pbPersonnes.TabStop = false;
            // 
            // btnUsine
            // 
            this.btnUsine.BackColor = System.Drawing.Color.Transparent;
            this.btnUsine.FlatAppearance.BorderSize = 2;
            this.btnUsine.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUsine.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.btnUsine.ForeColor = System.Drawing.Color.White;
            this.btnUsine.Image = ((System.Drawing.Image)(resources.GetObject("btnUsine.Image")));
            this.btnUsine.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnUsine.Location = new System.Drawing.Point(1029, 598);
            this.btnUsine.Margin = new System.Windows.Forms.Padding(2);
            this.btnUsine.Name = "btnUsine";
            this.btnUsine.Size = new System.Drawing.Size(167, 77);
            this.btnUsine.TabIndex = 5;
            this.btnUsine.Tag = "4";
            this.btnUsine.Text = "Usine";
            this.btnUsine.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnUsine.UseVisualStyleBackColor = false;
            this.btnUsine.Click += new System.EventHandler(this.btn_Click);
            // 
            // btnTrain
            // 
            this.btnTrain.BackColor = System.Drawing.Color.Transparent;
            this.btnTrain.FlatAppearance.BorderSize = 2;
            this.btnTrain.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTrain.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.btnTrain.ForeColor = System.Drawing.Color.White;
            this.btnTrain.Image = ((System.Drawing.Image)(resources.GetObject("btnTrain.Image")));
            this.btnTrain.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnTrain.Location = new System.Drawing.Point(548, 598);
            this.btnTrain.Margin = new System.Windows.Forms.Padding(2);
            this.btnTrain.Name = "btnTrain";
            this.btnTrain.Size = new System.Drawing.Size(167, 77);
            this.btnTrain.TabIndex = 6;
            this.btnTrain.Tag = "3";
            this.btnTrain.Text = "Train";
            this.btnTrain.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnTrain.UseVisualStyleBackColor = false;
            this.btnTrain.Click += new System.EventHandler(this.btn_Click);
            // 
            // btnRefuge
            // 
            this.btnRefuge.BackColor = System.Drawing.Color.Transparent;
            this.btnRefuge.FlatAppearance.BorderSize = 2;
            this.btnRefuge.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRefuge.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.btnRefuge.ForeColor = System.Drawing.Color.White;
            this.btnRefuge.Image = ((System.Drawing.Image)(resources.GetObject("btnRefuge.Image")));
            this.btnRefuge.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnRefuge.Location = new System.Drawing.Point(73, 598);
            this.btnRefuge.Margin = new System.Windows.Forms.Padding(2);
            this.btnRefuge.Name = "btnRefuge";
            this.btnRefuge.Size = new System.Drawing.Size(167, 77);
            this.btnRefuge.TabIndex = 7;
            this.btnRefuge.Tag = "0";
            this.btnRefuge.Text = "Refuge";
            this.btnRefuge.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnRefuge.UseVisualStyleBackColor = false;
            this.btnRefuge.Click += new System.EventHandler(this.btn_Click);
            // 
            // btnChemin
            // 
            this.btnChemin.BackColor = System.Drawing.Color.Transparent;
            this.btnChemin.FlatAppearance.BorderSize = 2;
            this.btnChemin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnChemin.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.btnChemin.ForeColor = System.Drawing.Color.White;
            this.btnChemin.Image = ((System.Drawing.Image)(resources.GetObject("btnChemin.Image")));
            this.btnChemin.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnChemin.Location = new System.Drawing.Point(367, 598);
            this.btnChemin.Margin = new System.Windows.Forms.Padding(2);
            this.btnChemin.Name = "btnChemin";
            this.btnChemin.Size = new System.Drawing.Size(167, 77);
            this.btnChemin.TabIndex = 8;
            this.btnChemin.Tag = "1";
            this.btnChemin.Text = "Chemins";
            this.btnChemin.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnChemin.UseVisualStyleBackColor = false;
            this.btnChemin.Click += new System.EventHandler(this.btn_Click);
            // 
            // btnClub
            // 
            this.btnClub.BackColor = System.Drawing.Color.Transparent;
            this.btnClub.FlatAppearance.BorderSize = 2;
            this.btnClub.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClub.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.btnClub.ForeColor = System.Drawing.Color.White;
            this.btnClub.Image = ((System.Drawing.Image)(resources.GetObject("btnClub.Image")));
            this.btnClub.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnClub.Location = new System.Drawing.Point(708, 598);
            this.btnClub.Margin = new System.Windows.Forms.Padding(2);
            this.btnClub.Name = "btnClub";
            this.btnClub.Size = new System.Drawing.Size(167, 77);
            this.btnClub.TabIndex = 9;
            this.btnClub.Tag = "2";
            this.btnClub.Text = "Club";
            this.btnClub.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnClub.UseVisualStyleBackColor = false;
            this.btnClub.Click += new System.EventHandler(this.btn_Click);
            // 
            // lblRefuge
            // 
            this.lblRefuge.AutoSize = true;
            this.lblRefuge.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.lblRefuge.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRefuge.Location = new System.Drawing.Point(142, 683);
            this.lblRefuge.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblRefuge.Name = "lblRefuge";
            this.lblRefuge.Size = new System.Drawing.Size(64, 25);
            this.lblRefuge.TabIndex = 12;
            this.lblRefuge.Tag = "0";
            this.lblRefuge.Text = "label1";
            // 
            // lblChemins
            // 
            this.lblChemins.AutoSize = true;
            this.lblChemins.BackColor = System.Drawing.SystemColors.ControlDark;
            this.lblChemins.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblChemins.Location = new System.Drawing.Point(430, 682);
            this.lblChemins.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblChemins.Name = "lblChemins";
            this.lblChemins.Size = new System.Drawing.Size(64, 25);
            this.lblChemins.TabIndex = 13;
            this.lblChemins.Tag = "1";
            this.lblChemins.Text = "label2";
            // 
            // lblClub
            // 
            this.lblClub.AutoSize = true;
            this.lblClub.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.lblClub.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblClub.Location = new System.Drawing.Point(780, 682);
            this.lblClub.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblClub.Name = "lblClub";
            this.lblClub.Size = new System.Drawing.Size(64, 25);
            this.lblClub.TabIndex = 14;
            this.lblClub.Tag = "2";
            this.lblClub.Text = "label3";
            // 
            // lblTrain
            // 
            this.lblTrain.AutoSize = true;
            this.lblTrain.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.lblTrain.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTrain.Location = new System.Drawing.Point(610, 682);
            this.lblTrain.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblTrain.Name = "lblTrain";
            this.lblTrain.Size = new System.Drawing.Size(64, 25);
            this.lblTrain.TabIndex = 15;
            this.lblTrain.Tag = "3";
            this.lblTrain.Text = "label4";
            // 
            // lblUsine
            // 
            this.lblUsine.AutoSize = true;
            this.lblUsine.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.lblUsine.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUsine.Location = new System.Drawing.Point(1104, 680);
            this.lblUsine.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblUsine.Name = "lblUsine";
            this.lblUsine.Size = new System.Drawing.Size(64, 25);
            this.lblUsine.TabIndex = 16;
            this.lblUsine.Tag = "4";
            this.lblUsine.Text = "label5";
            // 
            // mapView1
            // 
            this.mapView1.AutoScroll = true;
            this.mapView1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("mapView1.BackgroundImage")));
            this.mapView1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.mapView1.ColumnCount = 2;
            this.mapView1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.mapView1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.mapView1.Location = new System.Drawing.Point(29, 87);
            this.mapView1.Margin = new System.Windows.Forms.Padding(2);
            this.mapView1.Name = "mapView1";
            this.mapView1.RowCount = 2;
            this.mapView1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 13.81032F));
            this.mapView1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 86.18968F));
            this.mapView1.Size = new System.Drawing.Size(1218, 488);
            this.mapView1.TabIndex = 11;
            this.mapView1.Click += new System.EventHandler(this.mapView1_Click);
            this.mapView1.Paint += new System.Windows.Forms.PaintEventHandler(this.mapView1_Paint);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.label1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label1.Location = new System.Drawing.Point(1077, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(116, 25);
            this.label1.TabIndex = 19;
            this.label1.Text = "Objectif : 50";
            // 
            // FormJeu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(1280, 720);
            this.Controls.Add(this.lblUsine);
            this.Controls.Add(this.lblTrain);
            this.Controls.Add(this.lblClub);
            this.Controls.Add(this.lblChemins);
            this.Controls.Add(this.lblRefuge);
            this.Controls.Add(this.mapView1);
            this.Controls.Add(this.btnClub);
            this.Controls.Add(this.btnChemin);
            this.Controls.Add(this.btnRefuge);
            this.Controls.Add(this.btnTrain);
            this.Controls.Add(this.btnUsine);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.Name = "FormJeu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormJeu";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FormJeu_FormClosed);
            this.Load += new System.EventHandler(this.FormJeu_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pbAide)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbPersonnes)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

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
        private System.Windows.Forms.Label lblTour;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lblMarcheurRouge;
        private System.Windows.Forms.Label lblArgentRouge;
        private System.Windows.Forms.Label lblMarcheursUp;
        private System.Windows.Forms.Label lblArgentUp;
        private System.Windows.Forms.Label lblMarcheurBleu;
        private System.Windows.Forms.Label lblArgentBleu;
        private System.Windows.Forms.Label lblRefuge;
        private System.Windows.Forms.Label lblChemins;
        private System.Windows.Forms.Label lblClub;
        private System.Windows.Forms.Label lblTrain;
        private System.Windows.Forms.Label lblUsine;
        private System.Windows.Forms.Label label1;
    }
}