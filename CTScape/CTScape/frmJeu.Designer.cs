using System;
using System.Threading;

namespace CTScape
{
    partial class frmJeu
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmJeu));
            this.btnIndice2 = new System.Windows.Forms.Button();
            this.btnTiroir1 = new System.Windows.Forms.Button();
            this.btnTiroir2 = new System.Windows.Forms.Button();
            this.btnTiroir3 = new System.Windows.Forms.Button();
            this.btnLampe = new System.Windows.Forms.Button();
            this.btnCorbeille = new System.Windows.Forms.Button();
            this.btnIndice4 = new System.Windows.Forms.Button();
            this.btnTablechevet = new System.Windows.Forms.Button();
            this.btnGateaux = new System.Windows.Forms.Button();
            this.btnLit = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.button12 = new System.Windows.Forms.Button();
            this.btnBackMenu = new System.Windows.Forms.Button();
            this.pcbLumiere = new System.Windows.Forms.PictureBox();
            this.btnIndice3 = new System.Windows.Forms.Button();
            this.lbIndices = new System.Windows.Forms.Label();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.pcbLumiere)).BeginInit();
            this.SuspendLayout();
            // 
            // btnIndice2
            // 
            this.btnIndice2.BackColor = System.Drawing.Color.Transparent;
            this.btnIndice2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnIndice2.BackgroundImage")));
            this.btnIndice2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnIndice2.ForeColor = System.Drawing.Color.Transparent;
            this.btnIndice2.Location = new System.Drawing.Point(91, 49);
            this.btnIndice2.Name = "btnIndice2";
            this.btnIndice2.Size = new System.Drawing.Size(174, 179);
            this.btnIndice2.TabIndex = 0;
            this.btnIndice2.UseVisualStyleBackColor = false;
            this.btnIndice2.Click += new System.EventHandler(this.btnIndice2_Click);
            // 
            // btnTiroir1
            // 
            this.btnTiroir1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnTiroir1.BackgroundImage")));
            this.btnTiroir1.FlatAppearance.BorderSize = 0;
            this.btnTiroir1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTiroir1.Location = new System.Drawing.Point(722, 267);
            this.btnTiroir1.Margin = new System.Windows.Forms.Padding(2);
            this.btnTiroir1.Name = "btnTiroir1";
            this.btnTiroir1.Size = new System.Drawing.Size(86, 30);
            this.btnTiroir1.TabIndex = 4;
            this.btnTiroir1.UseVisualStyleBackColor = true;
            this.btnTiroir1.Click += new System.EventHandler(this.btnTiroir1_Click);
            // 
            // btnTiroir2
            // 
            this.btnTiroir2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnTiroir2.BackgroundImage")));
            this.btnTiroir2.FlatAppearance.BorderSize = 0;
            this.btnTiroir2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTiroir2.Location = new System.Drawing.Point(722, 296);
            this.btnTiroir2.Margin = new System.Windows.Forms.Padding(2);
            this.btnTiroir2.Name = "btnTiroir2";
            this.btnTiroir2.Size = new System.Drawing.Size(86, 26);
            this.btnTiroir2.TabIndex = 5;
            this.btnTiroir2.UseVisualStyleBackColor = true;
            this.btnTiroir2.Click += new System.EventHandler(this.btnTiroir2_Click);
            // 
            // btnTiroir3
            // 
            this.btnTiroir3.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnTiroir3.BackgroundImage")));
            this.btnTiroir3.FlatAppearance.BorderSize = 0;
            this.btnTiroir3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTiroir3.Location = new System.Drawing.Point(722, 322);
            this.btnTiroir3.Margin = new System.Windows.Forms.Padding(2);
            this.btnTiroir3.Name = "btnTiroir3";
            this.btnTiroir3.Size = new System.Drawing.Size(86, 26);
            this.btnTiroir3.TabIndex = 6;
            this.btnTiroir3.UseVisualStyleBackColor = true;
            this.btnTiroir3.Click += new System.EventHandler(this.btnTiroir3_Click);
            // 
            // btnLampe
            // 
            this.btnLampe.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnLampe.BackgroundImage")));
            this.btnLampe.Location = new System.Drawing.Point(756, 203);
            this.btnLampe.Margin = new System.Windows.Forms.Padding(2);
            this.btnLampe.Name = "btnLampe";
            this.btnLampe.Size = new System.Drawing.Size(38, 53);
            this.btnLampe.TabIndex = 7;
            this.btnLampe.UseVisualStyleBackColor = true;
            this.btnLampe.Click += new System.EventHandler(this.btnLampe_Click);
            // 
            // btnCorbeille
            // 
            this.btnCorbeille.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnCorbeille.BackgroundImage")));
            this.btnCorbeille.Location = new System.Drawing.Point(666, 303);
            this.btnCorbeille.Margin = new System.Windows.Forms.Padding(2);
            this.btnCorbeille.Name = "btnCorbeille";
            this.btnCorbeille.Size = new System.Drawing.Size(39, 48);
            this.btnCorbeille.TabIndex = 8;
            this.btnCorbeille.UseVisualStyleBackColor = true;
            this.btnCorbeille.Click += new System.EventHandler(this.btnCorbeille_Click);
            // 
            // btnIndice4
            // 
            this.btnIndice4.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnIndice4.BackgroundImage")));
            this.btnIndice4.FlatAppearance.BorderSize = 0;
            this.btnIndice4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnIndice4.Location = new System.Drawing.Point(56, 311);
            this.btnIndice4.Name = "btnIndice4";
            this.btnIndice4.Size = new System.Drawing.Size(65, 21);
            this.btnIndice4.TabIndex = 2;
            this.btnIndice4.UseVisualStyleBackColor = true;
            this.btnIndice4.Click += new System.EventHandler(this.btnIndice4_Click);
            // 
            // btnTablechevet
            // 
            this.btnTablechevet.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnTablechevet.BackgroundImage")));
            this.btnTablechevet.FlatAppearance.BorderSize = 0;
            this.btnTablechevet.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTablechevet.Location = new System.Drawing.Point(57, 336);
            this.btnTablechevet.Name = "btnTablechevet";
            this.btnTablechevet.Size = new System.Drawing.Size(65, 21);
            this.btnTablechevet.TabIndex = 3;
            this.btnTablechevet.UseVisualStyleBackColor = true;
            this.btnTablechevet.Click += new System.EventHandler(this.btnTablechevet_Click);
            // 
            // btnGateaux
            // 
            this.btnGateaux.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnGateaux.BackgroundImage")));
            this.btnGateaux.Location = new System.Drawing.Point(533, 50);
            this.btnGateaux.Name = "btnGateaux";
            this.btnGateaux.Size = new System.Drawing.Size(59, 24);
            this.btnGateaux.TabIndex = 9;
            this.btnGateaux.UseVisualStyleBackColor = true;
            this.btnGateaux.Click += new System.EventHandler(this.btnGateaux_Click);
            // 
            // btnLit
            // 
            this.btnLit.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnLit.BackgroundImage")));
            this.btnLit.FlatAppearance.BorderSize = 0;
            this.btnLit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLit.Location = new System.Drawing.Point(190, 274);
            this.btnLit.Name = "btnLit";
            this.btnLit.Size = new System.Drawing.Size(75, 23);
            this.btnLit.TabIndex = 10;
            this.btnLit.UseVisualStyleBackColor = true;
            this.btnLit.Click += new System.EventHandler(this.btnLit_Click);
            // 
            // btnExit
            // 
            this.btnExit.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnExit.BackgroundImage")));
            this.btnExit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnExit.Location = new System.Drawing.Point(722, 375);
            this.btnExit.Name = "btnExit";
            this.btnExit.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btnExit.Size = new System.Drawing.Size(73, 67);
            this.btnExit.TabIndex = 11;
            this.btnExit.Text = "Sortir de la pièce";
            this.btnExit.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // button12
            // 
            this.button12.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button12.BackgroundImage")));
            this.button12.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button12.Location = new System.Drawing.Point(751, 5);
            this.button12.Name = "button12";
            this.button12.Size = new System.Drawing.Size(46, 45);
            this.button12.TabIndex = 13;
            this.button12.UseVisualStyleBackColor = true;
            this.button12.Click += new System.EventHandler(this.button12_Click);
            // 
            // btnBackMenu
            // 
            this.btnBackMenu.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnBackMenu.BackgroundImage")));
            this.btnBackMenu.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnBackMenu.Location = new System.Drawing.Point(700, 5);
            this.btnBackMenu.Name = "btnBackMenu";
            this.btnBackMenu.Size = new System.Drawing.Size(45, 45);
            this.btnBackMenu.TabIndex = 14;
            this.btnBackMenu.UseVisualStyleBackColor = true;
            this.btnBackMenu.Click += new System.EventHandler(this.btnBackMenu_Click);
            // 
            // pcbLumiere
            // 
            this.pcbLumiere.Image = ((System.Drawing.Image)(resources.GetObject("pcbLumiere.Image")));
            this.pcbLumiere.Location = new System.Drawing.Point(623, 97);
            this.pcbLumiere.Margin = new System.Windows.Forms.Padding(2);
            this.pcbLumiere.Name = "pcbLumiere";
            this.pcbLumiere.Size = new System.Drawing.Size(175, 152);
            this.pcbLumiere.TabIndex = 15;
            this.pcbLumiere.TabStop = false;
            this.pcbLumiere.Visible = false;
            // 
            // btnIndice3
            // 
            this.btnIndice3.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnIndice3.BackgroundImage")));
            this.btnIndice3.Location = new System.Drawing.Point(439, 230);
            this.btnIndice3.Name = "btnIndice3";
            this.btnIndice3.Size = new System.Drawing.Size(59, 67);
            this.btnIndice3.TabIndex = 16;
            this.btnIndice3.UseVisualStyleBackColor = true;
            this.btnIndice3.Click += new System.EventHandler(this.btnIndice3_Click);
            // 
            // lbIndices
            // 
            this.lbIndices.AutoSize = true;
            this.lbIndices.BackColor = System.Drawing.Color.Transparent;
            this.lbIndices.Font = new System.Drawing.Font("Palatino Linotype", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbIndices.Location = new System.Drawing.Point(648, 57);
            this.lbIndices.Name = "lbIndices";
            this.lbIndices.Size = new System.Drawing.Size(140, 17);
            this.lbIndices.TabIndex = 17;
            this.lbIndices.Text = "Indice(s) :  0 / 5 trouvé(s)";
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(283, 5);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(261, 23);
            this.progressBar1.TabIndex = 18;
            this.progressBar1.Click += new System.EventHandler(this.progressBar1_Click);


            // 
            // frmJeu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.progressBar1);
            this.Controls.Add(this.lbIndices);
            this.Controls.Add(this.btnIndice3);
            this.Controls.Add(this.btnBackMenu);
            this.Controls.Add(this.button12);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnLit);
            this.Controls.Add(this.btnGateaux);
            this.Controls.Add(this.btnCorbeille);
            this.Controls.Add(this.btnLampe);
            this.Controls.Add(this.btnTiroir3);
            this.Controls.Add(this.btnTiroir2);
            this.Controls.Add(this.btnTiroir1);
            this.Controls.Add(this.btnTablechevet);
            this.Controls.Add(this.btnIndice4);
            this.Controls.Add(this.btnIndice2);
            this.Controls.Add(this.pcbLumiere);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmJeu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmJeu";
            this.Load += new System.EventHandler(this.frmJeu_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pcbLumiere)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnIndice2;
        private System.Windows.Forms.Button btnTiroir1;
        private System.Windows.Forms.Button btnTiroir2;
        private System.Windows.Forms.Button btnTiroir3;
        private System.Windows.Forms.Button btnLampe;
        private System.Windows.Forms.Button btnCorbeille;
        private System.Windows.Forms.Button btnIndice4;
        private System.Windows.Forms.Button btnTablechevet;
        private System.Windows.Forms.Button btnGateaux;
        private System.Windows.Forms.Button btnLit;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button button12;
        private System.Windows.Forms.Button btnBackMenu;
        private System.Windows.Forms.PictureBox pcbLumiere;
        private System.Windows.Forms.Button btnIndice3;
        private System.Windows.Forms.Label lbIndices;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.Timer timer1;
    }
}
