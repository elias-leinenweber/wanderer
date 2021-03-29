
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
            this.lblPays1 = new System.Windows.Forms.Label();
            this.lblPays3 = new System.Windows.Forms.Label();
            this.lblPays2 = new System.Windows.Forms.Label();
            this.btnUsine = new System.Windows.Forms.Button();
            this.btnTrain = new System.Windows.Forms.Button();
            this.btnRefuge = new System.Windows.Forms.Button();
            this.btnChemin = new System.Windows.Forms.Button();
            this.btnClub = new System.Windows.Forms.Button();
            this.pbPersonnes = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pbAide)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbPersonnes)).BeginInit();
            this.SuspendLayout();
            // 
            // pbAide
            // 
            this.pbAide.Image = ((System.Drawing.Image)(resources.GetObject("pbAide.Image")));
            this.pbAide.Location = new System.Drawing.Point(12, 12);
            this.pbAide.Name = "pbAide";
            this.pbAide.Size = new System.Drawing.Size(56, 49);
            this.pbAide.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbAide.TabIndex = 0;
            this.pbAide.TabStop = false;
            this.pbAide.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // panel1
            // 
            this.panel1.Location = new System.Drawing.Point(109, 10);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(604, 56);
            this.panel1.TabIndex = 1;
            // 
            // lblPays1
            // 
            this.lblPays1.AutoSize = true;
            this.lblPays1.Location = new System.Drawing.Point(74, 173);
            this.lblPays1.Name = "lblPays1";
            this.lblPays1.Size = new System.Drawing.Size(47, 17);
            this.lblPays1.TabIndex = 2;
            this.lblPays1.Text = "Pays1";
            // 
            // lblPays3
            // 
            this.lblPays3.AutoSize = true;
            this.lblPays3.Location = new System.Drawing.Point(365, 284);
            this.lblPays3.Name = "lblPays3";
            this.lblPays3.Size = new System.Drawing.Size(47, 17);
            this.lblPays3.TabIndex = 3;
            this.lblPays3.Text = "Pays3";
            // 
            // lblPays2
            // 
            this.lblPays2.AutoSize = true;
            this.lblPays2.Location = new System.Drawing.Point(567, 194);
            this.lblPays2.Name = "lblPays2";
            this.lblPays2.Size = new System.Drawing.Size(47, 17);
            this.lblPays2.TabIndex = 4;
            this.lblPays2.Text = "Pays2";
            // 
            // btnUsine
            // 
            this.btnUsine.Image = ((System.Drawing.Image)(resources.GetObject("btnUsine.Image")));
            this.btnUsine.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnUsine.Location = new System.Drawing.Point(657, 360);
            this.btnUsine.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnUsine.Name = "btnUsine";
            this.btnUsine.Size = new System.Drawing.Size(132, 62);
            this.btnUsine.TabIndex = 5;
            this.btnUsine.Text = "Usine";
            this.btnUsine.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnUsine.UseVisualStyleBackColor = true;
            this.btnUsine.Click += new System.EventHandler(this.btnUsine_Click);
            // 
            // btnTrain
            // 
            this.btnTrain.Image = ((System.Drawing.Image)(resources.GetObject("btnTrain.Image")));
            this.btnTrain.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnTrain.Location = new System.Drawing.Point(176, 360);
            this.btnTrain.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnTrain.Name = "btnTrain";
            this.btnTrain.Size = new System.Drawing.Size(132, 62);
            this.btnTrain.TabIndex = 6;
            this.btnTrain.Text = "Train";
            this.btnTrain.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnTrain.UseVisualStyleBackColor = true;
            this.btnTrain.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnRefuge
            // 
            this.btnRefuge.Image = ((System.Drawing.Image)(resources.GetObject("btnRefuge.Image")));
            this.btnRefuge.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnRefuge.Location = new System.Drawing.Point(12, 360);
            this.btnRefuge.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnRefuge.Name = "btnRefuge";
            this.btnRefuge.Size = new System.Drawing.Size(132, 62);
            this.btnRefuge.TabIndex = 7;
            this.btnRefuge.Text = "Refuge";
            this.btnRefuge.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnRefuge.UseVisualStyleBackColor = true;
            // 
            // btnChemin
            // 
            this.btnChemin.Image = ((System.Drawing.Image)(resources.GetObject("btnChemin.Image")));
            this.btnChemin.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnChemin.Location = new System.Drawing.Point(344, 360);
            this.btnChemin.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnChemin.Name = "btnChemin";
            this.btnChemin.Size = new System.Drawing.Size(132, 62);
            this.btnChemin.TabIndex = 8;
            this.btnChemin.Text = "Chemins";
            this.btnChemin.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnChemin.UseVisualStyleBackColor = true;
            // 
            // btnClub
            // 
            this.btnClub.Image = ((System.Drawing.Image)(resources.GetObject("btnClub.Image")));
            this.btnClub.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnClub.Location = new System.Drawing.Point(504, 360);
            this.btnClub.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnClub.Name = "btnClub";
            this.btnClub.Size = new System.Drawing.Size(132, 62);
            this.btnClub.TabIndex = 9;
            this.btnClub.Text = "Club";
            this.btnClub.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnClub.UseVisualStyleBackColor = true;
            // 
            // pbPersonnes
            // 
            this.pbPersonnes.Image = ((System.Drawing.Image)(resources.GetObject("pbPersonnes.Image")));
            this.pbPersonnes.Location = new System.Drawing.Point(719, 13);
            this.pbPersonnes.Name = "pbPersonnes";
            this.pbPersonnes.Size = new System.Drawing.Size(30, 28);
            this.pbPersonnes.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbPersonnes.TabIndex = 10;
            this.pbPersonnes.TabStop = false;
            // 
            // FormJeu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.pbPersonnes);
            this.Controls.Add(this.btnClub);
            this.Controls.Add(this.btnChemin);
            this.Controls.Add(this.btnRefuge);
            this.Controls.Add(this.btnTrain);
            this.Controls.Add(this.btnUsine);
            this.Controls.Add(this.lblPays2);
            this.Controls.Add(this.lblPays3);
            this.Controls.Add(this.lblPays1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.pbAide);
            this.Name = "FormJeu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormJeu";
            ((System.ComponentModel.ISupportInitialize)(this.pbAide)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbPersonnes)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pbAide;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblPays1;
        private System.Windows.Forms.Label lblPays3;
        private System.Windows.Forms.Label lblPays2;
        private System.Windows.Forms.Button btnUsine;
        private System.Windows.Forms.Button btnTrain;
        private System.Windows.Forms.Button btnRefuge;
        private System.Windows.Forms.Button btnChemin;
        private System.Windows.Forms.Button btnClub;
        private System.Windows.Forms.PictureBox pbPersonnes;
    }
}