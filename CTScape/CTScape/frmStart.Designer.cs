namespace CTScape
{
    partial class frmStart
    {
        /// <summary>
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur Windows Form

        /// <summary>
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmStart));
            this.btnStart = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnTutoriel = new System.Windows.Forms.Button();
            this.rdbClassique = new System.Windows.Forms.RadioButton();
            this.rdbDefi = new System.Windows.Forms.RadioButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnStart
            // 
            this.btnStart.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnStart.BackgroundImage")));
            this.btnStart.Location = new System.Drawing.Point(76, 183);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(64, 61);
            this.btnStart.TabIndex = 0;
            this.btnStart.UseVisualStyleBackColor = true;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // button1
            // 
            this.button1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button1.BackgroundImage")));
            this.button1.Location = new System.Drawing.Point(157, 183);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(64, 61);
            this.button1.TabIndex = 1;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(12, 13);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(270, 164);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // btnTutoriel
            // 
            this.btnTutoriel.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnTutoriel.BackgroundImage")));
            this.btnTutoriel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnTutoriel.Location = new System.Drawing.Point(1, 2);
            this.btnTutoriel.Name = "btnTutoriel";
            this.btnTutoriel.Size = new System.Drawing.Size(37, 36);
            this.btnTutoriel.TabIndex = 3;
            this.btnTutoriel.UseVisualStyleBackColor = true;
            this.btnTutoriel.Click += new System.EventHandler(this.btnTutoriel_Click);
            this.btnTutoriel.MouseHover += new System.EventHandler(this.btnTutoriel_MouseHover);
            // 
            // rdbClassique
            // 
            this.rdbClassique.AutoSize = true;
            this.rdbClassique.Location = new System.Drawing.Point(26, 19);
            this.rdbClassique.Name = "rdbClassique";
            this.rdbClassique.Size = new System.Drawing.Size(99, 17);
            this.rdbClassique.TabIndex = 4;
            this.rdbClassique.TabStop = true;
            this.rdbClassique.Text = "Mode classique";
            this.rdbClassique.UseVisualStyleBackColor = true;
            // 
            // rdbDefi
            // 
            this.rdbDefi.AutoSize = true;
            this.rdbDefi.Location = new System.Drawing.Point(26, 38);
            this.rdbDefi.Name = "rdbDefi";
            this.rdbDefi.Size = new System.Drawing.Size(72, 17);
            this.rdbDefi.TabIndex = 6;
            this.rdbDefi.TabStop = true;
            this.rdbDefi.Text = "Mode défi";
            this.rdbDefi.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rdbClassique);
            this.groupBox1.Controls.Add(this.rdbDefi);
            this.groupBox1.Location = new System.Drawing.Point(1, 183);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(141, 61);
            this.groupBox1.TabIndex = 7;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Choisis un mode de jeu :";
            // 
            // frmStart
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(294, 256);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnTutoriel);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnStart);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmStart";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CTScape";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnTutoriel;
        private System.Windows.Forms.RadioButton rdbClassique;
        private System.Windows.Forms.RadioButton rdbDefi;
        private System.Windows.Forms.GroupBox groupBox1;
    }
}

