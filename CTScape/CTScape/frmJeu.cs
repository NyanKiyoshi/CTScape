using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CTScape
{
    public partial class frmJeu : Form
    {
        int count = 0;
        frmDepart depart = new frmDepart();
        private bool verite1 = false;
        private bool verite2 = false;
        private bool verite3 = false;
        private bool verite4 = false;
        private bool verite5 = false;

      
        public frmJeu()
        {
            InitializeComponent();
           
        }

        private void btnIndice2_Click(object sender, EventArgs e)
        {
            if (!verite2)
            {
                depart.pcbPlan.Visible = true;
                depart.lbPlan.Visible = true;
                count++;
                lbIndices.Text = "Indice(s) : " + count + " / 5 trouvé(s)";
                verite2 = true;
            }
            frmIndice2 indice = new frmIndice2();
            indice.ShowDialog();
        }

        private void frmJeu_Load(object sender, EventArgs e)
        {
            btnIndice2.FlatStyle = FlatStyle.Flat;
            btnIndice2.FlatAppearance.BorderColor = Color.FromArgb(246, 245, 188);
            btnIndice2.FlatAppearance.MouseOverBackColor = Color.FromArgb(246, 245, 188);
            btnIndice2.FlatAppearance.MouseDownBackColor = Color.FromArgb(246, 245, 188);

            btnIndice3.FlatStyle = FlatStyle.Flat;
            btnIndice3.FlatAppearance.BorderColor = Color.FromArgb(92, 52, 17);
            btnIndice2.FlatAppearance.MouseOverBackColor = Color.FromArgb(92, 52, 17);
            btnIndice2.FlatAppearance.MouseDownBackColor = Color.FromArgb(92, 52, 17);

            btnGateaux.FlatStyle = FlatStyle.Flat;
            btnGateaux.FlatAppearance.BorderColor = Color.FromArgb(245, 248, 193);
            btnGateaux.FlatAppearance.MouseOverBackColor = Color.FromArgb(245, 248, 193);
            btnGateaux.FlatAppearance.MouseDownBackColor = Color.FromArgb(245, 248, 193);
            btnCorbeille.FlatStyle = FlatStyle.Flat;
            btnCorbeille.FlatAppearance.BorderColor = Color.FromArgb(58, 104, 54);
            btnCorbeille.FlatAppearance.MouseOverBackColor = Color.FromArgb(58, 104, 54);
            btnCorbeille.FlatAppearance.MouseDownBackColor = Color.FromArgb(58, 104, 54);
            btnLampe.FlatStyle = FlatStyle.Flat;
            btnLampe.FlatAppearance.BorderColor = Color.FromArgb(246, 245, 188);
            btnLampe.FlatAppearance.MouseOverBackColor = Color.FromArgb(246, 245, 188);
            btnLampe.FlatAppearance.MouseDownBackColor = Color.FromArgb(246, 245, 188);

            btnIndice4.FlatStyle = FlatStyle.Flat;
            btnIndice4.FlatAppearance.BorderColor = Color.FromArgb(180, 134, 81);
            btnIndice4.FlatAppearance.MouseOverBackColor = Color.FromArgb(180, 134, 81);
            btnIndice4.FlatAppearance.MouseDownBackColor = Color.FromArgb(180, 134, 81);

            btnTablechevet.FlatStyle = FlatStyle.Flat;
            btnTablechevet.FlatAppearance.BorderColor = Color.FromArgb(180, 135, 82);
            btnTablechevet.FlatAppearance.MouseOverBackColor = Color.FromArgb(180, 135, 82);
            btnTablechevet.FlatAppearance.MouseDownBackColor = Color.FromArgb(180, 135, 82);

            MessageBox.Show("Ton ami te propose de le rejoindre au cinéma UGC à Strasbourg. tu acceptes ! Trouves tous les indices dans la pièce qui te permettront de le rejoindre.");


         
            

            timer1.Enabled = true;
            timer1.Start();
            timer1.Interval = 2000;
            progressBar1.Maximum = 10;
            timer1.Tick += new EventHandler(timer1_Tick);

            
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (progressBar1.Value != 10)
            {
                progressBar1.Value++;
            }
            else
            {
                timer1.Stop();
                this.Close();
                MessageBox.Show(" Le temps est écoulé ! Retente ta chance. ");
                frmStart start = new frmStart();
                start.ShowDialog();
            }
        }

        private void button12_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnBackMenu_Click(object sender, EventArgs e)
        {
            frmStart start = new frmStart();
            start.ShowDialog();
            this.Close();
        }

        private void btnIndice3_Click(object sender, EventArgs e)
        {
            if (!verite3)
            {
                depart.pcbArretFin.Visible = true;
                depart.lbArretFin.Visible = true;
                count++;
                lbIndices.Text = "Indice(s) : " + count + " / 5 trouvé(s)";
                verite3 = true;
            }
            frmIndice3 indice = new frmIndice3();
            indice.ShowDialog();
        }

        private void btnGateaux_Click(object sender, EventArgs e)
        {
            MessageBox.Show("C'est pas l'heure de grignoter des gateaux ! Reviens plus tard");
        }

        private void btnCorbeille_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Il faut penser à sortir la poubelle");
        }

        private void btnLampe_Click(object sender, EventArgs e)
        {
            if (pcbLumiere.Visible == false)
                pcbLumiere.Visible = true;
            else
                pcbLumiere.Visible = false;
        }

        private void btnIndice4_Click(object sender, EventArgs e)
        {
            if (!verite4)
            {
                depart.pcbDirection.Visible = true;
                depart.lbDirection.Visible = true;
                count++;
                lbIndices.Text = "Indice(s) : " + count + " / 5 trouvé(s)";
                verite4 = true;
            }
            frmIndice4 indice = new frmIndice4();
            indice.ShowDialog();
        }

        private void btnTablechevet_Click(object sender, EventArgs e)
        {
            frmTableChevet indice = new frmTableChevet();
            indice.ShowDialog();
        }

        private void btnTiroir1_Click(object sender, EventArgs e)
        {
            if (!verite1)
            {
                depart.pcbTram.Visible = true;
                depart.lbTram.Visible = true;
                count++;
                lbIndices.Text = "Indice(s) : " + count + " / 5 trouvé(s)";
                verite1 = true;
            }
            frmIndice1 indice = new frmIndice1();
            indice.ShowDialog();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            if (count == 5)
            {
                depart.btnValider.Enabled = true;
            }
            depart.ShowDialog();
        }

        private void btnLit_Click(object sender, EventArgs e)
        {
            if (!verite5)
            {
                depart.pcbArretDep.Visible = true;
                depart.lbArretDep.Visible = true;
                count++;
                lbIndices.Text = "Indice(s) : " + count + " / 5 trouvé(s)";
                verite5 = true;
            }
            frmIndice5 indice = new frmIndice5();
            indice.ShowDialog();
        }

        private void btnTiroir2_Click(object sender, EventArgs e)
        {
            frmTableChevet indice = new frmTableChevet();
            indice.ShowDialog();
        }

        private void btnTiroir3_Click(object sender, EventArgs e)
        {
            frmTableChevet indice = new frmTableChevet();
            indice.ShowDialog();
        }

        private void progressBar1_Click(object sender, EventArgs e)
        {

        }
    }
}
