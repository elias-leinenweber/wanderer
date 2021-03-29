
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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblPays1 = new System.Windows.Forms.Label();
            this.lblPays3 = new System.Windows.Forms.Label();
            this.lblPays2 = new System.Windows.Forms.Label();
            this.btnUsine = new System.Windows.Forms.Button();
            this.btnTrain = new System.Windows.Forms.Button();
            this.btnRefuge = new System.Windows.Forms.Button();
            this.btnChemin = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(14, 15);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(63, 61);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // panel1
            // 
            this.panel1.Location = new System.Drawing.Point(123, 12);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(680, 70);
            this.panel1.TabIndex = 1;
            // 
            // lblPays1
            // 
            this.lblPays1.AutoSize = true;
            this.lblPays1.Location = new System.Drawing.Point(83, 216);
            this.lblPays1.Name = "lblPays1";
            this.lblPays1.Size = new System.Drawing.Size(52, 20);
            this.lblPays1.TabIndex = 2;
            this.lblPays1.Text = "Pays1";
            // 
            // lblPays3
            // 
            this.lblPays3.AutoSize = true;
            this.lblPays3.Location = new System.Drawing.Point(411, 355);
            this.lblPays3.Name = "lblPays3";
            this.lblPays3.Size = new System.Drawing.Size(52, 20);
            this.lblPays3.TabIndex = 3;
            this.lblPays3.Text = "Pays3";
            // 
            // lblPays2
            // 
            this.lblPays2.AutoSize = true;
            this.lblPays2.Location = new System.Drawing.Point(638, 243);
            this.lblPays2.Name = "lblPays2";
            this.lblPays2.Size = new System.Drawing.Size(52, 20);
            this.lblPays2.TabIndex = 4;
            this.lblPays2.Text = "Pays2";
            // 
            // btnUsine
            // 
            this.btnUsine.Image = ((System.Drawing.Image)(resources.GetObject("btnUsine.Image")));
            this.btnUsine.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnUsine.Location = new System.Drawing.Point(664, 450);
            this.btnUsine.Name = "btnUsine";
            this.btnUsine.Size = new System.Drawing.Size(149, 77);
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
            this.btnTrain.Location = new System.Drawing.Point(250, 450);
            this.btnTrain.Name = "btnTrain";
            this.btnTrain.Size = new System.Drawing.Size(149, 77);
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
            this.btnRefuge.Location = new System.Drawing.Point(51, 450);
            this.btnRefuge.Name = "btnRefuge";
            this.btnRefuge.Size = new System.Drawing.Size(149, 77);
            this.btnRefuge.TabIndex = 7;
            this.btnRefuge.Text = "Refuge";
            this.btnRefuge.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnRefuge.UseVisualStyleBackColor = true;
            // 
            // btnChemin
            // 
            this.btnChemin.Image = ((System.Drawing.Image)(resources.GetObject("btnChemin.Image")));
            this.btnChemin.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnChemin.Location = new System.Drawing.Point(449, 450);
            this.btnChemin.Name = "btnChemin";
            this.btnChemin.Size = new System.Drawing.Size(149, 77);
            this.btnChemin.TabIndex = 8;
            this.btnChemin.Text = "Chemins";
            this.btnChemin.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnChemin.UseVisualStyleBackColor = true;
            // 
            // FormJeu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(900, 562);
            this.Controls.Add(this.btnChemin);
            this.Controls.Add(this.btnRefuge);
            this.Controls.Add(this.btnTrain);
            this.Controls.Add(this.btnUsine);
            this.Controls.Add(this.lblPays2);
            this.Controls.Add(this.lblPays3);
            this.Controls.Add(this.lblPays1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.pictureBox1);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "FormJeu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormJeu";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblPays1;
        private System.Windows.Forms.Label lblPays3;
        private System.Windows.Forms.Label lblPays2;
        private System.Windows.Forms.Button btnUsine;
        private System.Windows.Forms.Button btnTrain;
        private System.Windows.Forms.Button btnRefuge;
        private System.Windows.Forms.Button btnChemin;
    }
}