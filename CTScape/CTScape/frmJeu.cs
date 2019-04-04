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
        public frmJeu()
        {
            InitializeComponent();
        }

        private void btnIndice2_Click(object sender, EventArgs e)
        {
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

            btnIndice4.FlatStyle = FlatStyle.Flat;
            btnIndice4.FlatAppearance.BorderColor = Color.FromArgb(180, 134, 81);
            btnIndice4.FlatAppearance.MouseOverBackColor = Color.FromArgb(180, 134, 81);
            btnIndice4.FlatAppearance.MouseDownBackColor = Color.FromArgb(180, 134, 81);

            btnTablechevet.FlatStyle = FlatStyle.Flat;
            btnTablechevet.FlatAppearance.BorderColor = Color.FromArgb(180, 135, 82);
            btnTablechevet.FlatAppearance.MouseOverBackColor = Color.FromArgb(180, 135, 82);
            btnTablechevet.FlatAppearance.MouseDownBackColor = Color.FromArgb(180, 135, 82);
        }

        private void button12_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnBackMenu_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmStart start = new frmStart();
            start.ShowDialog();
        }

        private void btnIndice3_Click(object sender, EventArgs e)
        {
            frmIndice3 indice = new frmIndice3();
            indice.ShowDialog();
        }

        private void btnGateaux_Click(object sender, EventArgs e)
        {
            MessageBox.Show("C'est pas l'heure de grignoter des gateaux ! Reviens plus tard");
        }

        private void btnIndice4_Click(object sender, EventArgs e)
        {
            frmIndice4 indice = new frmIndice4();
            indice.ShowDialog();
        }

        private void btnTablechevet_Click(object sender, EventArgs e)
        {
            frmTableChevet indice = new frmTableChevet();
            indice.ShowDialog();
        }
    }
}
