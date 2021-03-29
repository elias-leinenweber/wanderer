namespace Wanderer
{
    partial class FormMainMenu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMainMenu));
            this.btnPlay = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.btnAide = new System.Windows.Forms.Button();
            this.lbltitre = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnPlay
            // 
            this.btnPlay.BackColor = System.Drawing.Color.Transparent;
            this.btnPlay.FlatAppearance.BorderSize = 3;
            this.btnPlay.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Moccasin;
            this.btnPlay.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPlay.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPlay.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnPlay.Location = new System.Drawing.Point(193, 87);
            this.btnPlay.Margin = new System.Windows.Forms.Padding(2);
            this.btnPlay.Location = new System.Drawing.Point(290, 134);
            this.btnPlay.Name = "btnPlay";
            this.btnPlay.Size = new System.Drawing.Size(328, 129);
            this.btnPlay.TabIndex = 0;
            this.btnPlay.Text = "Jouer";
            this.btnPlay.UseVisualStyleBackColor = false;
            this.btnPlay.Click += new System.EventHandler(this.btnPlay_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Transparent;
            this.button1.FlatAppearance.BorderSize = 3;
            this.button1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Moccasin;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button1.Location = new System.Drawing.Point(193, 269);
            this.button1.Margin = new System.Windows.Forms.Padding(4);
            this.button1.Location = new System.Drawing.Point(290, 414);
            this.button1.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(328, 129);
            this.button1.TabIndex = 1;
            this.button1.Text = "Quitter";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnAide
            // 
            this.btnAide.BackColor = System.Drawing.Color.Transparent;
            this.btnAide.FlatAppearance.BorderSize = 3;
            this.btnAide.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Moccasin;
            this.btnAide.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAide.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAide.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnAide.Location = new System.Drawing.Point(193, 177);
            this.btnAide.Margin = new System.Windows.Forms.Padding(4);
            this.btnAide.Location = new System.Drawing.Point(290, 272);
            this.btnAide.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.btnAide.Name = "btnAide";
            this.btnAide.Size = new System.Drawing.Size(328, 129);
            this.btnAide.TabIndex = 2;
            this.btnAide.Text = "Aide";
            this.btnAide.UseVisualStyleBackColor = false;
            this.btnAide.Click += new System.EventHandler(this.btnAide_Click);
            // 
            // lbltitre
            // 
            this.lbltitre.AutoSize = true;
            this.lbltitre.BackColor = System.Drawing.Color.Transparent;
            this.lbltitre.Font = new System.Drawing.Font("GOST Common", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbltitre.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lbltitre.Location = new System.Drawing.Point(156, 7);
            this.lbltitre.Name = "lbltitre";
            this.lbltitre.Size = new System.Drawing.Size(305, 78);
            this.lbltitre.Font = new System.Drawing.Font("OCR A Extended", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbltitre.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lbltitre.Location = new System.Drawing.Point(207, 18);
            this.lbltitre.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbltitre.Name = "lbltitre";
            this.lbltitre.Size = new System.Drawing.Size(506, 99);
            this.lbltitre.TabIndex = 3;
            this.lbltitre.Text = "Wanderer";
            // 
            // FormMainMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(900, 551);
            this.Controls.Add(this.lbltitre);
            this.Controls.Add(this.btnAide);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnPlay);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormMainMenu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "s";
            this.Load += new System.EventHandler(this.FormMainMenu_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnPlay;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btnAide;
        private System.Windows.Forms.Label lbltitre;
    }
}