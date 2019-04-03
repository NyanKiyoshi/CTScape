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
    }
}
