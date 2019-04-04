namespace CTScape
{
    partial class frmDepart
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmDepart));
            this.pcbPointArrive = new System.Windows.Forms.PictureBox();
            this.pcbPointDep = new System.Windows.Forms.PictureBox();
            this.lbDepart = new System.Windows.Forms.Label();
            this.lbArrive = new System.Windows.Forms.Label();
            this.pcbArretDep = new System.Windows.Forms.PictureBox();
            this.lbArretDep = new System.Windows.Forms.Label();
            this.pcbTram = new System.Windows.Forms.PictureBox();
            this.lbTram = new System.Windows.Forms.Label();
            this.pcbPlan = new System.Windows.Forms.PictureBox();
            this.lbPlan = new System.Windows.Forms.Label();
            this.pcbDirection = new System.Windows.Forms.PictureBox();
            this.pcbArretFin = new System.Windows.Forms.PictureBox();
            this.lbArretFin = new System.Windows.Forms.Label();
            this.lbDirection = new System.Windows.Forms.Label();
            this.btnValider = new System.Windows.Forms.Button();
            this.btnFermer = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pcbPointArrive)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcbPointDep)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcbArretDep)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcbTram)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcbPlan)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcbDirection)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcbArretFin)).BeginInit();
            this.SuspendLayout();
            // 
            // pcbPointArrive
            // 
            this.pcbPointArrive.Image = ((System.Drawing.Image)(resources.GetObject("pcbPointArrive.Image")));
            this.pcbPointArrive.Location = new System.Drawing.Point(891, 119);
            this.pcbPointArrive.Name = "pcbPointArrive";
            this.pcbPointArrive.Size = new System.Drawing.Size(154, 127);
            this.pcbPointArrive.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pcbPointArrive.TabIndex = 0;
            this.pcbPointArrive.TabStop = false;
            // 
            // pcbPointDep
            // 
            this.pcbPointDep.Image = ((System.Drawing.Image)(resources.GetObject("pcbPointDep.Image")));
            this.pcbPointDep.Location = new System.Drawing.Point(5, 119);
            this.pcbPointDep.Name = "pcbPointDep";
            this.pcbPointDep.Size = new System.Drawing.Size(114, 127);
            this.pcbPointDep.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pcbPointDep.TabIndex = 1;
            this.pcbPointDep.TabStop = false;
            // 
            // lbDepart
            // 
            this.lbDepart.AutoSize = true;
            this.lbDepart.Location = new System.Drawing.Point(17, 249);
            this.lbDepart.Name = "lbDepart";
            this.lbDepart.Size = new System.Drawing.Size(79, 13);
            this.lbDepart.TabIndex = 2;
            this.lbDepart.Text = "Point de départ";
            // 
            // lbArrive
            // 
            this.lbArrive.AutoSize = true;
            this.lbArrive.Location = new System.Drawing.Point(900, 251);
            this.lbArrive.Name = "lbArrive";
            this.lbArrive.Size = new System.Drawing.Size(138, 13);
            this.lbArrive.TabIndex = 3;
            this.lbArrive.Text = "Point d\'arrivé : Cinéma UGC";
            // 
            // pcbArretDep
            // 
            this.pcbArretDep.Image = ((System.Drawing.Image)(resources.GetObject("pcbArretDep.Image")));
            this.pcbArretDep.Location = new System.Drawing.Point(255, 126);
            this.pcbArretDep.Name = "pcbArretDep";
            this.pcbArretDep.Size = new System.Drawing.Size(168, 117);
            this.pcbArretDep.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pcbArretDep.TabIndex = 4;
            this.pcbArretDep.TabStop = false;
            this.pcbArretDep.Visible = false;
            // 
            // lbArretDep
            // 
            this.lbArretDep.AutoSize = true;
            this.lbArretDep.Location = new System.Drawing.Point(264, 251);
            this.lbArretDep.Name = "lbArretDep";
            this.lbArretDep.Size = new System.Drawing.Size(145, 13);
            this.lbArretDep.TabIndex = 5;
            this.lbArretDep.Text = "Arrêt de départ : Emile Mathis";
            this.lbArretDep.Visible = false;
            // 
            // pcbTram
            // 
            this.pcbTram.Image = ((System.Drawing.Image)(resources.GetObject("pcbTram.Image")));
            this.pcbTram.Location = new System.Drawing.Point(123, 119);
            this.pcbTram.Name = "pcbTram";
            this.pcbTram.Size = new System.Drawing.Size(121, 127);
            this.pcbTram.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pcbTram.TabIndex = 6;
            this.pcbTram.TabStop = false;
            this.pcbTram.Visible = false;
            // 
            // lbTram
            // 
            this.lbTram.AutoSize = true;
            this.lbTram.Location = new System.Drawing.Point(159, 251);
            this.lbTram.Name = "lbTram";
            this.lbTram.Size = new System.Drawing.Size(31, 13);
            this.lbTram.TabIndex = 7;
            this.lbTram.Text = "Tram";
            this.lbTram.Visible = false;
            // 
            // pcbPlan
            // 
            this.pcbPlan.Image = ((System.Drawing.Image)(resources.GetObject("pcbPlan.Image")));
            this.pcbPlan.Location = new System.Drawing.Point(728, 85);
            this.pcbPlan.Name = "pcbPlan";
            this.pcbPlan.Size = new System.Drawing.Size(157, 206);
            this.pcbPlan.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pcbPlan.TabIndex = 8;
            this.pcbPlan.TabStop = false;
            this.pcbPlan.Visible = false;
            // 
            // lbPlan
            // 
            this.lbPlan.AutoSize = true;
            this.lbPlan.Location = new System.Drawing.Point(766, 294);
            this.lbPlan.Name = "lbPlan";
            this.lbPlan.Size = new System.Drawing.Size(81, 13);
            this.lbPlan.TabIndex = 9;
            this.lbPlan.Text = "Plan de marche";
            this.lbPlan.Visible = false;
            // 
            // pcbDirection
            // 
            this.pcbDirection.Image = ((System.Drawing.Image)(resources.GetObject("pcbDirection.Image")));
            this.pcbDirection.Location = new System.Drawing.Point(429, 170);
            this.pcbDirection.Name = "pcbDirection";
            this.pcbDirection.Size = new System.Drawing.Size(128, 26);
            this.pcbDirection.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pcbDirection.TabIndex = 10;
            this.pcbDirection.TabStop = false;
            this.pcbDirection.Visible = false;
            // 
            // pcbArretFin
            // 
            this.pcbArretFin.Image = ((System.Drawing.Image)(resources.GetObject("pcbArretFin.Image")));
            this.pcbArretFin.Location = new System.Drawing.Point(562, 137);
            this.pcbArretFin.Name = "pcbArretFin";
            this.pcbArretFin.Size = new System.Drawing.Size(159, 96);
            this.pcbArretFin.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pcbArretFin.TabIndex = 11;
            this.pcbArretFin.TabStop = false;
            this.pcbArretFin.Visible = false;
            // 
            // lbArretFin
            // 
            this.lbArretFin.AutoSize = true;
            this.lbArretFin.Location = new System.Drawing.Point(570, 249);
            this.lbArretFin.Name = "lbArretFin";
            this.lbArretFin.Size = new System.Drawing.Size(125, 13);
            this.lbArretFin.TabIndex = 12;
            this.lbArretFin.Text = "Arrêt d\'arrivé : Landsberg";
            this.lbArretFin.Visible = false;
            // 
            // lbDirection
            // 
            this.lbDirection.AutoSize = true;
            this.lbDirection.Location = new System.Drawing.Point(463, 249);
            this.lbDirection.Name = "lbDirection";
            this.lbDirection.Size = new System.Drawing.Size(49, 13);
            this.lbDirection.TabIndex = 13;
            this.lbDirection.Text = "Direction";
            this.lbDirection.Visible = false;
            // 
            // btnValider
            // 
            this.btnValider.Enabled = false;
            this.btnValider.Location = new System.Drawing.Point(549, 383);
            this.btnValider.Name = "btnValider";
            this.btnValider.Size = new System.Drawing.Size(128, 30);
            this.btnValider.TabIndex = 14;
            this.btnValider.Text = "Valider";
            this.btnValider.UseVisualStyleBackColor = true;
            this.btnValider.Click += new System.EventHandler(this.btnValider_Click);
            // 
            // btnFermer
            // 
            this.btnFermer.Location = new System.Drawing.Point(415, 383);
            this.btnFermer.Name = "btnFermer";
            this.btnFermer.Size = new System.Drawing.Size(128, 30);
            this.btnFermer.TabIndex = 15;
            this.btnFermer.Text = "Fermer";
            this.btnFermer.UseVisualStyleBackColor = true;
            this.btnFermer.Click += new System.EventHandler(this.btnFermer_Click);
            // 
            // frmDepart
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1047, 425);
            this.Controls.Add(this.btnFermer);
            this.Controls.Add(this.btnValider);
            this.Controls.Add(this.lbDirection);
            this.Controls.Add(this.lbArretFin);
            this.Controls.Add(this.pcbArretFin);
            this.Controls.Add(this.pcbDirection);
            this.Controls.Add(this.lbPlan);
            this.Controls.Add(this.pcbPlan);
            this.Controls.Add(this.lbTram);
            this.Controls.Add(this.pcbTram);
            this.Controls.Add(this.lbArretDep);
            this.Controls.Add(this.pcbArretDep);
            this.Controls.Add(this.lbArrive);
            this.Controls.Add(this.lbDepart);
            this.Controls.Add(this.pcbPointDep);
            this.Controls.Add(this.pcbPointArrive);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "frmDepart";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Indices";
            ((System.ComponentModel.ISupportInitialize)(this.pcbPointArrive)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcbPointDep)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcbArretDep)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcbTram)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcbPlan)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcbDirection)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcbArretFin)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pcbPointArrive;
        private System.Windows.Forms.PictureBox pcbPointDep;
        public System.Windows.Forms.Label lbDepart;
        public System.Windows.Forms.Label lbArrive;
        public System.Windows.Forms.PictureBox pcbArretDep;
        public System.Windows.Forms.Label lbArretDep;
        public System.Windows.Forms.PictureBox pcbTram;
        public System.Windows.Forms.Label lbTram;
        public System.Windows.Forms.PictureBox pcbPlan;
        public System.Windows.Forms.Label lbPlan;
        public System.Windows.Forms.PictureBox pcbDirection;
        public System.Windows.Forms.PictureBox pcbArretFin;
        public System.Windows.Forms.Label lbArretFin;
        public System.Windows.Forms.Label lbDirection;
        public System.Windows.Forms.Button btnValider;
        private System.Windows.Forms.Button btnFermer;
    }
}